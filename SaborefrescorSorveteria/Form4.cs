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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            Form10 tela10 = new Form10();
            tela10.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            Form8 tela8 = new Form8();
            tela8.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            Form9 tela9 = new Form9();
            tela9.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            Form13 tela13 = new Form13();
            tela13.ShowDialog();
            this.Visible = true;
        }

        private void sobreAMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            Form14 tela14 = new Form14();
            tela14.ShowDialog();
            this.Visible = true;
        }
    }
}
