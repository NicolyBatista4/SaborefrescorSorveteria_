namespace SaborefrescorSorveteria
{
    partial class Form13
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
            checkedListBox1 = new CheckedListBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sorveteriaa2;
            pictureBox1.Location = new Point(-3, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.sorveteriaa;
            pictureBox2.Location = new Point(-3, 328);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(809, 124);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 9);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 2;
            label1.Text = "Sabores";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Limão....................................................................................................", "Limão suíço...............................................................................................................", "Milho verde..................................................................................................................", "Morango.......................................................................................................................", "Morango com chocolate..................................................................................................", "Chocolate..............................................................................................................................", "Prestigio..................................................................................................................................", "Oreo........................................................................................................................................", "Coco........................................................................................................................................", "Coco queimado.........................................................................................................................", "Ovomaltine.................................................................................................................................", "Groselia...................................................................................................................................", "Leite condensado..............................................................................................................", "Uva..................................................................................................................................................", "Açaí................................................................................................................................................", "Brigadeiro......................................................................................................................................", "Mousse de maracujá......................................................................................................................", "Chocolate branco......................................................................................................................" });
            checkedListBox1.Location = new Point(51, 37);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(358, 328);
            checkedListBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(528, 97);
            label2.Name = "label2";
            label2.Size = new Size(92, 32);
            label2.TabIndex = 4;
            label2.Text = "Valores";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._20616011_livre_icone_milkshake_desenho_animado_ilustracao_gratis_vetor;
            pictureBox3.Location = new Point(508, 135);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(199, 88);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(528, 148);
            label3.Name = "label3";
            label3.Size = new Size(127, 21);
            label3.TabIndex = 6;
            label3.Text = "1 picolé R$ 3,00 ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(528, 187);
            label4.Name = "label4";
            label4.Size = new Size(133, 21);
            label4.TabIndex = 7;
            label4.Text = "2 picolés R$ 5,00";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.Location = new Point(633, 382);
            button1.Name = "button1";
            button1.Size = new Size(128, 41);
            button1.TabIndex = 8;
            button1.Text = "Finalizar compra";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 192);
            button2.Location = new Point(12, 382);
            button2.Name = "button2";
            button2.Size = new Size(128, 41);
            button2.TabIndex = 9;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 248, 244);
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form13";
            Text = "Form13";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private CheckedListBox checkedListBox1;
        private Label label2;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}