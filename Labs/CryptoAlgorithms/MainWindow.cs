using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoAlgorithms.Algorithms;
using CryptoAlgorithms.Helpers;

namespace CryptoAlgorithms
{
    public partial class MainWindow : Form
    {

        private readonly string _initialDirectory = Environment.CurrentDirectory + @"\Files\";

        public MainWindow()
        {
            InitializeComponent();
        }


        private string GetFileName()
        {
            var dialog = new OpenFileDialog()
            {
                InitialDirectory = _initialDirectory
            };

            dialog.ShowDialog();

            return dialog.FileName;
        }

        #region AES

        private void aesEncryptKeyChooseBtn_Click(object sender, EventArgs e)
        {
            aesEncryptKeyFile.Text = GetFileName();
        }

        private void aesEncryptKeyGenerateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(aesEncryptKeyFile.Text))
            {
                aesEncryptKeyFile.Text = _initialDirectory + "AES_key.txt";
            }

            Generator.GenerateAesKey(aesEncryptKeyFile.Text);
        }

        private void aesEncryptIVChooseBtn_Click(object sender, EventArgs e)
        {
            aesEncryptIVFile.Text = GetFileName();
        }

        private void aesEncryptPlainChooseBtn_Click(object sender, EventArgs e)
        {
            aesEncryptPlainFile.Text = GetFileName();
        }

        private void aesEncryptIvGenerateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(aesEncryptIVFile.Text))
            {
                aesEncryptIVFile.Text = _initialDirectory + "AES_IV.txt";
            }

            Generator.GenerateAesInitializationVector(aesEncryptIVFile.Text);
        }

        private void aesStartEncryptionBtn_Click(object sender, EventArgs e)
        {
            var ready = true;

            if (string.IsNullOrWhiteSpace(aesEncryptPlainFile.Text))
            {
                MessageBox.Show("Choose a file for encryption", "Choose plain text", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                ready = false;
            }
            if (string.IsNullOrWhiteSpace(aesEncryptKeyFile.Text))
            {
                aesEncryptKeyGenerateBtn_Click(sender, e);
            }
            if (string.IsNullOrWhiteSpace(aesEncryptIVFile.Text))
            {
                aesEncryptIvGenerateBtn_Click(sender, e);
            }
            if (string.IsNullOrWhiteSpace(aesEncryptCipherFile.Text))
            {
                aesEncryptCipherFile.Text = _initialDirectory + "AES_cipher.bin";
            }

            if (ready)
            {
                AES.Encrypt(aesEncryptPlainFile.Text, aesEncryptKeyFile.Text, aesEncryptIVFile.Text,
                        aesEncryptCipherFile.Text); 
            }
        }

        private void aesDecryptChooseKeyBtn_Click(object sender, EventArgs e)
        {
            aesDecryptKeyFile.Text = GetFileName();
        }

        private void aesDecryptChooseIvBtn_Click(object sender, EventArgs e)
        {
            aesDecryptIvFile.Text = GetFileName();
        }

        private void aesDecryptCipherBtn_Click(object sender, EventArgs e)
        {
            aesDecryptCipherFile.Text = GetFileName();
        }

        private void aesDecryptStartBtn_Click(object sender, EventArgs e)
        {
            var ready = true;

            if (string.IsNullOrWhiteSpace(aesDecryptCipherFile.Text))
            {
                MessageBox.Show("Choose a file for decryption", "Choose plain text", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                ready = false;
            }
            if (string.IsNullOrWhiteSpace(aesDecryptKeyFile.Text))
            {
                MessageBox.Show("Choose a file with AES key", "Choose key file", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                ready = false;
            }
            if (string.IsNullOrWhiteSpace(aesDecryptIvFile.Text))
            {
                MessageBox.Show("Choose a file with AES initialization vector", "Choose IV file", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                ready = false;
            }
            if (string.IsNullOrWhiteSpace(aesDecryptPlainFile.Text))
            {
                aesDecryptPlainFile.Text = _initialDirectory + "AES_decrypted.txt";
            }

            if (ready)
            {
                AES.Decrypt(aesDecryptCipherFile.Text, aesDecryptKeyFile.Text, aesDecryptIvFile.Text,
                        aesDecryptPlainFile.Text); 
            }
        }

        #endregion

        #region SHA-1

        private void sha1PlainChooseBtn_Click(object sender, EventArgs e)
        {
            sha1PlainFile.Text = GetFileName();
        }

        private void sha1CalculateHashBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sha1HashFile.Text))
            {
                sha1HashFile.Text = _initialDirectory + "SHA_hash.txt";
            }

            SHA1.CalculateHash(sha1PlainFile.Text, sha1HashFile.Text);
        }

        #endregion

        #region RSA

        private void rsaGenerateKeysBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var keysSize = int.Parse(rsaKeysSize.Text);
                RSA.GenerateKeys(keysSize, _initialDirectory + "RSA_private.txt", _initialDirectory + "RSA_public.txt");
            }
            catch (FormatException exception)
            {
                MessageBox.Show(exception.Message, "Parsing error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Key creation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rsaEncryptPlainBtn_Click(object sender, EventArgs e)
        {
            rsaEncryptPlainFile.Text = GetFileName();
        }

        private void rsaEncryptPublicBtn_Click(object sender, EventArgs e)
        {
            rsaEncryptPublicKey.Text = GetFileName();
        }

        private void rsaStartEncrypt_Click(object sender, EventArgs e)
        {
            var ready = true;

            if (string.IsNullOrWhiteSpace(rsaEncryptPlainFile.Text))
            {
                MessageBox.Show("Choose a file for encryption", "Choose plain text", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                ready = false;
            }
            if (string.IsNullOrWhiteSpace(rsaEncryptPublicKey.Text))
            {
                rsaEncryptPublicKey.Text = _initialDirectory + "RSA_public.txt";
            }
            if (string.IsNullOrWhiteSpace(rsaEncryptCipherFile.Text))
            {
                rsaEncryptCipherFile.Text = _initialDirectory + "RSA_cipher.bin";
            }

            if (ready)
            {
                RSA.Encrypt(rsaEncryptPlainFile.Text, int.Parse(rsaKeysSize.Text), rsaEncryptPublicKey.Text,
                        rsaEncryptCipherFile.Text); 
            }
        }

        private void rsaStartDecrypt_Click(object sender, EventArgs e)
        {
            var ready = true;

            if (string.IsNullOrWhiteSpace(rsaDecryptCipherFile.Text))
            {
                MessageBox.Show("Choose a file for decryption", "Choose cipher text", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                ready = false;
            }
            if (string.IsNullOrWhiteSpace(rsaDecryptPrivateKeyFile.Text))
            {
                rsaDecryptPrivateKeyFile.Text = _initialDirectory + "RSA_private.txt";
            }
            if (string.IsNullOrWhiteSpace(rsaDecryptPlainFile.Text))
            {
                rsaDecryptPlainFile.Text = _initialDirectory + "RSA_decrypted.txt";
            }

            if (ready)
            {
                RSA.Decrypt(rsaDecryptCipherFile.Text, int.Parse(rsaKeysSize.Text), rsaDecryptPrivateKeyFile.Text,
                        rsaDecryptPlainFile.Text);
            }
        }

        private void rsaDecryptPrivateBtn_Click(object sender, EventArgs e)
        {
            rsaDecryptPrivateKeyFile.Text = GetFileName();
        }

        private void rsaDecryptCipherBtn_Click(object sender, EventArgs e)
        {
            rsaDecryptCipherFile.Text = GetFileName();
        }

        #endregion

       
    }
}
