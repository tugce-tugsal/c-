namespace oop_Polymorphism
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
            this.btn_base = new System.Windows.Forms.Button();
            this.btn_nokia = new System.Windows.Forms.Button();
            this.btn_samsung = new System.Windows.Forms.Button();
            this.btn_iphone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_base
            // 
            this.btn_base.Location = new System.Drawing.Point(80, 28);
            this.btn_base.Name = "btn_base";
            this.btn_base.Size = new System.Drawing.Size(173, 46);
            this.btn_base.TabIndex = 0;
            this.btn_base.Text = "button1";
            this.btn_base.UseVisualStyleBackColor = true;
            // 
            // btn_nokia
            // 
            this.btn_nokia.Location = new System.Drawing.Point(80, 95);
            this.btn_nokia.Name = "btn_nokia";
            this.btn_nokia.Size = new System.Drawing.Size(173, 46);
            this.btn_nokia.TabIndex = 1;
            this.btn_nokia.Text = "nokia";
            this.btn_nokia.UseVisualStyleBackColor = true;
            this.btn_nokia.Click += new System.EventHandler(this.btn_nokia_Click);
            // 
            // btn_samsung
            // 
            this.btn_samsung.Location = new System.Drawing.Point(80, 156);
            this.btn_samsung.Name = "btn_samsung";
            this.btn_samsung.Size = new System.Drawing.Size(173, 46);
            this.btn_samsung.TabIndex = 2;
            this.btn_samsung.Text = "samsung";
            this.btn_samsung.UseVisualStyleBackColor = true;
            this.btn_samsung.Click += new System.EventHandler(this.btn_samsung_Click);
            // 
            // btn_iphone
            // 
            this.btn_iphone.Location = new System.Drawing.Point(80, 234);
            this.btn_iphone.Name = "btn_iphone";
            this.btn_iphone.Size = new System.Drawing.Size(173, 46);
            this.btn_iphone.TabIndex = 3;
            this.btn_iphone.Text = "iphone";
            this.btn_iphone.UseVisualStyleBackColor = true;
            this.btn_iphone.Click += new System.EventHandler(this.btn_iphone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_iphone);
            this.Controls.Add(this.btn_samsung);
            this.Controls.Add(this.btn_nokia);
            this.Controls.Add(this.btn_base);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_base;
        private System.Windows.Forms.Button btn_nokia;
        private System.Windows.Forms.Button btn_samsung;
        private System.Windows.Forms.Button btn_iphone;
    }
}

