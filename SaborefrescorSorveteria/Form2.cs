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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txbemail.Text;
            string senha = mtbsenha.Text;

            if (email == "nicolybatista@gmail.com" && senha == "nicoly26")
            {
                MessageBox.Show("Login efetuado com sucesso!");

                this.Visible = false;
                Form4 tela4 = new Form4();
                tela4.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos.");

                this.Visible = false;
                Form2 tela2 = new Form2();
                tela2.ShowDialog();
                this.Visible = true;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
