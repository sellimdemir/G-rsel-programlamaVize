namespace WinFormsApp1
{
    partial class UyeEkle
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox6 = new TextBox();
            butonEkleUye = new Button();
            butonGuncelleUye = new Button();
            butonSilUye = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(193, 37);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(193, 335);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(277, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(193, 443);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(277, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(193, 231);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(277, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(193, 132);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(277, 27);
            textBox5.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 48);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 5;
            label1.Text = "üye adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 564);
            label2.Name = "label2";
            label2.Size = new Size(21, 20);
            label2.TabIndex = 6;
            label2.Text = "tc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 241);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 7;
            label3.Text = "doğum tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 345);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 8;
            label4.Text = "cinsiyeti";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 143);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 9;
            label5.Text = "üye soyadı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 453);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 10;
            label6.Text = "telefon numarası";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(193, 553);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(277, 27);
            textBox6.TabIndex = 11;
            // 
            // butonEkleUye
            // 
            butonEkleUye.Location = new Point(587, 76);
            butonEkleUye.Margin = new Padding(3, 4, 3, 4);
            butonEkleUye.Name = "butonEkleUye";
            butonEkleUye.Size = new Size(86, 31);
            butonEkleUye.TabIndex = 12;
            butonEkleUye.Text = "ekle";
            butonEkleUye.UseVisualStyleBackColor = true;
            butonEkleUye.Click += butonEkleUye_Click;
            // 
            // butonGuncelleUye
            // 
            butonGuncelleUye.Location = new Point(587, 161);
            butonGuncelleUye.Margin = new Padding(3, 4, 3, 4);
            butonGuncelleUye.Name = "butonGuncelleUye";
            butonGuncelleUye.Size = new Size(86, 31);
            butonGuncelleUye.TabIndex = 12;
            butonGuncelleUye.Text = "guncelle";
            butonGuncelleUye.UseVisualStyleBackColor = true;
            butonGuncelleUye.Click += butonGuncelleUye_Click;
            // 
            // butonSilUye
            // 
            butonSilUye.Location = new Point(587, 236);
            butonSilUye.Margin = new Padding(3, 4, 3, 4);
            butonSilUye.Name = "butonSilUye";
            butonSilUye.Size = new Size(86, 31);
            butonSilUye.TabIndex = 12;
            butonSilUye.Text = "sil";
            butonSilUye.UseVisualStyleBackColor = true;
            butonSilUye.Click += butonSilUye_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(706, 14);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(571, 570);
            dataGridView1.TabIndex = 13;
            // 
            // UyeEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1306, 633);
            Controls.Add(dataGridView1);
            Controls.Add(butonSilUye);
            Controls.Add(butonGuncelleUye);
            Controls.Add(butonEkleUye);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UyeEkle";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox6;
        private Button butonEkleUye;
        private Button butonGuncelleUye;
        private Button butonSilUye;
        private DataGridView dataGridView1;
    }
}