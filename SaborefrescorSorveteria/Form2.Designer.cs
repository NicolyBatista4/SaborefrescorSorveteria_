namespace SaborefrescorSorveteria
{
    partial class Form2
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
            btnEntrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txbemail = new TextBox();
            mtbsenha = new TextBox();
            label4 = new Label();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sorveteriaa2;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.sorveteriaa;
            pictureBox2.Location = new Point(-1, 319);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(800, 131);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(630, 329);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(111, 46);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("ScriptS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 87);
            label1.Name = "label1";
            label1.Size = new Size(75, 34);
            label1.TabIndex = 3;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 207);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 4;
            label2.Text = "E-mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(209, 258);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 5;
            label3.Text = "Senha:";
            // 
            // txbemail
            // 
            txbemail.Location = new Point(269, 199);
            txbemail.Name = "txbemail";
            txbemail.Size = new Size(242, 23);
            txbemail.TabIndex = 6;
            txbemail.Text = "  ";
            // 
            // mtbsenha
            // 
            mtbsenha.Location = new Point(269, 250);
            mtbsenha.Name = "mtbsenha";
            mtbsenha.PasswordChar = '*';
            mtbsenha.Size = new Size(242, 23);
            mtbsenha.TabIndex = 7;
            mtbsenha.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(277, 101);
            label4.Name = "label4";
            label4.Size = new Size(234, 42);
            label4.TabIndex = 8;
            label4.Text = "Sabor e Frescor";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(63, 329);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(111, 46);
            btnVoltar.TabIndex = 9;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 248, 244);
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(label4);
            Controls.Add(mtbsenha);
            Controls.Add(txbemail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEntrar);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnEntrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txbemail;
        private TextBox mtbsenha;
        private Label label4;
        private Button btnVoltar;
    }
}