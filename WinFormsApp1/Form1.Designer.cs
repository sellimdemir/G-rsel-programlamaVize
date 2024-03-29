namespace WinFormsApp1
{
    partial class KitapEkle
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 37);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "kitap ismi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 90);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "yazarın adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 144);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 2;
            label3.Text = "sayfa sayısı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 192);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.InactiveCaptionText;
            label5.Location = new Point(27, 255);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 4;
            label5.Text = "yayın evi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 200);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 5;
            label6.Text = "seri numarası";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(114, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(115, 192);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(220, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(114, 136);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(221, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(115, 247);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(220, 23);
            textBox5.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 310);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 11;
            label7.Text = "kaçıncı baskı";
            label7.Click += label7_Click;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Window;
            textBox6.Location = new Point(115, 302);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(220, 23);
            textBox6.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(312, 383);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "güncelle";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(166, 383);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(459, 383);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 15;
            button3.Text = "sil";
            button3.UseVisualStyleBackColor = true;
            // 
            // KitapEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "KitapEkle";
            Text = "Kitap Ekleme";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
