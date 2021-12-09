namespace FractalJulia
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.glubina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.zReBox = new System.Windows.Forms.TextBox();
            this.zImBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HeightText = new System.Windows.Forms.TextBox();
            this.WidthText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.returnStep = new System.Windows.Forms.ToolStripMenuItem();
            this.autoInput = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAllPictures = new System.Windows.Forms.ToolStripMenuItem();
            this.savePng = new System.Windows.Forms.ToolStripMenuItem();
            this.saveJpg = new System.Windows.Forms.ToolStripMenuItem();
            this.saveJpeg = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBmp = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьАнимациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.примерыZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.countPicturesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Начать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.StartClick);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1273, 782);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(124, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Глубина:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1081, 31);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(191, 29);
            this.progressBar1.TabIndex = 5;
            // 
            // glubina
            // 
            this.glubina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.glubina.Location = new System.Drawing.Point(220, 30);
            this.glubina.MaxLength = 30;
            this.glubina.Name = "glubina";
            this.glubina.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.glubina.Size = new System.Drawing.Size(64, 29);
            this.glubina.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(290, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "zRe:";
            // 
            // zReBox
            // 
            this.zReBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zReBox.Location = new System.Drawing.Point(344, 30);
            this.zReBox.MaxLength = 30;
            this.zReBox.Name = "zReBox";
            this.zReBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.zReBox.Size = new System.Drawing.Size(104, 29);
            this.zReBox.TabIndex = 8;
            // 
            // zImBox
            // 
            this.zImBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zImBox.Location = new System.Drawing.Point(504, 30);
            this.zImBox.MaxLength = 30;
            this.zImBox.Name = "zImBox";
            this.zImBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.zImBox.Size = new System.Drawing.Size(104, 29);
            this.zImBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(454, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "zIm:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(614, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "i";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(752, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "x";
            // 
            // HeightText
            // 
            this.HeightText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeightText.Location = new System.Drawing.Point(778, 30);
            this.HeightText.MaxLength = 30;
            this.HeightText.Name = "HeightText";
            this.HeightText.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.HeightText.Size = new System.Drawing.Size(63, 29);
            this.HeightText.TabIndex = 13;
            // 
            // WidthText
            // 
            this.WidthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthText.Location = new System.Drawing.Point(683, 30);
            this.WidthText.MaxLength = 30;
            this.WidthText.Name = "WidthText";
            this.WidthText.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.WidthText.Size = new System.Drawing.Size(63, 29);
            this.WidthText.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(653, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "W";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(847, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "H";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.Edit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // Edit
            // 
            this.Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnStep,
            this.autoInput,
            this.SaveAllPictures,
            this.создатьАнимациюToolStripMenuItem,
            this.примерыZToolStripMenuItem});
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(79, 20);
            this.Edit.Text = "Настройки";
            // 
            // returnStep
            // 
            this.returnStep.Name = "returnStep";
            this.returnStep.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.returnStep.Size = new System.Drawing.Size(195, 22);
            this.returnStep.Text = "Отмена";
            this.returnStep.Click += new System.EventHandler(this.returnStep_Click);
            // 
            // autoInput
            // 
            this.autoInput.Name = "autoInput";
            this.autoInput.Size = new System.Drawing.Size(195, 22);
            this.autoInput.Text = "Цикл";
            this.autoInput.Click += new System.EventHandler(this.autoDrawImage);
            // 
            // SaveAllPictures
            // 
            this.SaveAllPictures.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savePng,
            this.saveJpg,
            this.saveJpeg,
            this.saveBmp});
            this.SaveAllPictures.Name = "SaveAllPictures";
            this.SaveAllPictures.Size = new System.Drawing.Size(195, 22);
            this.SaveAllPictures.Text = "Сохранять множества";
            // 
            // savePng
            // 
            this.savePng.Name = "savePng";
            this.savePng.Size = new System.Drawing.Size(99, 22);
            this.savePng.Text = "PNG";
            this.savePng.Click += new System.EventHandler(this.SaveMenuSelectorClick);
            // 
            // saveJpg
            // 
            this.saveJpg.Name = "saveJpg";
            this.saveJpg.Size = new System.Drawing.Size(99, 22);
            this.saveJpg.Text = "JPG";
            this.saveJpg.Click += new System.EventHandler(this.SaveMenuSelectorClick);
            // 
            // saveJpeg
            // 
            this.saveJpeg.Name = "saveJpeg";
            this.saveJpeg.Size = new System.Drawing.Size(99, 22);
            this.saveJpeg.Text = "JPEG";
            this.saveJpeg.Click += new System.EventHandler(this.SaveMenuSelectorClick);
            // 
            // saveBmp
            // 
            this.saveBmp.Name = "saveBmp";
            this.saveBmp.Size = new System.Drawing.Size(99, 22);
            this.saveBmp.Text = "BMP";
            this.saveBmp.Click += new System.EventHandler(this.SaveMenuSelectorClick);
            // 
            // создатьАнимациюToolStripMenuItem
            // 
            this.создатьАнимациюToolStripMenuItem.Name = "создатьАнимациюToolStripMenuItem";
            this.создатьАнимациюToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.создатьАнимациюToolStripMenuItem.Text = "Создать анимацию";
            this.создатьАнимациюToolStripMenuItem.Click += new System.EventHandler(this.создатьАнимациюToolStripMenuItem_Click);
            // 
            // примерыZToolStripMenuItem
            // 
            this.примерыZToolStripMenuItem.Name = "примерыZToolStripMenuItem";
            this.примерыZToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.примерыZToolStripMenuItem.Text = "Примеры Z";
            this.примерыZToolStripMenuItem.Click += new System.EventHandler(this.примерыZToolStripMenuItem_Click);
            // 
            // countPicturesLabel
            // 
            this.countPicturesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countPicturesLabel.Location = new System.Drawing.Point(877, 32);
            this.countPicturesLabel.Name = "countPicturesLabel";
            this.countPicturesLabel.Size = new System.Drawing.Size(198, 28);
            this.countPicturesLabel.TabIndex = 18;
            this.countPicturesLabel.Text = "Нарисовано:";
            this.countPicturesLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 861);
            this.Controls.Add(this.countPicturesLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HeightText);
            this.Controls.Add(this.WidthText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.zImBox);
            this.Controls.Add(this.zReBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.glubina);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JuliaFractal";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox glubina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox zReBox;
        private System.Windows.Forms.TextBox zImBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox HeightText;
        private System.Windows.Forms.TextBox WidthText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem примерыZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAllPictures;
        private System.Windows.Forms.ToolStripMenuItem returnStep;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.ToolStripMenuItem savePng;
        private System.Windows.Forms.ToolStripMenuItem saveJpg;
        private System.Windows.Forms.ToolStripMenuItem saveJpeg;
        private System.Windows.Forms.ToolStripMenuItem saveBmp;
        private System.Windows.Forms.ToolStripMenuItem autoInput;
        private System.Windows.Forms.Label countPicturesLabel;
        private System.Windows.Forms.ToolStripMenuItem создатьАнимациюToolStripMenuItem;
    }
}

