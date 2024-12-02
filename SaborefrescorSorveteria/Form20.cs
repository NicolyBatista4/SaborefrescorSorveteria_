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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txbBroker.Clear();
            txbBrokerCode.Clear();

            txbCodeArea.Clear();
            txbTelephone.Clear();

            btnDelete.Visible = false;
            btnUpdate.Visible = false;
        }

        private bool ValidateFields()
        {
            if (txbBrokerCode.Text.Length == 0 || txbPassword.Text.Length == 0)
            {
                MessageBox.Show("Os campos CRECI e Senha são obrigatórios", "ATENÇÃO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void UpdateListView()
        {
            ltvBroker.Items.Clear();

            BrokerDAO brokerDAO = new BrokerDAO();
            List<Broker> brokers = brokerDAO.ListAllBrokers();

            //This code part access all brokers received from database and iterate by them.
            foreach (Broker broker in brokers)
            {
                //Creating a fully line of listview with items from database.
                ListViewItem item = new ListViewItem(broker.Id.ToString());
                item.SubItems.Add(broker.BrokerName);
                item.SubItems.Add(broker.BrokerCode);

                item.SubItems.Add(broker.CodeArea.ToString());
                item.SubItems.Add(broker.Telephone);

                //Adding the fully line to the listview.
                ltvBroker.Items.Add(item);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                try
                {
                    //Capture inputed text from fields.
                    new BrokerDAO().Update(new Broker(
                        txbBroker.Text, txbBrokerCode.Text, int.Parse(txbCodeArea.Text),
                        txbTelephone.Text));
                    MessageBox.Show("Corretor atualizado!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateListView();
                ClearFields();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index;
            try
            {
                index = ltvBroker.FocusedItem.Index;
                Id = int.Parse(ltvBroker.Items[index].SubItems[0].Text);
                txbBroker.Text = ltvBroker.Items[index].SubItems[1].Text;
                txbBrokerCode.Text = ltvBroker.Items[index].SubItems[2].Text;

                txbCodeArea.Text = ltvBroker.Items[index].SubItems[4].Text;
                txbTelephone.Text = ltvBroker.Items[index].SubItems[5].Text;


                btnDelete.Visible = true;
                btnUpdate.Visible = true;

            }

            catch (Exception)
            {
                MessageBox.Show("Você precisa selecionar uma linha", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
}
