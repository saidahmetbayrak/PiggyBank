namespace PiggyBank
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe Print", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.ForeColor = System.Drawing.Color.Coral;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(226, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(348, 73);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(15, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Para Seç:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.SeaShell;
            this.button1.Location = new System.Drawing.Point(26, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(548, 69);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kumbaraya At";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.SeaShell;
            this.button2.Location = new System.Drawing.Point(26, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(548, 69);
            this.button2.TabIndex = 4;
            this.button2.Text = "Kumbaraya Salla";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.Font = new System.Drawing.Font("Segoe Print", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.SeaShell;
            this.button3.Location = new System.Drawing.Point(26, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(548, 69);
            this.button3.TabIndex = 5;
            this.button3.Text = "Kumbaraya Kır";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.OrangeRed;
            this.button4.Font = new System.Drawing.Font("Segoe Print", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.SeaShell;
            this.button4.Location = new System.Drawing.Point(26, 500);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(548, 69);
            this.button4.TabIndex = 6;
            this.button4.Text = "Kumbaraya Yapıştır";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.SeaShell;
            this.label2.Location = new System.Drawing.Point(621, 585);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 65);
            this.label2.TabIndex = 7;
            this.label2.Text = "Toplam Para:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.SeaShell;
            this.label3.Location = new System.Drawing.Point(894, 585);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 65);
            this.label3.TabIndex = 8;
            this.label3.Text = "0 TL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PiggyBank.Properties.Resources.kumbara;
            this.pictureBox1.Location = new System.Drawing.Point(632, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(545, 487);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.SeaShell;
            this.label4.Location = new System.Drawing.Point(940, 674);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 65);
            this.label4.TabIndex = 10;
            this.label4.Text = "0 ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.SeaShell;
            this.label5.Location = new System.Drawing.Point(621, 674);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 65);
            this.label5.TabIndex = 9;
            this.label5.Text = "Toplam Hacim:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1229, 976);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

