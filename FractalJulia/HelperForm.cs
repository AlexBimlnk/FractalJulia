using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalJulia
{
    public partial class HelperForm : Form
    {
        public HelperForm()
        {
            InitializeComponent();
            if (Form1.HelpOrZ)
                richTextBox1.Text = Properties.Resources.Help;
            else
                richTextBox1.Text = Properties.Resources.NumbersZ;
        }
    }
}
