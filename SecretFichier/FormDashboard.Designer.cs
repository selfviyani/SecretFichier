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
            this.label1 = new System.Windows.Forms.Label();
            this.bn_close = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.logo_ss)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Dashboard";
            // 
            // bn_close
            // 
            this.bn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_close.Image = ((System.Drawing.Image)(resources.GetObject("bn_close.Image")));
            this.bn_close.Location = new System.Drawing.Point(864, 12);
            this.bn_close.Name = "bn_close";
            this.bn_close.Size = new System.Drawing.Size(34, 35);
            this.bn_close.TabIndex = 5;
            this.bn_close.UseVisualStyleBackColor = true;
            this.bn_close.Click += new System.EventHandler(this.bn_close_Click);
            // 
            // logo_ss
            // 
            this.logo_ss.Image = ((System.Drawing.Image)(resources.GetObject("logo_ss.Image")));
            this.logo_ss.Location = new System.Drawing.Point(42, 135);
            this.logo_ss.Name = "logo_ss";
            this.logo_ss.Size = new System.Drawing.Size(322, 316);
            this.logo_ss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_ss.TabIndex = 8;
            this.logo_ss.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(477, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 57);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select The File To";
            // 
            // rb_encryp
            // 
            this.rb_encryp.AutoSize = true;
            this.rb_encryp.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.rb_encryp.Location = new System.Drawing.Point(405, 357);
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
            this.rb_decryp.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.rb_decryp.Location = new System.Drawing.Point(700, 357);
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
            this.bt_add.Location = new System.Drawing.Point(569, 135);
            this.bt_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(109, 96);
            this.bt_add.TabIndex = 12;
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bn_start
            // 
            this.bn_start.Enabled = false;
            this.bn_start.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bn_start.Location = new System.Drawing.Point(519, 425);
            this.bn_start.Name = "bn_start";
            this.bn_start.Size = new System.Drawing.Size(202, 56);
            this.bn_start.TabIndex = 13;
            this.bn_start.Text = "Start";
            this.bn_start.UseVisualStyleBackColor = true;
            this.bn_start.Click += new System.EventHandler(this.bn_ok_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-7, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 48);
            this.panel1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(323, -11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 64);
            this.label3.TabIndex = 15;
            this.label3.Text = "Secret Fichier";
            // 
            // bn_about
            // 
            this.bn_about.Image = ((System.Drawing.Image)(resources.GetObject("bn_about.Image")));
            this.bn_about.Location = new System.Drawing.Point(824, 12);
            this.bn_about.Name = "bn_about";
            this.bn_about.Size = new System.Drawing.Size(34, 35);
            this.bn_about.TabIndex = 15;
            this.bn_about.UseVisualStyleBackColor = true;
            // 
            // tb_dshow
            // 
            this.tb_dshow.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dshow.Location = new System.Drawing.Point(381, 251);
            this.tb_dshow.Name = "tb_dshow";
            this.tb_dshow.Size = new System.Drawing.Size(490, 43);
            this.tb_dshow.TabIndex = 16;
            // 
            // Fr_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 531);
            this.Controls.Add(this.tb_dshow);
            this.Controls.Add(this.bn_about);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bn_start);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.rb_decryp);
            this.Controls.Add(this.rb_encryp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logo_ss);
            this.Controls.Add(this.bn_close);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fr_dashboard";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.logo_ss)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bn_close;
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
    }
}