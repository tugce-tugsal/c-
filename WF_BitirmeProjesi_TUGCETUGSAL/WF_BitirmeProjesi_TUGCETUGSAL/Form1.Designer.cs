namespace WF_BitirmeProjesi_TUGCETUGSAL
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
            this.btn_personelkayit = new System.Windows.Forms.Button();
            this.btn_departmanKayit = new System.Windows.Forms.Button();
            this.btn_personelArama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_personelkayit
            // 
            this.btn_personelkayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_personelkayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_personelkayit.Location = new System.Drawing.Point(152, 82);
            this.btn_personelkayit.Name = "btn_personelkayit";
            this.btn_personelkayit.Size = new System.Drawing.Size(226, 68);
            this.btn_personelkayit.TabIndex = 0;
            this.btn_personelkayit.Text = "PERSONEL KAYIT FORMU";
            this.btn_personelkayit.UseVisualStyleBackColor = false;
            this.btn_personelkayit.Click += new System.EventHandler(this.btn_personelkayit_Click);
            // 
            // btn_departmanKayit
            // 
            this.btn_departmanKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_departmanKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_departmanKayit.Location = new System.Drawing.Point(312, 179);
            this.btn_departmanKayit.Name = "btn_departmanKayit";
            this.btn_departmanKayit.Size = new System.Drawing.Size(226, 68);
            this.btn_departmanKayit.TabIndex = 1;
            this.btn_departmanKayit.Text = "DEPARTMAN KAYIT FORMU";
            this.btn_departmanKayit.UseVisualStyleBackColor = false;
            this.btn_departmanKayit.Click += new System.EventHandler(this.btn_departmanKayit_Click);
            // 
            // btn_personelArama
            // 
            this.btn_personelArama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_personelArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_personelArama.Location = new System.Drawing.Point(152, 268);
            this.btn_personelArama.Name = "btn_personelArama";
            this.btn_personelArama.Size = new System.Drawing.Size(226, 68);
            this.btn_personelArama.TabIndex = 2;
            this.btn_personelArama.Text = "PERSONEL ARAMA EKRANI";
            this.btn_personelArama.UseVisualStyleBackColor = false;
            this.btn_personelArama.Click += new System.EventHandler(this.btn_personelArama_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_personelArama);
            this.Controls.Add(this.btn_departmanKayit);
            this.Controls.Add(this.btn_personelkayit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_personelkayit;
        private System.Windows.Forms.Button btn_departmanKayit;
        private System.Windows.Forms.Button btn_personelArama;
    }
}

