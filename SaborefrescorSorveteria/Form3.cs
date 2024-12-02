using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace SaborefrescorSorveteria
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string senha1 = txbsenha1.Text;
            string senha2 = txbsenha2.Text;

            if (senha1 == senha2)
            {
                string nome = txbNome.Text;
                string sobrenome = txbSobrenome.Text;
                string cpf = txbcpf.Text;
                string email = txbemail.Text;
                string senha = txbsenha1.Text;
                string confirmar = txbsenha2.Text;
                int cep =int.Parse( txbcep.Text);
                string estado = cbestado.Text;
                string bairro = txbbairro.Text;
                string rua = txbrua.Text;  
                int casa = int.Parse(txbcasa.Text);
                Clientes c1 = new Clientes(nome,cpf, email, senha, estado, cep, bairro, rua, casa);
                ClientesDAO clientesDAO = new ClientesDAO();
                clientesDAO.Insert(c1);

                MessageBox.Show(txbNome.Text + " Sua conta foi criada com sucesso!");

                this.Visible = false;
                Form20 tela20 = new Form20();
                tela20.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show(" Erro : As senhas não se coicidem!");


            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txbNome.Text +
                 "\n" + txbcpf.Text +
                 "\n" + txbemail.Text +
                 "\n" + txbsenha1.Text +
                 "\n" + txbsenha2.Text +
                 "\n" + cbestado.Text +
                 "\n" + txbcep.Text +
                 "\n" + txbbairro.Text +
                 "\n" + txbrua.Text +
                 "\n" + txbcasa.Text);

        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
