using System;
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



        private void encrypt_file_gcm(string password)
        {
            // Generate AES key from password
            SHA256 sha = SHA256.Create();
            byte[] key = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            // Prepare AES GCM
            AesGcm aes = new AesGcm(key);
            byte[] nonce = new byte[AesGcm.NonceByteSizes.MaxSize];
            RandomNumberGenerator rng = new RNGCryptoServiceProvider();
            rng.GetBytes(nonce);

            // Encrypt file
            byte[] data = File.ReadAllBytes(this.filename);
            byte[] edata = new byte[data.Length];
            byte[] tag = new byte[AesGcm.TagByteSizes.MaxSize];
            aes.Encrypt(nonce, data, edata, tag);

            byte[] output = new byte[nonce.Length + edata.Length + tag.Length];
            nonce.CopyTo(output, 0);
            edata.CopyTo(output, nonce.Length);
            tag.CopyTo(output, nonce.Length + edata.Length);
            File.WriteAllBytes(this.tb_destination.Text, output);
        }

        private void decrypt_file_gcm(string password)

        {
            // Generate AES key from password
            SHA256 sha = SHA256.Create();
            byte[] key = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            // Prepare AES GCM
            AesGcm aes = new AesGcm(key);        

            // Decrypt file
            byte[] input = File.ReadAllBytes(this.filename);
            int nsize = AesGcm.NonceByteSizes.MaxSize;
            int tsize = AesGcm.TagByteSizes.MaxSize;
            int dsize = input.Length - nsize - tsize;
            byte[] nonce = input[..nsize];
            byte[] edata = input[nsize..(nsize + dsize)];
            byte[] tag = input[(nsize + dsize)..];

            byte[] data = new byte[edata.Length];
            aes.Decrypt(nonce, edata, tag, data);

            File.WriteAllBytes(this.tb_destination.Text, data);
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
            File.WriteAllBytes(this.tb_destination.Text + ".sf", edata);
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
                File.WriteAllBytes(this.filename.Remove(this.filename.Length - 3), data);
                } catch (CryptographicException e)
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
            if (rb_cbc.Checked) 
            {
                if (encrypt)
                    encrypt_file(tb_password.Text);
                else
                    decrypt_file(tb_password.Text);
            }
            else
            {
                if (encrypt)
                    encrypt_file_gcm(tb_password.Text);
                else
                    decrypt_file_gcm(tb_password.Text);
            }

            this.Close();
        }





        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            if (tb_password.Text.Length < 8)
                bn_process.Enabled = false;
            else
                bn_process.Enabled = true;
        }



        private void bn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void bn_destination_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = this.filename;
            if (sfd.ShowDialog() == DialogResult.OK)
                {
                    tb_destination.Text = sfd.FileName;
                }  
        }
    }
}
