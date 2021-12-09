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
    public partial class AutoInputZ : Form
    {
        public AutoInputZ()
        {
            InitializeComponent();
        }

        private void EnterDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
