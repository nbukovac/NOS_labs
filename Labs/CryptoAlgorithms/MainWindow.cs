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
            if (string.IsNullOrWhiteSpace(aesEncryptPlainFile.Text))
            {
                MessageBox.Show("Choose a file for encryption", "Choose plain text", MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
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

            AES.Encrypt(aesEncryptPlainFile.Text, aesEncryptKeyFile.Text, aesEncryptIVFile.Text, 
                aesEncryptCipherFile.Text);
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
            if (string.IsNullOrWhiteSpace(aesDecryptCipherFile.Text))
            {
                MessageBox.Show("Choose a file for decryption", "Choose plain text", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(aesDecryptKeyFile.Text))
            {
                MessageBox.Show("Choose a file with AES key", "Choose key file", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(aesDecryptIvFile.Text))
            {
                MessageBox.Show("Choose a file with AES initialization vector", "Choose IV file", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(aesDecryptPlainFile.Text))
            {
                aesDecryptPlainFile.Text = _initialDirectory + "AES_decrypted.txt";
            }

            AES.Decrypt(aesDecryptCipherFile.Text, aesDecryptKeyFile.Text, aesDecryptIvFile.Text,
                aesDecryptPlainFile.Text);
        }

        #endregion

    }
}
