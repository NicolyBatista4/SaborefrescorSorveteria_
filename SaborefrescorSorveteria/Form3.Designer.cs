namespace SaborefrescorSorveteria
{
    partial class Form3
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            txbsenha2 = new TextBox();
            txbsenha1 = new TextBox();
            txbemail = new TextBox();
            txbcpf = new TextBox();
            txbSobrenome = new TextBox();
            txbNome = new TextBox();
            label10 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            txbcasa = new TextBox();
            txbrua = new TextBox();
            txbbairro = new TextBox();
            txbcep = new TextBox();
            cbestado = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            label2 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sorveteriaa2;
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(802, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.sorveteriaa;
            pictureBox2.Location = new Point(0, 326);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(802, 126);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 248, 244);
            label1.Font = new Font("ScriptS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 88);
            label1.Name = "label1";
            label1.Size = new Size(109, 34);
            label1.TabIndex = 2;
            label1.Text = "Cadastro";
            // 
            // button1
            // 
            button1.Location = new Point(645, 397);
            button1.Name = "button1";
            button1.Size = new Size(103, 41);
            button1.TabIndex = 3;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txbsenha2);
            panel1.Controls.Add(txbsenha1);
            panel1.Controls.Add(txbemail);
            panel1.Controls.Add(txbcpf);
            panel1.Controls.Add(txbSobrenome);
            panel1.Controls.Add(txbNome);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(75, 142);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 236);
            panel1.TabIndex = 4;
            // 
            // txbsenha2
            // 
            txbsenha2.Location = new Point(121, 198);
            txbsenha2.Name = "txbsenha2";
            txbsenha2.Size = new Size(167, 23);
            txbsenha2.TabIndex = 11;
            // 
            // txbsenha1
            // 
            txbsenha1.Location = new Point(67, 163);
            txbsenha1.Name = "txbsenha1";
            txbsenha1.Size = new Size(221, 23);
            txbsenha1.TabIndex = 10;
            // 
            // txbemail
            // 
            txbemail.Location = new Point(67, 118);
            txbemail.Name = "txbemail";
            txbemail.Size = new Size(221, 23);
            txbemail.TabIndex = 9;
            // 
            // txbcpf
            // 
            txbcpf.Location = new Point(54, 78);
            txbcpf.Name = "txbcpf";
            txbcpf.Size = new Size(234, 23);
            txbcpf.TabIndex = 8;
            txbcpf.TextChanged += textBox3_TextChanged;
            // 
            // txbSobrenome
            // 
            txbSobrenome.Location = new Point(94, 41);
            txbSobrenome.Name = "txbSobrenome";
            txbSobrenome.Size = new Size(194, 23);
            txbSobrenome.TabIndex = 7;
            // 
            // txbNome
            // 
            txbNome.Location = new Point(65, 10);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(223, 23);
            txbNome.TabIndex = 6;
            txbNome.TextChanged += txbNome_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 206);
            label10.Name = "label10";
            label10.Size = new Size(98, 15);
            label10.TabIndex = 5;
            label10.Text = "Confirmar senha:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 166);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 4;
            label7.Text = "Senha:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 126);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 3;
            label6.Text = "E-mail:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 86);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 2;
            label5.Text = "CPF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 49);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 1;
            label4.Text = "Sobrenome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 18);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 0;
            label3.Text = "Nome:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbcasa);
            panel2.Controls.Add(txbrua);
            panel2.Controls.Add(txbbairro);
            panel2.Controls.Add(txbcep);
            panel2.Controls.Add(cbestado);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(416, 142);
            panel2.Name = "panel2";
            panel2.Size = new Size(322, 236);
            panel2.TabIndex = 5;
            // 
            // txbcasa
            // 
            txbcasa.Location = new Point(122, 181);
            txbcasa.Name = "txbcasa";
            txbcasa.Size = new Size(180, 23);
            txbcasa.TabIndex = 10;
            // 
            // txbrua
            // 
            txbrua.Location = new Point(56, 137);
            txbrua.Name = "txbrua";
            txbrua.Size = new Size(246, 23);
            txbrua.TabIndex = 9;
            // 
            // txbbairro
            // 
            txbbairro.Location = new Point(67, 99);
            txbbairro.Name = "txbbairro";
            txbbairro.Size = new Size(235, 23);
            txbbairro.TabIndex = 8;
            // 
            // txbcep
            // 
            txbcep.Location = new Point(57, 21);
            txbcep.Name = "txbcep";
            txbcep.Size = new Size(245, 23);
            txbcep.TabIndex = 7;
            // 
            // cbestado
            // 
            cbestado.FormattingEnabled = true;
            cbestado.Items.AddRange(new object[] { "Acre (AC)", "Alagoas (AL)", "Amapá (AP)", "Amazonas (AM)", "Bahia (BA)", "Ceará (CE)", "Distrito Federal (DF)", "Espírito Santo (ES)", "Goiás (GO)", "Maranhão (MA)", "Mato Grosso (MT)", "Mato Grosso do Sul (MS)", "Minas Gerais (MG)", "Pará (PA)", "Paraíba (PB)", "Paraná (PR)", "Pernambuco (PE)", "Piauí (PI)", "Rio de Janeiro (RJ)", "Rio Grande do Norte (RN)", "Rio Grande do Sul (RS)", "Rondônia (RO)", "Roraima (RR)", "Santa Catarina (SC)", "São Paulo (SP)", "Sergipe (SE)", "Tocantins (TO)" });
            cbestado.Location = new Point(71, 60);
            cbestado.Name = "cbestado";
            cbestado.Size = new Size(231, 23);
            cbestado.TabIndex = 6;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(20, 184);
            label13.Name = "label13";
            label13.Size = new Size(96, 15);
            label13.TabIndex = 4;
            label13.Text = "Número da casa:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(20, 140);
            label12.Name = "label12";
            label12.Size = new Size(30, 15);
            label12.TabIndex = 3;
            label12.Text = "Rua:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 102);
            label11.Name = "label11";
            label11.Size = new Size(41, 15);
            label11.TabIndex = 2;
            label11.Text = "Bairro:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 63);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 1;
            label9.Text = "Estado:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 29);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 0;
            label8.Text = "CEP:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(289, 88);
            label2.Name = "label2";
            label2.Size = new Size(229, 42);
            label2.TabIndex = 0;
            label2.Text = "Sabor e frescor";
            // 
            // button2
            // 
            button2.Location = new Point(519, 397);
            button2.Name = "button2";
            button2.Size = new Size(103, 41);
            button2.TabIndex = 6;
            button2.Text = "Mostrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 248, 244);
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label10;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label9;
        private Label label8;
        private TextBox txbsenha2;
        private TextBox txbsenha1;
        private TextBox txbemail;
        private TextBox txbcpf;
        private TextBox txbSobrenome;
        private TextBox txbNome;
        private ComboBox cbestado;
        private TextBox txbcasa;
        private TextBox txbrua;
        private TextBox txbbairro;
        private TextBox txbcep;
        private Button button2;
    }
}