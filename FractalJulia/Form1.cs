using System;
using System.Windows.Media.Imaging;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Complex;
using System.Windows.Interop;
using System.Windows;

namespace FractalJulia
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("GDI32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);

        public Form1()
        {
            InitializeComponent();
            if (!Directory.Exists("Изображения"))
            {
                Directory.CreateDirectory("Изображения");
            }
        }

        public static bool HelpOrZ = true; //Если true, то открывать Помощь, иначе Примеры

        public class StackPictures 
        {
            List<Bitmap> array = new List<Bitmap>(4);       

            public Bitmap Pop()
            { 
                if (array.Count == 1)
                    return array.Last();
                array.RemoveAt(array.Count - 1);
                return array.Last();
            }

            public void Add(Bitmap pictures)
            {
                if (array.Count == 4)
                {
                    array.RemoveAt(0);
                    array.Add(pictures);
                }
                else
                    array.Add(pictures);
            }
        }

        public enum SavePicturesFormat
        {
            jpg,
            png,
            bmp,
            jpeg
        }

        GifBitmapEncoder gif = new GifBitmapEncoder();

        public static Enum picturesFormat;
        public static StackPictures stackPictures = new StackPictures();


        //Значения переменных по умолчанию
        int glubinaCount = 200;
        int w = 900;
        int h = 800;
        double zR = -0.2;
        double zIm = 0.75;

        
        #region Получение изображения множества
        //Функция получения готового изображния множества
        static Bitmap PlotJuliaSet(
            ComplexNumber c, int w, int h, int maxIter, IProgress<int> progress = null,
            double xMin = Double.NaN, double yMin = Double.NaN,
            double xMax = Double.NaN, double yMax = Double.NaN)
        {
            double r = CalculateR(c);
            if (Double.IsNaN(xMin) || Double.IsNaN(xMax) || Double.IsNaN(yMin) || Double.IsNaN(yMax))
            {
                xMin = -r;
                yMin = -r;
                xMax = r;
                yMax = r;
            }
            //Debug.WriteLine("R = " + r);
            double xStep = Math.Abs(xMax - xMin) / w;
            double yStep = Math.Abs(yMax - yMin) / h;
            Bitmap bmp = new Bitmap(w, h);

            IDictionary<int, IDictionary<int, int>> xyIdx = new Dictionary<int, IDictionary<int, int>>();
            int maxIdx = 0;
            
            for (int i = 0; i < w; i++)
            {
                xyIdx.Add(i, new Dictionary<int, int>());
                for (int j = 0; j < h; j++)
                {
                    double x = xMin + i * xStep;
                    double y = yMin + j * yStep;
                    ComplexNumber z = new ComplexNumber(x, y);
                    IList<ComplexNumber> zIter = SqPolyIteration(z, c, maxIter, r);
                    int idx = zIter.Count - 1;
                    if (maxIdx < idx)
                    {
                        maxIdx = idx;
                    }
                    xyIdx[i].Add(j, idx);
                    
                }

                progress.Report(h);
            }
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    int idx = xyIdx[i][j];
                    double x = xMin + i * xStep;
                    double y = yMin + j * yStep;
                    ComplexNumber z = new ComplexNumber(x, y);
                    bmp.SetPixel(w - i - 1, j, ComplexHeatMap(idx, 0, maxIdx, z, r));
                }
            }
            stackPictures.Add(bmp);
            return bmp;
        }


        //Производим операцию над точкой, пока она не выйдет за радиус
        private static IList<ComplexNumber> SqPolyIteration(ComplexNumber z0, ComplexNumber c, int n, double r = 0)
        {
            IList<ComplexNumber> res = new List<ComplexNumber>();
            res.Add(z0);
            for (int i = 0; i < n; i++)
            {
                if (r > 0)
                {
                    if (res.Last().Mod > r)
                    {
                        break;
                    }
                }
                res.Add(ComplexNumber.Sum(ComplexNumber.Quad(res.Last()),c));
            }
            return res;
        }


        //Рассчет контрольного радиуса по выходу точек из Аттракциона
        private static double CalculateR(ComplexNumber c)
        {
            return (1 + Math.Sqrt(1 + 4 * c.Mod)) / 2;
        }


        //Присваем пикселю цвет
        public static Color ComplexHeatMap(decimal value, decimal min, decimal max, ComplexNumber z, double r)
        {
            decimal val = (value - min) / (max - min);
            //pen.Color = Color.FromArgb(255, (i * 9) % 255, 0, (i * 9) % 255);
            //return Color.FromArgb(
            //    255,
            //    Convert.ToByte(9 * value%255),
            //    Convert.ToByte(255 * (1-value)%255),
            //    Convert.ToByte(9 * value%255)
            //);
            return Color.FromArgb(
                255,
                Convert.ToByte(255 * val),
                Convert.ToByte(255 * (1 - val)),
                Convert.ToByte(255 * (z.Mod / r > 1 ? 1 : z.Mod / r))
            );
        }

        #endregion


        //Рисуем изображения, используя параметры из введенных значений
        public async void DrawImage()
        {
            FixErrorsUI(new List<TextBox> { glubina, HeightText, WidthText, zReBox, zImBox });

            progressBar1.Maximum = w * h;
            var progress = new Progress<int>(s => progressBar1.Value += s);
            pictureBox1.Image = await Task.Factory.StartNew(() => PlotJuliaSet(new ComplexNumber(zR, zIm), w, h, glubinaCount, progress), TaskCreationOptions.LongRunning);

            progressBar1.Value = 0;

            //Сохраняем изображение
            if (saveBmp.Checked || saveJpeg.Checked || saveJpg.Checked || savePng.Checked)
            {
                string name = $"{glubinaCount}_{zR.ToString()}Re_{zIm.ToString()}Im.{picturesFormat.ToString()}";
                pictureBox1.Image.Save($"Изображения\\{name}");
            }

        }


        //Вызов и настройка цикла
        private async void autoDrawImage(object sender, EventArgs e)
        {
            AutoInputZ aF = new AutoInputZ();//autoForm
            aF.ShowDialog();
            if (aF.DialogResult == DialogResult.OK)
            {
                double stepRe = 0, stepIm = 0;
                int iter = 1;

                if (FixErrorsUI(new List<TextBox> { aF.zReBox1, aF.zReBox2, aF.zImBox1, aF.zImBox2, aF.stepBoxIm, aF.stepBoxRe, glubina, HeightText, WidthText }))
                {
                    stepRe = Convert.ToDouble(aF.stepBoxRe.Text);
                    stepIm = Convert.ToDouble(aF.stepBoxIm.Text);
                    double zRe1 = Convert.ToDouble(aF.zReBox1.Text);
                    double zIm1 = Convert.ToDouble(aF.zImBox1.Text);
                    double zRe2 = Convert.ToDouble(aF.zReBox2.Text);
                    double zIm2 = Convert.ToDouble(aF.zImBox2.Text);


                    //Если не выбран формат сохранения изображения
                    if (!savePng.Checked && !saveJpg.Checked && !saveJpeg.Checked && !saveBmp.Checked)
                        picturesFormat = SavePicturesFormat.png;

                    progressBar1.Maximum = w * h;
                    var progress = new Progress<int>(s => progressBar1.Value += s);

                    //Показывает число полученных изображений
                    countPicturesLabel.Visible = true;
                    string labelTextCount = countPicturesLabel.Text;

                    //Запуск цикла
                    for (double i = Math.Min(zRe1, zRe2); i <= Math.Max(zRe1, zRe2); i += stepRe)
                    {
                        for (double j = Math.Min(zIm1, zIm2); j <= Math.Max(zIm1, zIm2); j += stepIm)
                        {
                            //Вызываем в новом потоке и ждем его исполнения
                            pictureBox1.Image = await Task.Factory.StartNew(() => PlotJuliaSet(new ComplexNumber(i, j), w, h, glubinaCount, progress), TaskCreationOptions.LongRunning);
                            progressBar1.Value = 0;

                            countPicturesLabel.Text = $"{labelTextCount} {iter}";

                            //Сохраняем изображение
                            string name = $"{iter}_{glubinaCount}_{i.ToString()}Re_{j.ToString()}Im.{picturesFormat.ToString()}";
                            pictureBox1.Image.Save($"Изображения\\{name}");

                            iter++;
                        }
                    }
                    countPicturesLabel.Text = labelTextCount;
                    countPicturesLabel.Visible = false;
                }
            }
        }


        //Создать гифку из изображений
        private void создатьАнимациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("Изображения\\Анимация"))
            {
                Directory.CreateDirectory("Изображения\\Анимация");
            }
            List<string> filesPath = Directory.GetFiles("Изображения").ToList();
            filesPath.Sort((x, y) =>
            {
                int ix, iy;
                x = x.Substring(12);
                y = y.Substring(12);
                string[] arX = x.Split('_');
                string[] arY = y.Split('_');

                return int.TryParse(arX[0], out ix) && int.TryParse(arY[0], out iy)
                      ? ix.CompareTo(iy) : string.Compare(x, y);
            });
            for (int i = 0; i < filesPath.Count; i++)
            {
                var img = (new Bitmap(Image.FromFile(filesPath[i]))).GetHbitmap();
                var src = Imaging.CreateBitmapSourceFromHBitmap(
                    img,
                    IntPtr.Zero,
                    Int32Rect.Empty,
                    BitmapSizeOptions.FromEmptyOptions());
                gif.Frames.Add(BitmapFrame.Create(src));
                DeleteObject(img);
            }
            SFD.Filter = "GIF | *.gif";

            if (SFD.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream($"{SFD.FileName}.gif", FileMode.Create);
                gif.Save(fs);
                fs.Close();
            }
            gif = new GifBitmapEncoder();
            GC.Collect();
        }


        //В этой функции предотвращаются возможные ошибки пользователей при вводе
        public bool FixErrorsUI(List<TextBox> textBoxList)
        {
            bool temp = true;//Нужны только для цикла (запускать или нет)
            double zRe1 = 0;//-------------------------------------------

            foreach(var i in textBoxList)
                if (i.Text.Contains(".")) i.Text = i.Text.Replace('.', ',');

            foreach (var i in textBoxList)
            {
                switch (i.Name)
                {
                    case "WidthText":
                        if (!int.TryParse(i.Text, out w))
                        {
                            w = 900;
                            WidthText.Text = "900";
                            MessageBox.Show("Ширина должна быть > 0\n\rИли вы ввели не целое число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show("Ширина = 900 (по умолчанию)", "Важно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;

                    case "HeightText":
                        if (!int.TryParse(i.Text, out h))
                        {
                            h = 800;
                            HeightText.Text = "800";
                            MessageBox.Show("Высота должна быть > 0\n\rИли вы ввели не целое число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show("Высота = 800 (по умолчанию)", "Важно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;

                    case "glubina":
                        if (!int.TryParse(i.Text, out glubinaCount))
                        {
                            glubinaCount = 200;
                            glubina.Text = "200";
                            MessageBox.Show("Глубина должна быть > 0\n\rИли вы ввели не целое число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show("Глубина = 200 (по умолчанию)", "Важно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                }
                if ((i.Name == "zReBox") &&
                    (!double.TryParse(i.Text, out zR) || !double.TryParse(zImBox.Text, out zIm)))
                {
                    zR = -0.2;
                    zIm = 0.75;
                    zReBox.Text = "-0,2";
                    zImBox.Text = "0,75";
                    MessageBox.Show("Значение действительной и мнимой части должны быть указаны!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Z = -0,2+0,75i (по умолчанию)", "Важно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if ((i.Name == "stepBoxRe" || i.Name == "stepBoxIm") && !double.TryParse(i.Text, out zRe1))
                {
                    i.Text = "1";
                    MessageBox.Show("Значение ШАГ должно быть > 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show($"Значение для шага {i.Name}  = 1 (по умолчанию)", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Если эту функцию вызвал "Цикл"
                if ((i.Name == "zReBox1" || i.Name == "zReBox2" ||
                   i.Name == "zImBox1" || i.Name == "zImBox2") &&
                   !double.TryParse(i.Text, out zRe1) && temp == true)
                {
                    temp = false;
                    MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return temp;
        }

        #region Кнопки меню и Старт

        //Выбор формата сохраняемого изображения
        private void SaveMenuSelectorClick(object sender, EventArgs e)
        {  
            bool SelectOrNot(ToolStripMenuItem tool)
            {
                if (!tool.Checked)
                {
                    saveBmp.Checked = false;
                    saveJpeg.Checked = false;
                    saveJpg.Checked = false;
                    savePng.Checked = false;
                    return false;
                }
                return true;
            }
            ToolStripMenuItem temp = sender as ToolStripMenuItem;
            switch (temp.Name)
            {
                case "saveBmp":
                    if (SelectOrNot(saveBmp))
                        saveBmp.Checked = false;
                    else
                    {
                        picturesFormat = SavePicturesFormat.bmp;
                        saveBmp.Checked = true;
                    }
                    break;
                case "saveJpeg":
                    if (SelectOrNot(saveJpeg))
                        saveJpeg.Checked = false;
                    else
                    {
                        picturesFormat = SavePicturesFormat.jpeg;
                        saveJpeg.Checked = true;
                    }
                    break;
                case "saveJpg":
                    if (SelectOrNot(saveJpg))
                        saveJpg.Checked = false;
                    else
                    {
                        picturesFormat = SavePicturesFormat.jpg;
                        saveJpg.Checked = true;
                    }
                    break;
                case "savePng":
                    if (SelectOrNot(savePng))
                        savePng.Checked = false;
                    else
                    {
                        picturesFormat = SavePicturesFormat.png;
                        savePng.Checked = true;
                    }
                    break;
            }  
        }

        //Кнопка начать
        private void StartClick(object sender, EventArgs e)
        {
            DrawImage();
        }

        //EnterDown -> Start
        private void EnterDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DrawImage();
            }
        }

        //Отмена действия
        private void returnStep_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = stackPictures.Pop();
        }

        //Сохранить
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SFD.Filter = "PNG | *.png|JPG | *.jpg|JPEG | *.jpeg|BMP | *.bmp";
                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(SFD.FileName);
                }
            }
        }

        //Помощь
        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpOrZ = true;
            HelperForm form2 = new HelperForm();
            form2.Show();
        }

        //Примеры чисел Z
        private void примерыZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpOrZ = false;
            HelperForm form2 = new HelperForm();
            form2.Show();
        }
        #endregion
    }
}
