namespace SaborefrescorSorveteria
{
    partial class Form5
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
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sorveteriaa2;
            pictureBox1.Location = new Point(-1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(802, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(-1, 10);
            label1.Name = "label1";
            label1.Size = new Size(207, 37);
            label1.TabIndex = 2;
            label1.Text = "P R O D U T O S";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.casquinha;
            pictureBox2.Location = new Point(-1, 50);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(802, 194);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.picoleer;
            pictureBox3.Location = new Point(-1, 237);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(802, 283);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 224, 192);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(656, 455);
            button1.Name = "button1";
            button1.Size = new Size(99, 34);
            button1.TabIndex = 5;
            button1.Text = "mais";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PaleTurquoise;
            label2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(678, 51);
            label2.Name = "label2";
            label2.Size = new Size(123, 37);
            label2.TabIndex = 6;
            label2.Text = "Sorvetes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 224, 192);
            label3.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(692, 247);
            label3.Name = "label3";
            label3.Size = new Size(109, 40);
            label3.TabIndex = 7;
            label3.Text = "Picolés";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 224, 192);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(24, 470);
            button2.Name = "button2";
            button2.Size = new Size(99, 34);
            button2.TabIndex = 8;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 248, 244);
            ClientSize = new Size(800, 516);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            ForeColor = Color.FromArgb(255, 248, 244);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button1;
        private Label label2;
        private Label label3;
        private Button button2;
    }
}