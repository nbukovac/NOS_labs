using System;
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
            var dialog = new OpenFileDialog
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
                RSA.GenerateKeys(keysSize, _initialDirectory + "RSA_sender_private.txt", 
                    _initialDirectory + "RSA_sender_public.txt");
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

        #region Envelope

        private void envelopeEncryptStart_Click(object sender, EventArgs e)
        {
            var ready = true;

            if (string.IsNullOrWhiteSpace(envelopeEncryptPlain.Text))
            {
                MessageBox.Show("Choose a file for encryption", "Choose plain text", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                ready = false;
            }
            if (string.IsNullOrWhiteSpace(envelopeEncryptPublic.Text))
            {
                envelopeEncryptPlain.Text = _initialDirectory + "RSA_public.txt";
            }
            if (string.IsNullOrWhiteSpace(rsaEncryptCipherFile.Text))
            {
                envelopeEncryptEnvelope.Text = _initialDirectory + "envelope.txt";
            }

            if (ready)
            {
                DigitalEnvelope.CreateEnvelope(envelopeEncryptPlain.Text, int.Parse(rsaKeysSize.Text),
                    envelopeEncryptPublic.Text, envelopeEncryptEnvelope.Text);
            }
        }

        private void envelopeEncryptPublicBtn_Click(object sender, EventArgs e)
        {
            envelopeEncryptPublic.Text = GetFileName();
        }

        private void envelopeEncryptPlainBtn_Click(object sender, EventArgs e)
        {
            envelopeEncryptPlain.Text = GetFileName();
        }

        private void envelopeDecryptStartBtn_Click(object sender, EventArgs e)
        {
            var ready = true;

            if (string.IsNullOrWhiteSpace(envelopeDecryptEnvelope.Text))
            {
                MessageBox.Show("Choose a file for decryption", "Choose envelope", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                ready = false;
            }
            if (string.IsNullOrWhiteSpace(envelopeDecryptPrivate.Text))
            {
                envelopeDecryptPrivate.Text = _initialDirectory + "RSA_private.txt";
            }
            if (string.IsNullOrWhiteSpace(envelopeDecryptPlain.Text))
            {
                envelopeDecryptPlain.Text = _initialDirectory + "envelope_decrypted.txt";
            }

            if (ready)
            {
                DigitalEnvelope.ReadEnvelope(envelopeDecryptEnvelope.Text, int.Parse(rsaKeysSize.Text),
                    envelopeDecryptPrivate.Text, envelopeDecryptPlain.Text);
            }
        }

        private void envelopeDecryptprivateBtn_Click(object sender, EventArgs e)
        {
            envelopeDecryptPrivate.Text = GetFileName();
        }

        private void envelopeDecryptEnvelopeBtn_Click(object sender, EventArgs e)
        {
            envelopeDecryptEnvelope.Text = GetFileName();
        }

        #endregion

        #region Signature

        private void signatureCreateSignature_Click(object sender, EventArgs e)
        {
            var ready = true;

            if (string.IsNullOrWhiteSpace(signatureSignPlain.Text))
            {
                MessageBox.Show("Choose a plain text file", "Choose a plain text file", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                ready = false;
            }
            if (string.IsNullOrWhiteSpace(signatureSignPrivateKey.Text))
            {
                signatureSignPrivateKey.Text = _initialDirectory + "RSA_private.txt";
            }
            if (string.IsNullOrWhiteSpace(signatureSignSignature.Text))
            {
                signatureSignSignature.Text = _initialDirectory + "Signature.txt";
            }

            if (ready)
            {
                DigitalSignature.CreateSignature(signatureSignPlain.Text, int.Parse(rsaKeysSize.Text), 
                    signatureSignPrivateKey.Text, signatureSignSignature.Text);
            }
        }

        private void signatureSignPrivateBtn_Click(object sender, EventArgs e)
        {
            signatureSignPrivateKey.Text = GetFileName();
        }

        private void signatureSignPlainBtn_Click(object sender, EventArgs e)
        {
            signatureSignPlain.Text = GetFileName();
        }

        private void signatureVerifyPublicBtn_Click(object sender, EventArgs e)
        {
            signatureVerifyPublicKey.Text = GetFileName();
        }

        private void signatureVerifySignatureBtn_Click(object sender, EventArgs e)
        {
            signatureVerifySignatureFile.Text = GetFileName();
        }

        private void signatureVerifyBtn_Click(object sender, EventArgs e)
        {
            var ready = true;

            if (string.IsNullOrWhiteSpace(signatureVerifySignatureFile.Text))
            {
                MessageBox.Show("Choose a signature file", "Choose a signature file", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                ready = false;
            }
            if (string.IsNullOrWhiteSpace(signatureVerifyPublicKey.Text))
            {
                signatureVerifyPublicKey.Text = _initialDirectory + "RSA_public.txt";
            }

            if (ready)
            {
                var verified = DigitalSignature.VerifySignature(signatureVerifySignatureFile.Text, int.Parse(rsaKeysSize.Text),
                    signatureVerifyPublicKey.Text);

                if (verified)
                {
                    MessageBox.Show("Sender is verified", "Verified", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sender is not verified", "Not verified", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        #endregion

        #region SignedEnvelope

        private void signedEnvelopeCreateBtn_Click(object sender, EventArgs e)
        {
            var ready = true;

            if (string.IsNullOrWhiteSpace(signedEnvelopeCreatePlain.Text))
            {
                MessageBox.Show("Choose a plain text file", "Choose a plain text file", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                ready = false;
            }
            if (string.IsNullOrWhiteSpace(signedEnvelopeCreateSenderPrivate.Text))
            {
                signedEnvelopeCreateSenderPrivate.Text = _initialDirectory + "RSA_sender_private.txt";
            }
            if (string.IsNullOrWhiteSpace(signedEnvelopeCreateReceiverPublic.Text))
            {
                signedEnvelopeCreateReceiverPublic.Text = _initialDirectory + "RSA_public.txt";
            }
            if (string.IsNullOrWhiteSpace(signedEnvelopeCreateEnvelope.Text))
            {
                signedEnvelopeCreateEnvelope.Text = _initialDirectory + "Signed_envelope.txt";
            }

            if (ready)
            {
               SignedEnvelope.CreateSignedEnvelope(signedEnvelopeCreatePlain.Text, int.Parse(rsaKeysSize.Text),
                   signedEnvelopeCreateReceiverPublic.Text, signedEnvelopeCreateSenderPrivate.Text,
                   signedEnvelopeCreateEnvelope.Text);
            }
        }

        private void signedEnvelopeCreateSenderPrivateBtn_Click(object sender, EventArgs e)
        {
            signedEnvelopeCreateSenderPrivate.Text = GetFileName();
        }

        private void signedEnvelopeCreateReceiverPublicBtn_Click(object sender, EventArgs e)
        {
            signedEnvelopeCreateReceiverPublic.Text = GetFileName();
        }

        private void signedEnvelopeCreatePlainBtn_Click(object sender, EventArgs e)
        {
            signedEnvelopeCreatePlain.Text = GetFileName();
        }

        private void signedEnvelopeOpenEnvelopeBtn_Click(object sender, EventArgs e)
        {
            signedEnvelopeOpenEnvelope.Text = GetFileName();
        }

        private void signedEnvelopeOpenReceiverPrivateBtn_Click(object sender, EventArgs e)
        {
            signedEnvelopeOpenReceiverPrivate.Text = GetFileName();
        }

        private void signedEnvelopeOpenSenderPublicBtn_Click(object sender, EventArgs e)
        {
            signedEnvelopeOpenSenderPublic.Text = GetFileName();
        }

        private void signedEnvelopeOpenBtn_Click(object sender, EventArgs e)
        {
            var ready = true;

            if (string.IsNullOrWhiteSpace(signedEnvelopeOpenEnvelope.Text))
            {
                MessageBox.Show("Choose a signed envelope file", "Choose a signed envelope file", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                ready = false;
            }
            if (string.IsNullOrWhiteSpace(signedEnvelopeOpenReceiverPrivate.Text))
            {
                signedEnvelopeOpenReceiverPrivate.Text = _initialDirectory + "RSA_private.txt";
            }
            if (string.IsNullOrWhiteSpace(signedEnvelopeOpenSenderPublic.Text))
            {
                signedEnvelopeOpenSenderPublic.Text = _initialDirectory + "RSA_sender_public.txt";
            }
            if (string.IsNullOrWhiteSpace(signedEnvelopeOpenPlain.Text))
            {
                signedEnvelopeOpenPlain.Text = _initialDirectory + "Opened_signed_envelope.txt";
            }

            if (ready)
            {
                var verified = SignedEnvelope.OpenSignedEnvelope(signedEnvelopeOpenEnvelope.Text, 
                    int.Parse(rsaKeysSize.Text), signedEnvelopeOpenReceiverPrivate.Text, 
                    signedEnvelopeOpenSenderPublic.Text, signedEnvelopeOpenPlain.Text);

                if (verified)
                {
                    MessageBox.Show("Sender is verified", "Verified", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sender is not verified", "Not verified", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        #endregion

    }
}