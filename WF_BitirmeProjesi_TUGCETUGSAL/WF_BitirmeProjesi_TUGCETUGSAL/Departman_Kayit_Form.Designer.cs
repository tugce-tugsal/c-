namespace WF_BitirmeProjesi_TUGCETUGSAL
{
    partial class Departman_Kayit_Form
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_departmanadi_dkf = new System.Windows.Forms.TextBox();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.btn_kaydet_dkf = new System.Windows.Forms.Button();
            this.btn_sil_dkf = new System.Windows.Forms.Button();
            this.btn_güncelle_dkf = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(49, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEPARTMAN ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(32, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "DEPARTMAN ADI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(27, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "AÇIKLAMA:";
            // 
            // txt_departmanadi_dkf
            // 
            this.txt_departmanadi_dkf.Location = new System.Drawing.Point(233, 39);
            this.txt_departmanadi_dkf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_departmanadi_dkf.Name = "txt_departmanadi_dkf";
            this.txt_departmanadi_dkf.Size = new System.Drawing.Size(241, 22);
            this.txt_departmanadi_dkf.TabIndex = 6;
            this.txt_departmanadi_dkf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_departmanadi_dkf_KeyPress);
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(233, 100);
            this.txt_aciklama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(555, 53);
            this.txt_aciklama.TabIndex = 7;
            // 
            // btn_kaydet_dkf
            // 
            this.btn_kaydet_dkf.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_kaydet_dkf.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet_dkf.ForeColor = System.Drawing.Color.Black;
            this.btn_kaydet_dkf.Location = new System.Drawing.Point(427, 186);
            this.btn_kaydet_dkf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_kaydet_dkf.Name = "btn_kaydet_dkf";
            this.btn_kaydet_dkf.Size = new System.Drawing.Size(101, 31);
            this.btn_kaydet_dkf.TabIndex = 9;
            this.btn_kaydet_dkf.Text = "KAYDET";
            this.btn_kaydet_dkf.UseVisualStyleBackColor = false;
            this.btn_kaydet_dkf.Click += new System.EventHandler(this.btn_kaydet_dkf_Click);
            // 
            // btn_sil_dkf
            // 
            this.btn_sil_dkf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_sil_dkf.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil_dkf.Location = new System.Drawing.Point(687, 186);
            this.btn_sil_dkf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sil_dkf.Name = "btn_sil_dkf";
            this.btn_sil_dkf.Size = new System.Drawing.Size(101, 31);
            this.btn_sil_dkf.TabIndex = 10;
            this.btn_sil_dkf.Text = "SİL";
            this.btn_sil_dkf.UseVisualStyleBackColor = false;
            this.btn_sil_dkf.Click += new System.EventHandler(this.btn_sil_dkf_Click);
            // 
            // btn_güncelle_dkf
            // 
            this.btn_güncelle_dkf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_güncelle_dkf.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_güncelle_dkf.Location = new System.Drawing.Point(533, 186);
            this.btn_güncelle_dkf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_güncelle_dkf.Name = "btn_güncelle_dkf";
            this.btn_güncelle_dkf.Size = new System.Drawing.Size(147, 31);
            this.btn_güncelle_dkf.TabIndex = 11;
            this.btn_güncelle_dkf.Text = "GÜNCELLE";
            this.btn_güncelle_dkf.UseVisualStyleBackColor = false;
            this.btn_güncelle_dkf.Click += new System.EventHandler(this.btn_güncelle_dkf_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 251);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 185);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.Color.Plum;
            this.btn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.ForeColor = System.Drawing.Color.Black;
            this.btn_temizle.Location = new System.Drawing.Point(687, 222);
            this.btn_temizle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(101, 31);
            this.btn_temizle.TabIndex = 14;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(700, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(608, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Kayıt Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "...";
            // 
            // Departman_Kayit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_güncelle_dkf);
            this.Controls.Add(this.btn_sil_dkf);
            this.Controls.Add(this.btn_kaydet_dkf);
            this.Controls.Add(this.txt_aciklama);
            this.Controls.Add(this.txt_departmanadi_dkf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Departman_Kayit_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Departman_Kayit_Form";
            this.Load += new System.EventHandler(this.Departman_Kayit_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.Button btn_kaydet_dkf;
        private System.Windows.Forms.Button btn_sil_dkf;
        private System.Windows.Forms.Button btn_güncelle_dkf;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox txt_departmanadi_dkf;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}