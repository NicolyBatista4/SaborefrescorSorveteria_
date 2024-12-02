namespace SaborefrescorSorveteria
{
    partial class Form20
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txbTelephone = new TextBox();
            txbBrokerCode = new TextBox();
            txbCodeArea = new TextBox();
            txbBroker = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listView1 = new ListView();
            ID = new ColumnHeader();
            ProdutoName = new ColumnHeader();
            Categoria = new ColumnHeader();
            Preço = new ColumnHeader();
            button1 = new Button();
            btnUpdate = new Button();
            button3 = new Button();
            btnDelete = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txbTelephone);
            groupBox1.Controls.Add(txbBrokerCode);
            groupBox1.Controls.Add(txbCodeArea);
            groupBox1.Controls.Add(txbBroker);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(44, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(581, 199);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txbTelephone
            // 
            txbTelephone.Location = new Point(336, 143);
            txbTelephone.Name = "txbTelephone";
            txbTelephone.Size = new Size(223, 23);
            txbTelephone.TabIndex = 10;
            // 
            // txbBrokerCode
            // 
            txbBrokerCode.Location = new Point(270, 32);
            txbBrokerCode.Name = "txbBrokerCode";
            txbBrokerCode.Size = new Size(289, 23);
            txbBrokerCode.TabIndex = 9;
            // 
            // txbCodeArea
            // 
            txbCodeArea.Location = new Point(16, 143);
            txbCodeArea.Name = "txbCodeArea";
            txbCodeArea.Size = new Size(282, 23);
            txbCodeArea.TabIndex = 8;
            // 
            // txbBroker
            // 
            txbBroker.Location = new Point(12, 32);
            txbBroker.Name = "txbBroker";
            txbBroker.Size = new Size(75, 23);
            txbBroker.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(336, 111);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 6;
            label4.Text = "Preço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 0);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 111);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 6;
            label2.Text = "Categoria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 6;
            label1.Text = "ID do produto";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ID, ProdutoName, Categoria, Preço });
            listView1.Location = new Point(44, 239);
            listView1.Name = "listView1";
            listView1.Size = new Size(721, 199);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // ID
            // 
            ID.Text = "ID";
            // 
            // ProdutoName
            // 
            ProdutoName.Text = "ProdutoName";
            // 
            // Categoria
            // 
            Categoria.Text = "Categoria";
            // 
            // Preço
            // 
            Preço.Text = "Preço";
            // 
            // button1
            // 
            button1.Location = new Point(669, 34);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 2;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(669, 82);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 32);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Editar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // button3
            // 
            button3.Location = new Point(669, 133);
            button3.Name = "button3";
            button3.Size = new Size(75, 31);
            button3.TabIndex = 4;
            button3.Text = "Inserir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(669, 184);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 37);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Excluir";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form20
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(button3);
            Controls.Add(btnUpdate);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(groupBox1);
            Name = "Form20";
            Text = "Form20";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listView1;
        private Button button1;
        private Button btnUpdate;
        private Button button3;
        private Button btnDelete;
        private ColumnHeader ID;
        private ColumnHeader ProdutoName;
        private ColumnHeader Categoria;
        private ColumnHeader Preço;
        private Label label1;
        private TextBox txbCodeArea;
        private TextBox txbBroker;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txbTelephone;
        private TextBox txbBrokerCode;
    }
}