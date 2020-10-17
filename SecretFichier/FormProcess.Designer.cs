namespace SecretFichier
{
    partial class FormProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProcess));
            this.bn_close = new System.Windows.Forms.Button();
            this.bn_process = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bn_destination = new System.Windows.Forms.Button();
            this.tb_destination = new System.Windows.Forms.TextBox();
            this.rb_gcm = new System.Windows.Forms.RadioButton();
            this.rb_cbc = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bn_close
            // 
            this.bn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_close.Image = ((System.Drawing.Image)(resources.GetObject("bn_close.Image")));
            this.bn_close.Location = new System.Drawing.Point(657, 7);
            this.bn_close.Name = "bn_close";
            this.bn_close.Size = new System.Drawing.Size(34, 35);
            this.bn_close.TabIndex = 0;
            this.bn_close.UseVisualStyleBackColor = true;
            this.bn_close.Click += new System.EventHandler(this.bn_close_Click);
            // 
            // bn_process
            // 
            this.bn_process.Enabled = false;
            this.bn_process.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bn_process.Location = new System.Drawing.Point(414, 416);
            this.bn_process.Name = "bn_process";
            this.bn_process.Size = new System.Drawing.Size(171, 51);
            this.bn_process.TabIndex = 1;
            this.bn_process.Text = "Process";
            this.bn_process.UseVisualStyleBackColor = true;
            this.bn_process.Click += new System.EventHandler(this.bn_process_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(238, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Secret Fichier";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-9, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 58);
            this.panel1.TabIndex = 3;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(339, 310);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(320, 43);
            this.tb_password.TabIndex = 4;
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(355, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 43);
            this.label2.TabIndex = 10;
            this.label2.Text = "Insert Your Password";
            // 
            // bn_destination
            // 
            this.bn_destination.Image = ((System.Drawing.Image)(resources.GetObject("bn_destination.Image")));
            this.bn_destination.Location = new System.Drawing.Point(441, 132);
            this.bn_destination.Name = "bn_destination";
            this.bn_destination.Size = new System.Drawing.Size(109, 96);
            this.bn_destination.TabIndex = 11;
            this.bn_destination.UseVisualStyleBackColor = true;
            this.bn_destination.Click += new System.EventHandler(this.bn_destination_Click);
            // 
            // tb_destination
            // 
            this.tb_destination.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_destination.Location = new System.Drawing.Point(339, 243);
            this.tb_destination.Name = "tb_destination";
            this.tb_destination.Size = new System.Drawing.Size(320, 43);
            this.tb_destination.TabIndex = 13;
            // 
            // rb_gcm
            // 
            this.rb_gcm.AutoSize = true;
            this.rb_gcm.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.rb_gcm.Location = new System.Drawing.Point(71, 237);
            this.rb_gcm.Name = "rb_gcm";
            this.rb_gcm.Size = new System.Drawing.Size(224, 47);
            this.rb_gcm.TabIndex = 14;
            this.rb_gcm.TabStop = true;
            this.rb_gcm.Text = "AES 256 GCM";
            this.rb_gcm.UseVisualStyleBackColor = true;
            // 
            // rb_cbc
            // 
            this.rb_cbc.AutoSize = true;
            this.rb_cbc.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.rb_cbc.Location = new System.Drawing.Point(71, 290);
            this.rb_cbc.Name = "rb_cbc";
            this.rb_cbc.Size = new System.Drawing.Size(217, 47);
            this.rb_cbc.TabIndex = 15;
            this.rb_cbc.TabStop = true;
            this.rb_cbc.Text = "AES 256 CBC";
            this.rb_cbc.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(22, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 50);
            this.label3.TabIndex = 16;
            this.label3.Text = "Choose the mode that ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(33, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 50);
            this.label4.TabIndex = 17;
            this.label4.Text = "you want for process";
            // 
            // FormProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 507);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rb_cbc);
            this.Controls.Add(this.rb_gcm);
            this.Controls.Add(this.tb_destination);
            this.Controls.Add(this.bn_destination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bn_process);
            this.Controls.Add(this.bn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProcess";
            this.Text = "FormInsertpass";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bn_close;
        private System.Windows.Forms.Button bn_process;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bn_destination;
        private System.Windows.Forms.TextBox tb_destination;
        private System.Windows.Forms.RadioButton rb_gcm;
        private System.Windows.Forms.RadioButton rb_cbc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}