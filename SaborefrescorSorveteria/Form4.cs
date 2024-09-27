using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaborefrescorSorveteria
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            Form4 tela4 = new Form4();
            tela4.ShowDialog();
            this.Visible = true;
        }

        private void proToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            Form5 tela5 = new Form5();
            tela5.ShowDialog();
            this.Visible = true;
        }
    }
}
