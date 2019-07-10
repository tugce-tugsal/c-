namespace at_yarisi_örnek
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_birinciyol = new System.Windows.Forms.Label();
            this.lbl_ikinciyol = new System.Windows.Forms.Label();
            this.lbl_bitis = new System.Windows.Forms.Label();
            this.picture_at3 = new System.Windows.Forms.PictureBox();
            this.picture_at2 = new System.Windows.Forms.PictureBox();
            this.picture_at1 = new System.Windows.Forms.PictureBox();
            this.btn_baslat = new System.Windows.Forms.Button();
            this.btn_sıfırla = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_tablo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_at3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_at2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_at1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_birinciyol
            // 
            this.lbl_birinciyol.AutoSize = true;
            this.lbl_birinciyol.BackColor = System.Drawing.Color.Green;
            this.lbl_birinciyol.Location = new System.Drawing.Point(40, 227);
            this.lbl_birinciyol.Name = "lbl_birinciyol";
            this.lbl_birinciyol.Size = new System.Drawing.Size(1140, 17);
            this.lbl_birinciyol.TabIndex = 0;
            this.lbl_birinciyol.Text = resources.GetString("lbl_birinciyol.Text");
            this.lbl_birinciyol.Click += new System.EventHandler(this.lbl_birinciyol_Click);
            // 
            // lbl_ikinciyol
            // 
            this.lbl_ikinciyol.AutoSize = true;
            this.lbl_ikinciyol.BackColor = System.Drawing.Color.Green;
            this.lbl_ikinciyol.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ikinciyol.Location = new System.Drawing.Point(40, 421);
            this.lbl_ikinciyol.Name = "lbl_ikinciyol";
            this.lbl_ikinciyol.Size = new System.Drawing.Size(1140, 17);
            this.lbl_ikinciyol.TabIndex = 1;
            this.lbl_ikinciyol.Text = resources.GetString("lbl_ikinciyol.Text");
            // 
            // lbl_bitis
            // 
            this.lbl_bitis.AutoSize = true;
            this.lbl_bitis.BackColor = System.Drawing.Color.Red;
            this.lbl_bitis.Location = new System.Drawing.Point(1198, 42);
            this.lbl_bitis.Name = "lbl_bitis";
            this.lbl_bitis.Size = new System.Drawing.Size(8, 578);
            this.lbl_bitis.TabIndex = 3;
            this.lbl_bitis.Text = "\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // picture_at3
            // 
            this.picture_at3.Image = global::at_yarisi_örnek.Properties.Resources.ata_binme_hareketli_resim_0039;
            this.picture_at3.Location = new System.Drawing.Point(40, 473);
            this.picture_at3.Name = "picture_at3";
            this.picture_at3.Size = new System.Drawing.Size(202, 107);
            this.picture_at3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_at3.TabIndex = 6;
            this.picture_at3.TabStop = false;
            // 
            // picture_at2
            // 
            this.picture_at2.Image = global::at_yarisi_örnek.Properties.Resources.ata_binme_hareketli_resim_0015;
            this.picture_at2.Location = new System.Drawing.Point(40, 279);
            this.picture_at2.Name = "picture_at2";
            this.picture_at2.Size = new System.Drawing.Size(202, 107);
            this.picture_at2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_at2.TabIndex = 5;
            this.picture_at2.TabStop = false;
            // 
            // picture_at1
            // 
            this.picture_at1.Image = global::at_yarisi_örnek.Properties.Resources.ata_binme_hareketli_resim_0008;
            this.picture_at1.Location = new System.Drawing.Point(40, 85);
            this.picture_at1.Name = "picture_at1";
            this.picture_at1.Size = new System.Drawing.Size(202, 107);
            this.picture_at1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_at1.TabIndex = 4;
            this.picture_at1.TabStop = false;
            // 
            // btn_baslat
            // 
            this.btn_baslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_baslat.Location = new System.Drawing.Point(597, 13);
            this.btn_baslat.Name = "btn_baslat";
            this.btn_baslat.Size = new System.Drawing.Size(95, 36);
            this.btn_baslat.TabIndex = 7;
            this.btn_baslat.Text = "Başlat";
            this.btn_baslat.UseVisualStyleBackColor = true;
            this.btn_baslat.Click += new System.EventHandler(this.btn_baslat_Click);
            // 
            // btn_sıfırla
            // 
            this.btn_sıfırla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sıfırla.Location = new System.Drawing.Point(716, 14);
            this.btn_sıfırla.Name = "btn_sıfırla";
            this.btn_sıfırla.Size = new System.Drawing.Size(85, 35);
            this.btn_sıfırla.TabIndex = 8;
            this.btn_sıfırla.Text = "Sıfırla";
            this.btn_sıfırla.UseVisualStyleBackColor = true;
            this.btn_sıfırla.Click += new System.EventHandler(this.btn_sıfırla_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_tablo
            // 
            this.lbl_tablo.AutoSize = true;
            this.lbl_tablo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tablo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tablo.Location = new System.Drawing.Point(164, 24);
            this.lbl_tablo.Name = "lbl_tablo";
            this.lbl_tablo.Size = new System.Drawing.Size(84, 25);
            this.lbl_tablo.TabIndex = 9;
            this.lbl_tablo.Text = "            ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1298, 629);
            this.Controls.Add(this.lbl_tablo);
            this.Controls.Add(this.btn_sıfırla);
            this.Controls.Add(this.btn_baslat);
            this.Controls.Add(this.picture_at3);
            this.Controls.Add(this.picture_at2);
            this.Controls.Add(this.picture_at1);
            this.Controls.Add(this.lbl_bitis);
            this.Controls.Add(this.lbl_birinciyol);
            this.Controls.Add(this.lbl_ikinciyol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_at3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_at2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_at1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_birinciyol;
        private System.Windows.Forms.Label lbl_ikinciyol;
        private System.Windows.Forms.Label lbl_bitis;
        private System.Windows.Forms.PictureBox picture_at1;
        private System.Windows.Forms.PictureBox picture_at2;
        private System.Windows.Forms.PictureBox picture_at3;
        private System.Windows.Forms.Button btn_baslat;
        private System.Windows.Forms.Button btn_sıfırla;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_tablo;
    }
}

