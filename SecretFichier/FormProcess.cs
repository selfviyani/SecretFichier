﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace SecretFichier
{
    public partial class FormProcess : Form
    {
        private string filename;
        //private string destination;
        private bool encrypt;


        byte[] IV = {0, 0, 0, 0, 0, 0, 0, 0,
                     0, 0, 0, 0, 0, 0, 0, 0};



        public FormProcess(String filename, bool encrypt)
        {
            InitializeComponent();
            this.filename = filename;
            this.encrypt = encrypt;
        }



        private void encrypt_file(string password)
        {
            // Generate AES key from password
            SHA256 sha = SHA256.Create();
            byte[] key = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            Aes aes = Aes.Create();
            aes.Key = key;
            aes.IV = IV;
            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

            // Decrypt file
            byte[] data = File.ReadAllBytes(this.filename);
            byte[] edata;
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                {
                    cs.Write(data, 0, data.Length);
                    cs.FlushFinalBlock();
                }
                edata = ms.ToArray();
            }
            File.WriteAllBytes(this.tb_destination.Text, edata);
        }



        private void decrypt_file(string password)
        {
            if (this.filename.EndsWith(".sf"))
            {
                // Generate AES key from password
                SHA256 sha = SHA256.Create();
                byte[] key = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                Aes aes = Aes.Create();
                aes.Key = key;
                aes.IV = IV;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                // Decrypt file
                byte[] edata = File.ReadAllBytes(this.filename);
                byte[] data;
                try
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Write))
                        {
                            cs.Write(edata, 0, edata.Length);
                            cs.FlushFinalBlock();
                        }
                        data = ms.ToArray();
                    }
                File.WriteAllBytes(this.tb_destination.Text, data);
                }
                catch (CryptographicException e)
                {
                    MessageBox.Show("Decryption of '" + this.filename + "' failed. Did you enter the correct password?");
                }
            }
            else
            {
                MessageBox.Show(this.filename + " is not of type .sf.");
            }
        }



        private void bn_process_Click(object sender, EventArgs e)
        {
            if (encrypt)
                encrypt_file(tb_password.Text);
            else
                decrypt_file(tb_password.Text);
            this.Close();
        }



        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            if (tb_password.Text.Length < 8)
                bn_process.Enabled = false;
            else
                bn_process.Enabled = true;
        }





        private void bn_destination_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (this.encrypt)
            {
                sfd.FileName = this.filename + ".sf";
            }
            else
            {
                if (this.filename.EndsWith(".sf"))
                {
                    sfd.FileName = this.filename[0..^3];
                }
                else
                {
                    sfd.FileName = this.filename;
                }
            }

            if (sfd.ShowDialog() == DialogResult.OK)
                {
                    tb_destination.Text = sfd.FileName;
                }  
        }
    }
}
