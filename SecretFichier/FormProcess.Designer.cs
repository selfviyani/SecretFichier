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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProcess));
            this.bn_process = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bn_destination = new System.Windows.Forms.Button();
            this.tb_destination = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bn_process
            // 
            this.bn_process.Enabled = false;
            this.bn_process.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bn_process.Location = new System.Drawing.Point(213, 402);
            this.bn_process.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bn_process.Name = "bn_process";
            this.bn_process.Size = new System.Drawing.Size(208, 49);
            this.bn_process.TabIndex = 1;
            this.bn_process.Text = "Process";
            this.bn_process.UseVisualStyleBackColor = true;
            this.bn_process.Click += new System.EventHandler(this.bn_process_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(218, 0);
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
            this.panel1.Location = new System.Drawing.Point(-5, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 62);
            this.panel1.TabIndex = 3;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_password.Location = new System.Drawing.Point(293, 198);
            this.tb_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '⬤';
            this.tb_password.Size = new System.Drawing.Size(355, 43);
            this.tb_password.TabIndex = 4;
            this.toolTip1.SetToolTip(this.tb_password, "The password should be eight characters.");
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 43);
            this.label2.TabIndex = 10;
            this.label2.Text = "Insert Your Password";
            // 
            // bn_destination
            // 
            this.bn_destination.Image = ((System.Drawing.Image)(resources.GetObject("bn_destination.Image")));
            this.bn_destination.Location = new System.Drawing.Point(603, 90);
            this.bn_destination.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bn_destination.Name = "bn_destination";
            this.bn_destination.Size = new System.Drawing.Size(45, 43);
            this.bn_destination.TabIndex = 11;
            this.bn_destination.UseVisualStyleBackColor = true;
            this.bn_destination.Click += new System.EventHandler(this.bn_destination_Click);
            // 
            // tb_destination
            // 
            this.tb_destination.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_destination.Location = new System.Drawing.Point(293, 90);
            this.tb_destination.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_destination.Name = "tb_destination";
            this.tb_destination.Size = new System.Drawing.Size(280, 43);
            this.tb_destination.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 43);
            this.label3.TabIndex = 14;
            this.label3.Text = "Destination File";
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "gdgdfg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(293, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(338, 35);
            this.label4.TabIndex = 15;
            this.label4.Text = "Put more than eight characters ";
            // 
            // FormProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 457);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_destination);
            this.Controls.Add(this.bn_destination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bn_process);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormProcess";
            this.Text = "Form Process";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bn_process;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bn_destination;
        private System.Windows.Forms.TextBox tb_destination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
    }
}