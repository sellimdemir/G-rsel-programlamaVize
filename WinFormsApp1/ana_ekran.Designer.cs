namespace WinFormsApp1
{
    partial class ana_ekran
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
            button1 = new Button();
            button4 = new Button();
            button3 = new Button();
            kaydetbtn = new Button();
            yuklebtn = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(347, 36);
            button1.Name = "button1";
            button1.Size = new Size(122, 58);
            button1.TabIndex = 0;
            button1.Text = "üye ekleme";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(347, 158);
            button4.Name = "button4";
            button4.Size = new Size(122, 68);
            button4.TabIndex = 3;
            button4.Text = "kitaplar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(347, 309);
            button3.Name = "button3";
            button3.Size = new Size(122, 68);
            button3.TabIndex = 5;
            button3.Text = "emanet işlemleri";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // kaydetbtn
            // 
            kaydetbtn.Location = new Point(502, 43);
            kaydetbtn.Name = "kaydetbtn";
            kaydetbtn.Size = new Size(75, 45);
            kaydetbtn.TabIndex = 6;
            kaydetbtn.Text = "kaydet";
            kaydetbtn.UseVisualStyleBackColor = true;
            kaydetbtn.Click += kaydetbtn_Click;
            // 
            // yuklebtn
            // 
            yuklebtn.Location = new Point(583, 43);
            yuklebtn.Name = "yuklebtn";
            yuklebtn.Size = new Size(75, 45);
            yuklebtn.TabIndex = 6;
            yuklebtn.Text = "Yukle";
            yuklebtn.UseVisualStyleBackColor = true;
            yuklebtn.Click += yuklebtn_Click;
            // 
            // ana_ekran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(yuklebtn);
            Controls.Add(kaydetbtn);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button1);
            Name = "ana_ekran";
            Text = "ana_ekran";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button4;
        private Button button3;
        private Button kaydetbtn;
        private Button yuklebtn;
    }
}