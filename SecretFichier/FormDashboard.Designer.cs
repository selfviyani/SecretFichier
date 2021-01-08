namespace SecretFichier
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.logo_ss = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_encryp = new System.Windows.Forms.RadioButton();
            this.rb_decryp = new System.Windows.Forms.RadioButton();
            this.bt_add = new System.Windows.Forms.Button();
            this.bn_start = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bn_about = new System.Windows.Forms.Button();
            this.tb_dshow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo_ss)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo_ss
            // 
            this.logo_ss.Image = ((System.Drawing.Image)(resources.GetObject("logo_ss.Image")));
            this.logo_ss.Location = new System.Drawing.Point(36, 96);
            this.logo_ss.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logo_ss.Name = "logo_ss";
            this.logo_ss.Size = new System.Drawing.Size(338, 332);
            this.logo_ss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_ss.TabIndex = 8;
            this.logo_ss.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(401, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 57);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select an Operation";
            // 
            // rb_encryp
            // 
            this.rb_encryp.AutoSize = true;
            this.rb_encryp.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_encryp.Location = new System.Drawing.Point(413, 379);
            this.rb_encryp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_encryp.Name = "rb_encryp";
            this.rb_encryp.Size = new System.Drawing.Size(151, 39);
            this.rb_encryp.TabIndex = 10;
            this.rb_encryp.TabStop = true;
            this.rb_encryp.Text = "Encryption";
            this.rb_encryp.UseVisualStyleBackColor = true;
            this.rb_encryp.CheckedChanged += new System.EventHandler(this.rb_encryp_CheckedChanged);
            // 
            // rb_decryp
            // 
            this.rb_decryp.AutoSize = true;
            this.rb_decryp.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_decryp.Location = new System.Drawing.Point(598, 379);
            this.rb_decryp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_decryp.Name = "rb_decryp";
            this.rb_decryp.Size = new System.Drawing.Size(150, 39);
            this.rb_decryp.TabIndex = 11;
            this.rb_decryp.TabStop = true;
            this.rb_decryp.Text = "Decryption";
            this.rb_decryp.UseVisualStyleBackColor = true;
            this.rb_decryp.CheckedChanged += new System.EventHandler(this.rb_decryp_CheckedChanged);
            // 
            // bt_add
            // 
            this.bt_add.Image = ((System.Drawing.Image)(resources.GetObject("bt_add.Image")));
            this.bt_add.Location = new System.Drawing.Point(891, 189);
            this.bt_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(47, 43);
            this.bt_add.TabIndex = 12;
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bn_start
            // 
            this.bn_start.Enabled = false;
            this.bn_start.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bn_start.Location = new System.Drawing.Point(557, 461);
            this.bn_start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bn_start.Name = "bn_start";
            this.bn_start.Size = new System.Drawing.Size(213, 60);
            this.bn_start.TabIndex = 13;
            this.bn_start.Text = "Continue";
            this.bn_start.UseVisualStyleBackColor = true;
            this.bn_start.Click += new System.EventHandler(this.bn_ok_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bn_about);
            this.panel1.Location = new System.Drawing.Point(-11, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 60);
            this.panel1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(355, -4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 64);
            this.label3.TabIndex = 15;
            this.label3.Text = "Secret Fichier";
            // 
            // bn_about
            // 
            this.bn_about.Image = ((System.Drawing.Image)(resources.GetObject("bn_about.Image")));
            this.bn_about.Location = new System.Drawing.Point(47, 7);
            this.bn_about.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bn_about.Name = "bn_about";
            this.bn_about.Size = new System.Drawing.Size(38, 44);
            this.bn_about.TabIndex = 15;
            this.bn_about.UseVisualStyleBackColor = true;
            this.bn_about.Click += new System.EventHandler(this.bn_about_Click);
            // 
            // tb_dshow
            // 
            this.tb_dshow.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_dshow.Location = new System.Drawing.Point(401, 189);
            this.tb_dshow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_dshow.Name = "tb_dshow";
            this.tb_dshow.Size = new System.Drawing.Size(462, 43);
            this.tb_dshow.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(413, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 57);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select the File";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_dshow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bn_start);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.rb_decryp);
            this.Controls.Add(this.rb_encryp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logo_ss);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.logo_ss)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox logo_ss;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_encryp;
        private System.Windows.Forms.RadioButton rb_decryp;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bn_start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bn_about;
        private System.Windows.Forms.TextBox tb_dshow;
        private System.Windows.Forms.Label label1;
    }
}