namespace serbestdusme
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1yukseklik = new System.Windows.Forms.TextBox();
            this.textBox2kutle = new System.Windows.Forms.TextBox();
            this.textBox3yercekimikuvveti = new System.Windows.Forms.TextBox();
            this.button1hesapla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "YÜKSEKLİK(h) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "KÜTLE(m) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "YER ÇEKİMİ KUVVETİ(g) :";
            // 
            // textBox1yukseklik
            // 
            this.textBox1yukseklik.Location = new System.Drawing.Point(270, 81);
            this.textBox1yukseklik.Name = "textBox1yukseklik";
            this.textBox1yukseklik.Size = new System.Drawing.Size(170, 22);
            this.textBox1yukseklik.TabIndex = 1;
            this.textBox1yukseklik.Text = "metre cinsinden giriniz :";
            // 
            // textBox2kutle
            // 
            this.textBox2kutle.Location = new System.Drawing.Point(270, 120);
            this.textBox2kutle.Name = "textBox2kutle";
            this.textBox2kutle.Size = new System.Drawing.Size(170, 22);
            this.textBox2kutle.TabIndex = 2;
            this.textBox2kutle.Text = "(gr) cinsinden giriniz :";
            // 
            // textBox3yercekimikuvveti
            // 
            this.textBox3yercekimikuvveti.Enabled = false;
            this.textBox3yercekimikuvveti.Location = new System.Drawing.Point(270, 164);
            this.textBox3yercekimikuvveti.Name = "textBox3yercekimikuvveti";
            this.textBox3yercekimikuvveti.Size = new System.Drawing.Size(170, 22);
            this.textBox3yercekimikuvveti.TabIndex = 1315;
            this.textBox3yercekimikuvveti.Text = "(g=10) alındı.";
            // 
            // button1hesapla
            // 
            this.button1hesapla.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1hesapla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1hesapla.Location = new System.Drawing.Point(270, 219);
            this.button1hesapla.Name = "button1hesapla";
            this.button1hesapla.Size = new System.Drawing.Size(170, 38);
            this.button1hesapla.TabIndex = 3;
            this.button1hesapla.Text = "HESAPLA";
            this.button1hesapla.UseVisualStyleBackColor = false;
            this.button1hesapla.Click += new System.EventHandler(this.button1hesapla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(154, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "POTANSİYEL ENERJİ  :";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(458, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(258, 228);
            this.listBox1.TabIndex = 300;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1hesapla);
            this.Controls.Add(this.textBox3yercekimikuvveti);
            this.Controls.Add(this.textBox2kutle);
            this.Controls.Add(this.textBox1yukseklik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1yukseklik;
        private System.Windows.Forms.TextBox textBox2kutle;
        private System.Windows.Forms.TextBox textBox3yercekimikuvveti;
        private System.Windows.Forms.Button button1hesapla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
    }
}

