namespace SaborefrescorSorveteria
{
    partial class Form8
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            checkedListBox1 = new CheckedListBox();
            label2 = new Label();
            checkedListBox2 = new CheckedListBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 37);
            label1.TabIndex = 0;
            label1.Text = "Sabores";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sorveteriaa2;
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.sorveteriaa;
            pictureBox2.Location = new Point(1, 330);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(800, 119);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Baunilha.......................................................................................", "Morango........................................................................................", "Flocos.............................................................................................", "Napolitano.....................................................................................", "Creme.................................................................................................", "Chocolate.......................................................................................", "Coco.................................................................................................", "Maracujá..............................................................................................", "Pistache.................................................................................................", "Kinder ovo............................................................................................", "Ninho trufado........................................................................................", "Frutas vermelhas.....................................................................................", "Limão suíço...................................................................................................", "Céu azul......................................................................................................", "Chiclete.......................................................................................................", "Caramelo......................................................................................................", "Abacaxi..............................................................................................................", "Leite condensado........................................................................................." });
            checkedListBox1.Location = new Point(47, 49);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(325, 328);
            checkedListBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(404, 19);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 4;
            label2.Text = "Tipo";
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Casquinha...........................................................................", "Marmita térmica...............................................................", "Copo com camadas...........................................................", "Copo de 300ml.....................................................................", "Copo de 500ml........................................................................" });
            checkedListBox2.Location = new Point(404, 72);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(230, 94);
            checkedListBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(459, 252);
            label3.Name = "label3";
            label3.Size = new Size(210, 30);
            label3.TabIndex = 6;
            label3.Text = "R$ 4,00 a cada 100g";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._20616011_livre_icone_milkshake_desenho_animado_ilustracao_gratis_vetor;
            pictureBox3.Location = new Point(423, 224);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(285, 85);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(616, 400);
            button1.Name = "button1";
            button1.Size = new Size(141, 38);
            button1.TabIndex = 8;
            button1.Text = "Finlizar compra";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 192);
            button2.Location = new Point(47, 400);
            button2.Name = "button2";
            button2.Size = new Size(141, 38);
            button2.TabIndex = 9;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 248, 244);
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(checkedListBox2);
            Controls.Add(label2);
            Controls.Add(checkedListBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Name = "Form8";
            Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private CheckedListBox checkedListBox1;
        private Label label2;
        private CheckedListBox checkedListBox2;
        private Label label3;
        private PictureBox pictureBox3;
        private Button button1;
        private Button button2;
    }
}