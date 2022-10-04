using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lectorpdf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            axAcroPDF1.src = openFileDialog1.FileName;
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        private void cerarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
