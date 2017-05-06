namespace CryptoAlgorithms
{
    partial class MainWindow
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.aesTab = new System.Windows.Forms.TabPage();
            this.aesDecryptGroup = new System.Windows.Forms.GroupBox();
            this.aesDecryptCipherBtn = new System.Windows.Forms.Button();
            this.aesDecryptChooseIvBtn = new System.Windows.Forms.Button();
            this.aesDecryptChooseKeyBtn = new System.Windows.Forms.Button();
            this.aesDecryptStartBtn = new System.Windows.Forms.Button();
            this.aesDecryptPlainFile = new System.Windows.Forms.TextBox();
            this.aesDecryptCipherFile = new System.Windows.Forms.TextBox();
            this.aesDecryptIvFile = new System.Windows.Forms.TextBox();
            this.aesDecryptKeyFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aesEncryptGroup = new System.Windows.Forms.GroupBox();
            this.aesStartEncryptionBtn = new System.Windows.Forms.Button();
            this.aesEncryptPlainChoosBtn = new System.Windows.Forms.Button();
            this.aesEncryptIvGenerateBtn = new System.Windows.Forms.Button();
            this.aesEncryptIVChooseBtn = new System.Windows.Forms.Button();
            this.aesEncryptKeyGenerateBtn = new System.Windows.Forms.Button();
            this.aesEncryptKeyChooseBtn = new System.Windows.Forms.Button();
            this.aesEncryptCipherFile = new System.Windows.Forms.TextBox();
            this.aesEncryptCipherFileLabel = new System.Windows.Forms.Label();
            this.aesEncryptPlainFile = new System.Windows.Forms.TextBox();
            this.aesEncryptIVFile = new System.Windows.Forms.TextBox();
            this.aesEncryptKeyFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aesIVLabel = new System.Windows.Forms.Label();
            this.aesKeyLabel = new System.Windows.Forms.Label();
            this.sha1Tab = new System.Windows.Forms.TabPage();
            this.sha1CalculateHashBtn = new System.Windows.Forms.Button();
            this.sha1PlainChooseBtn = new System.Windows.Forms.Button();
            this.sha1HashFile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sha1PlainFile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rsaTab = new System.Windows.Forms.TabPage();
            this.rsaDecryptBox = new System.Windows.Forms.GroupBox();
            this.rsaStartDecrypt = new System.Windows.Forms.Button();
            this.rsaDecryptPrivateBtn = new System.Windows.Forms.Button();
            this.rsaDecryptCipherBtn = new System.Windows.Forms.Button();
            this.rsaDecryptPlainFile = new System.Windows.Forms.TextBox();
            this.rsaDecryptPrivateKeyFile = new System.Windows.Forms.TextBox();
            this.rsaDecryptCipherFile = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rsaEncryptBox = new System.Windows.Forms.GroupBox();
            this.rsaStartEncrypt = new System.Windows.Forms.Button();
            this.rsaEncryptPublicBtn = new System.Windows.Forms.Button();
            this.rsaEncryptPlainBtn = new System.Windows.Forms.Button();
            this.rsaEncryptCipherFile = new System.Windows.Forms.TextBox();
            this.rsaEncryptPublicKey = new System.Windows.Forms.TextBox();
            this.rsaEncryptPlainFile = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rsaKeysSize = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rsaGenerateKeysBtn = new System.Windows.Forms.Button();
            this.envelopeTab = new System.Windows.Forms.TabPage();
            this.envelopeDecryptBox = new System.Windows.Forms.GroupBox();
            this.envelopeDecryptStartBtn = new System.Windows.Forms.Button();
            this.envelopeDecryptprivateBtn = new System.Windows.Forms.Button();
            this.envelopeDecryptEnvelopeBtn = new System.Windows.Forms.Button();
            this.envelopeDecryptPlain = new System.Windows.Forms.TextBox();
            this.envelopeDecryptPrivate = new System.Windows.Forms.TextBox();
            this.envelopeDecryptEnvelope = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.envelopeEncryptBox = new System.Windows.Forms.GroupBox();
            this.envelopeEncryptStart = new System.Windows.Forms.Button();
            this.envelopeEncryptPublicBtn = new System.Windows.Forms.Button();
            this.envelopeEncryptPlainBtn = new System.Windows.Forms.Button();
            this.envelopeEncryptEnvelope = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.envelopeEncryptPublic = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.envelopeEncryptPlain = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.signatureTab = new System.Windows.Forms.TabPage();
            this.signatureVerifyBox = new System.Windows.Forms.GroupBox();
            this.signatureVerifyBtn = new System.Windows.Forms.Button();
            this.signatureVerifyPublicBtn = new System.Windows.Forms.Button();
            this.signatureVerifySignatureBtn = new System.Windows.Forms.Button();
            this.signatureVerifyPublicKey = new System.Windows.Forms.TextBox();
            this.signatureVerifySignatureFile = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.signatureCreateBox = new System.Windows.Forms.GroupBox();
            this.signatureCreateSignature = new System.Windows.Forms.Button();
            this.signatureSignPrivateBtn = new System.Windows.Forms.Button();
            this.signatureSignPlainBtn = new System.Windows.Forms.Button();
            this.signatureSignSignature = new System.Windows.Forms.TextBox();
            this.signatureSignPrivateKey = new System.Windows.Forms.TextBox();
            this.signatureSignPlain = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.signedEnvelopeTab = new System.Windows.Forms.TabPage();
            this.signedEnvelopeOpenBox = new System.Windows.Forms.GroupBox();
            this.signedEnvelopeOpenBtn = new System.Windows.Forms.Button();
            this.signedEnvelopeOpenSenderPublicBtn = new System.Windows.Forms.Button();
            this.signedEnvelopeOpenReceiverPrivateBtn = new System.Windows.Forms.Button();
            this.signedEnvelopeOpenEnvelopeBtn = new System.Windows.Forms.Button();
            this.signedEnvelopeOpenPlain = new System.Windows.Forms.TextBox();
            this.signedEnvelopeOpenSenderPublic = new System.Windows.Forms.TextBox();
            this.signedEnvelopeOpenReceiverPrivate = new System.Windows.Forms.TextBox();
            this.signedEnvelopeOpenEnvelope = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.signedEnvelopeCreateBox = new System.Windows.Forms.GroupBox();
            this.signedEnvelopeCreateBtn = new System.Windows.Forms.Button();
            this.signedEnvelopeCreateSenderPrivateBtn = new System.Windows.Forms.Button();
            this.signedEnvelopeCreateReceiverPublicBtn = new System.Windows.Forms.Button();
            this.signedEnvelopeCreatePlainBtn = new System.Windows.Forms.Button();
            this.signedEnvelopeCreateEnvelope = new System.Windows.Forms.TextBox();
            this.signedEnvelopeCreateSenderPrivate = new System.Windows.Forms.TextBox();
            this.signedEnvelopeCreateReceiverPublic = new System.Windows.Forms.TextBox();
            this.signedEnvelopeCreatePlain = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.aesTab.SuspendLayout();
            this.aesDecryptGroup.SuspendLayout();
            this.aesEncryptGroup.SuspendLayout();
            this.sha1Tab.SuspendLayout();
            this.rsaTab.SuspendLayout();
            this.rsaDecryptBox.SuspendLayout();
            this.rsaEncryptBox.SuspendLayout();
            this.envelopeTab.SuspendLayout();
            this.envelopeDecryptBox.SuspendLayout();
            this.envelopeEncryptBox.SuspendLayout();
            this.signatureTab.SuspendLayout();
            this.signatureVerifyBox.SuspendLayout();
            this.signatureCreateBox.SuspendLayout();
            this.signedEnvelopeTab.SuspendLayout();
            this.signedEnvelopeOpenBox.SuspendLayout();
            this.signedEnvelopeCreateBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.aesTab);
            this.tabControl.Controls.Add(this.sha1Tab);
            this.tabControl.Controls.Add(this.rsaTab);
            this.tabControl.Controls.Add(this.envelopeTab);
            this.tabControl.Controls.Add(this.signatureTab);
            this.tabControl.Controls.Add(this.signedEnvelopeTab);
            this.tabControl.Location = new System.Drawing.Point(3, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(873, 490);
            this.tabControl.TabIndex = 0;
            // 
            // aesTab
            // 
            this.aesTab.Controls.Add(this.aesDecryptGroup);
            this.aesTab.Controls.Add(this.aesEncryptGroup);
            this.aesTab.Location = new System.Drawing.Point(4, 22);
            this.aesTab.Name = "aesTab";
            this.aesTab.Padding = new System.Windows.Forms.Padding(3);
            this.aesTab.Size = new System.Drawing.Size(865, 464);
            this.aesTab.TabIndex = 0;
            this.aesTab.Text = "AES";
            this.aesTab.ToolTipText = "AES algorithm";
            this.aesTab.UseVisualStyleBackColor = true;
            // 
            // aesDecryptGroup
            // 
            this.aesDecryptGroup.Controls.Add(this.aesDecryptCipherBtn);
            this.aesDecryptGroup.Controls.Add(this.aesDecryptChooseIvBtn);
            this.aesDecryptGroup.Controls.Add(this.aesDecryptChooseKeyBtn);
            this.aesDecryptGroup.Controls.Add(this.aesDecryptStartBtn);
            this.aesDecryptGroup.Controls.Add(this.aesDecryptPlainFile);
            this.aesDecryptGroup.Controls.Add(this.aesDecryptCipherFile);
            this.aesDecryptGroup.Controls.Add(this.aesDecryptIvFile);
            this.aesDecryptGroup.Controls.Add(this.aesDecryptKeyFile);
            this.aesDecryptGroup.Controls.Add(this.label5);
            this.aesDecryptGroup.Controls.Add(this.label4);
            this.aesDecryptGroup.Controls.Add(this.label2);
            this.aesDecryptGroup.Controls.Add(this.label1);
            this.aesDecryptGroup.Location = new System.Drawing.Point(16, 226);
            this.aesDecryptGroup.Name = "aesDecryptGroup";
            this.aesDecryptGroup.Size = new System.Drawing.Size(830, 214);
            this.aesDecryptGroup.TabIndex = 1;
            this.aesDecryptGroup.TabStop = false;
            this.aesDecryptGroup.Text = "Decrypt";
            // 
            // aesDecryptCipherBtn
            // 
            this.aesDecryptCipherBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aesDecryptCipherBtn.Location = new System.Drawing.Point(609, 94);
            this.aesDecryptCipherBtn.Name = "aesDecryptCipherBtn";
            this.aesDecryptCipherBtn.Size = new System.Drawing.Size(101, 26);
            this.aesDecryptCipherBtn.TabIndex = 15;
            this.aesDecryptCipherBtn.Text = "Choose file";
            this.aesDecryptCipherBtn.UseVisualStyleBackColor = true;
            this.aesDecryptCipherBtn.Click += new System.EventHandler(this.aesDecryptCipherBtn_Click);
            // 
            // aesDecryptChooseIvBtn
            // 
            this.aesDecryptChooseIvBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aesDecryptChooseIvBtn.Location = new System.Drawing.Point(609, 62);
            this.aesDecryptChooseIvBtn.Name = "aesDecryptChooseIvBtn";
            this.aesDecryptChooseIvBtn.Size = new System.Drawing.Size(101, 26);
            this.aesDecryptChooseIvBtn.TabIndex = 14;
            this.aesDecryptChooseIvBtn.Text = "Choose file";
            this.aesDecryptChooseIvBtn.UseVisualStyleBackColor = true;
            this.aesDecryptChooseIvBtn.Click += new System.EventHandler(this.aesDecryptChooseIvBtn_Click);
            // 
            // aesDecryptChooseKeyBtn
            // 
            this.aesDecryptChooseKeyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aesDecryptChooseKeyBtn.Location = new System.Drawing.Point(609, 25);
            this.aesDecryptChooseKeyBtn.Name = "aesDecryptChooseKeyBtn";
            this.aesDecryptChooseKeyBtn.Size = new System.Drawing.Size(101, 26);
            this.aesDecryptChooseKeyBtn.TabIndex = 13;
            this.aesDecryptChooseKeyBtn.Text = "Choose file";
            this.aesDecryptChooseKeyBtn.UseVisualStyleBackColor = true;
            this.aesDecryptChooseKeyBtn.Click += new System.EventHandler(this.aesDecryptChooseKeyBtn_Click);
            // 
            // aesDecryptStartBtn
            // 
            this.aesDecryptStartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aesDecryptStartBtn.Location = new System.Drawing.Point(355, 160);
            this.aesDecryptStartBtn.Name = "aesDecryptStartBtn";
            this.aesDecryptStartBtn.Size = new System.Drawing.Size(95, 35);
            this.aesDecryptStartBtn.TabIndex = 12;
            this.aesDecryptStartBtn.Text = "Decrypt";
            this.aesDecryptStartBtn.UseVisualStyleBackColor = true;
            this.aesDecryptStartBtn.Click += new System.EventHandler(this.aesDecryptStartBtn_Click);
            // 
            // aesDecryptPlainFile
            // 
            this.aesDecryptPlainFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aesDecryptPlainFile.Location = new System.Drawing.Point(150, 128);
            this.aesDecryptPlainFile.Name = "aesDecryptPlainFile";
            this.aesDecryptPlainFile.Size = new System.Drawing.Size(443, 26);
            this.aesDecryptPlainFile.TabIndex = 11;
            // 
            // aesDecryptCipherFile
            // 
            this.aesDecryptCipherFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aesDecryptCipherFile.Location = new System.Drawing.Point(150, 94);
            this.aesDecryptCipherFile.Name = "aesDecryptCipherFile";
            this.aesDecryptCipherFile.Size = new System.Drawing.Size(443, 26);
            this.aesDecryptCipherFile.TabIndex = 10;
            // 
            // aesDecryptIvFile
            // 
            this.aesDecryptIvFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aesDecryptIvFile.Location = new System.Drawing.Point(150, 62);
            this.aesDecryptIvFile.Name = "aesDecryptIvFile";
            this.aesDecryptIvFile.Size = new System.Drawing.Size(443, 26);
            this.aesDecryptIvFile.TabIndex = 9;
            // 
            // aesDecryptKeyFile
            // 
            this.aesDecryptKeyFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aesDecryptKeyFile.Location = new System.Drawing.Point(150, 25);
            this.aesDecryptKeyFile.Name = "aesDecryptKeyFile";
            this.aesDecryptKeyFile.Size = new System.Drawing.Size(443, 26);
            this.aesDecryptKeyFile.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cipher text file";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(7, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Plain text file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "File containing IV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "File containing key";
            // 
            // aesEncryptGroup
            // 
            this.aesEncryptGroup.Controls.Add(this.aesStartEncryptionBtn);
            this.aesEncryptGroup.Controls.Add(this.aesEncryptPlainChoosBtn);
            this.aesEncryptGroup.Controls.Add(this.aesEncryptIvGenerateBtn);
            this.aesEncryptGroup.Controls.Add(this.aesEncryptIVChooseBtn);
            this.aesEncryptGroup.Controls.Add(this.aesEncryptKeyGenerateBtn);
            this.aesEncryptGroup.Controls.Add(this.aesEncryptKeyChooseBtn);
            this.aesEncryptGroup.Controls.Add(this.aesEncryptCipherFile);
            this.aesEncryptGroup.Controls.Add(this.aesEncryptCipherFileLabel);
            this.aesEncryptGroup.Controls.Add(this.aesEncryptPlainFile);
            this.aesEncryptGroup.Controls.Add(this.aesEncryptIVFile);
            this.aesEncryptGroup.Controls.Add(this.aesEncryptKeyFile);
            this.aesEncryptGroup.Controls.Add(this.label3);
            this.aesEncryptGroup.Controls.Add(this.aesIVLabel);
            this.aesEncryptGroup.Controls.Add(this.aesKeyLabel);
            this.aesEncryptGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aesEncryptGroup.Location = new System.Drawing.Point(16, 20);
            this.aesEncryptGroup.Name = "aesEncryptGroup";
            this.aesEncryptGroup.Size = new System.Drawing.Size(830, 200);
            this.aesEncryptGroup.TabIndex = 0;
            this.aesEncryptGroup.TabStop = false;
            this.aesEncryptGroup.Text = "Encrypt";
            // 
            // aesStartEncryptionBtn
            // 
            this.aesStartEncryptionBtn.Location = new System.Drawing.Point(355, 157);
            this.aesStartEncryptionBtn.Name = "aesStartEncryptionBtn";
            this.aesStartEncryptionBtn.Size = new System.Drawing.Size(95, 37);
            this.aesStartEncryptionBtn.TabIndex = 13;
            this.aesStartEncryptionBtn.Text = "Encrypt";
            this.aesStartEncryptionBtn.UseVisualStyleBackColor = true;
            this.aesStartEncryptionBtn.Click += new System.EventHandler(this.aesStartEncryptionBtn_Click);
            // 
            // aesEncryptPlainChoosBtn
            // 
            this.aesEncryptPlainChoosBtn.Location = new System.Drawing.Point(609, 90);
            this.aesEncryptPlainChoosBtn.Name = "aesEncryptPlainChoosBtn";
            this.aesEncryptPlainChoosBtn.Size = new System.Drawing.Size(101, 25);
            this.aesEncryptPlainChoosBtn.TabIndex = 12;
            this.aesEncryptPlainChoosBtn.Text = "Choose file";
            this.aesEncryptPlainChoosBtn.UseVisualStyleBackColor = true;
            this.aesEncryptPlainChoosBtn.Click += new System.EventHandler(this.aesEncryptPlainChooseBtn_Click);
            // 
            // aesEncryptIvGenerateBtn
            // 
            this.aesEncryptIvGenerateBtn.Location = new System.Drawing.Point(717, 55);
            this.aesEncryptIvGenerateBtn.Name = "aesEncryptIvGenerateBtn";
            this.aesEncryptIvGenerateBtn.Size = new System.Drawing.Size(107, 28);
            this.aesEncryptIvGenerateBtn.TabIndex = 11;
            this.aesEncryptIvGenerateBtn.Text = "Generate";
            this.aesEncryptIvGenerateBtn.UseVisualStyleBackColor = true;
            this.aesEncryptIvGenerateBtn.Click += new System.EventHandler(this.aesEncryptIvGenerateBtn_Click);
            // 
            // aesEncryptIVChooseBtn
            // 
            this.aesEncryptIVChooseBtn.Location = new System.Drawing.Point(609, 55);
            this.aesEncryptIVChooseBtn.Name = "aesEncryptIVChooseBtn";
            this.aesEncryptIVChooseBtn.Size = new System.Drawing.Size(101, 28);
            this.aesEncryptIVChooseBtn.TabIndex = 10;
            this.aesEncryptIVChooseBtn.Text = "Choose file";
            this.aesEncryptIVChooseBtn.UseVisualStyleBackColor = true;
            this.aesEncryptIVChooseBtn.Click += new System.EventHandler(this.aesEncryptIVChooseBtn_Click);
            // 
            // aesEncryptKeyGenerateBtn
            // 
            this.aesEncryptKeyGenerateBtn.Location = new System.Drawing.Point(717, 20);
            this.aesEncryptKeyGenerateBtn.Name = "aesEncryptKeyGenerateBtn";
            this.aesEncryptKeyGenerateBtn.Size = new System.Drawing.Size(107, 26);
            this.aesEncryptKeyGenerateBtn.TabIndex = 9;
            this.aesEncryptKeyGenerateBtn.Text = "Generate";
            this.aesEncryptKeyGenerateBtn.UseVisualStyleBackColor = true;
            this.aesEncryptKeyGenerateBtn.Click += new System.EventHandler(this.aesEncryptKeyGenerateBtn_Click);
            // 
            // aesEncryptKeyChooseBtn
            // 
            this.aesEncryptKeyChooseBtn.Location = new System.Drawing.Point(609, 20);
            this.aesEncryptKeyChooseBtn.Name = "aesEncryptKeyChooseBtn";
            this.aesEncryptKeyChooseBtn.Size = new System.Drawing.Size(101, 26);
            this.aesEncryptKeyChooseBtn.TabIndex = 8;
            this.aesEncryptKeyChooseBtn.Text = "Choose file";
            this.aesEncryptKeyChooseBtn.UseVisualStyleBackColor = true;
            this.aesEncryptKeyChooseBtn.Click += new System.EventHandler(this.aesEncryptKeyChooseBtn_Click);
            // 
            // aesEncryptCipherFile
            // 
            this.aesEncryptCipherFile.Location = new System.Drawing.Point(150, 125);
            this.aesEncryptCipherFile.Name = "aesEncryptCipherFile";
            this.aesEncryptCipherFile.Size = new System.Drawing.Size(443, 26);
            this.aesEncryptCipherFile.TabIndex = 7;
            // 
            // aesEncryptCipherFileLabel
            // 
            this.aesEncryptCipherFileLabel.AutoSize = true;
            this.aesEncryptCipherFileLabel.Location = new System.Drawing.Point(6, 124);
            this.aesEncryptCipherFileLabel.Name = "aesEncryptCipherFileLabel";
            this.aesEncryptCipherFileLabel.Size = new System.Drawing.Size(109, 20);
            this.aesEncryptCipherFileLabel.TabIndex = 6;
            this.aesEncryptCipherFileLabel.Text = "Cipher text file";
            // 
            // aesEncryptPlainFile
            // 
            this.aesEncryptPlainFile.Location = new System.Drawing.Point(150, 89);
            this.aesEncryptPlainFile.Name = "aesEncryptPlainFile";
            this.aesEncryptPlainFile.Size = new System.Drawing.Size(443, 26);
            this.aesEncryptPlainFile.TabIndex = 5;
            // 
            // aesEncryptIVFile
            // 
            this.aesEncryptIVFile.Location = new System.Drawing.Point(150, 55);
            this.aesEncryptIVFile.Name = "aesEncryptIVFile";
            this.aesEncryptIVFile.Size = new System.Drawing.Size(443, 26);
            this.aesEncryptIVFile.TabIndex = 4;
            // 
            // aesEncryptKeyFile
            // 
            this.aesEncryptKeyFile.Location = new System.Drawing.Point(150, 20);
            this.aesEncryptKeyFile.Name = "aesEncryptKeyFile";
            this.aesEncryptKeyFile.Size = new System.Drawing.Size(443, 26);
            this.aesEncryptKeyFile.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(7, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Plain text file";
            // 
            // aesIVLabel
            // 
            this.aesIVLabel.AutoSize = true;
            this.aesIVLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aesIVLabel.Location = new System.Drawing.Point(7, 58);
            this.aesIVLabel.Name = "aesIVLabel";
            this.aesIVLabel.Size = new System.Drawing.Size(127, 18);
            this.aesIVLabel.TabIndex = 1;
            this.aesIVLabel.Text = "File containing IV";
            // 
            // aesKeyLabel
            // 
            this.aesKeyLabel.AutoSize = true;
            this.aesKeyLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aesKeyLabel.Location = new System.Drawing.Point(7, 20);
            this.aesKeyLabel.Name = "aesKeyLabel";
            this.aesKeyLabel.Size = new System.Drawing.Size(137, 18);
            this.aesKeyLabel.TabIndex = 0;
            this.aesKeyLabel.Text = "File containing key";
            // 
            // sha1Tab
            // 
            this.sha1Tab.Controls.Add(this.sha1CalculateHashBtn);
            this.sha1Tab.Controls.Add(this.sha1PlainChooseBtn);
            this.sha1Tab.Controls.Add(this.sha1HashFile);
            this.sha1Tab.Controls.Add(this.label7);
            this.sha1Tab.Controls.Add(this.sha1PlainFile);
            this.sha1Tab.Controls.Add(this.label6);
            this.sha1Tab.Location = new System.Drawing.Point(4, 22);
            this.sha1Tab.Name = "sha1Tab";
            this.sha1Tab.Padding = new System.Windows.Forms.Padding(3);
            this.sha1Tab.Size = new System.Drawing.Size(865, 464);
            this.sha1Tab.TabIndex = 1;
            this.sha1Tab.Text = "SHA-1";
            this.sha1Tab.UseVisualStyleBackColor = true;
            // 
            // sha1CalculateHashBtn
            // 
            this.sha1CalculateHashBtn.Location = new System.Drawing.Point(278, 121);
            this.sha1CalculateHashBtn.Name = "sha1CalculateHashBtn";
            this.sha1CalculateHashBtn.Size = new System.Drawing.Size(142, 30);
            this.sha1CalculateHashBtn.TabIndex = 5;
            this.sha1CalculateHashBtn.Text = "Calculate hash";
            this.sha1CalculateHashBtn.UseVisualStyleBackColor = true;
            this.sha1CalculateHashBtn.Click += new System.EventHandler(this.sha1CalculateHashBtn_Click);
            // 
            // sha1PlainChooseBtn
            // 
            this.sha1PlainChooseBtn.Location = new System.Drawing.Point(625, 23);
            this.sha1PlainChooseBtn.Name = "sha1PlainChooseBtn";
            this.sha1PlainChooseBtn.Size = new System.Drawing.Size(123, 23);
            this.sha1PlainChooseBtn.TabIndex = 4;
            this.sha1PlainChooseBtn.Text = "Choose file";
            this.sha1PlainChooseBtn.UseVisualStyleBackColor = true;
            this.sha1PlainChooseBtn.Click += new System.EventHandler(this.sha1PlainChooseBtn_Click);
            // 
            // sha1HashFile
            // 
            this.sha1HashFile.Location = new System.Drawing.Point(103, 64);
            this.sha1HashFile.Name = "sha1HashFile";
            this.sha1HashFile.Size = new System.Drawing.Size(493, 20);
            this.sha1HashFile.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Hash output file";
            // 
            // sha1PlainFile
            // 
            this.sha1PlainFile.Location = new System.Drawing.Point(103, 23);
            this.sha1PlainFile.Name = "sha1PlainFile";
            this.sha1PlainFile.Size = new System.Drawing.Size(493, 20);
            this.sha1PlainFile.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Plain text file";
            // 
            // rsaTab
            // 
            this.rsaTab.Controls.Add(this.rsaDecryptBox);
            this.rsaTab.Controls.Add(this.rsaEncryptBox);
            this.rsaTab.Controls.Add(this.rsaKeysSize);
            this.rsaTab.Controls.Add(this.label8);
            this.rsaTab.Controls.Add(this.rsaGenerateKeysBtn);
            this.rsaTab.Location = new System.Drawing.Point(4, 22);
            this.rsaTab.Name = "rsaTab";
            this.rsaTab.Padding = new System.Windows.Forms.Padding(3);
            this.rsaTab.Size = new System.Drawing.Size(865, 464);
            this.rsaTab.TabIndex = 2;
            this.rsaTab.Text = "RSA";
            this.rsaTab.UseVisualStyleBackColor = true;
            // 
            // rsaDecryptBox
            // 
            this.rsaDecryptBox.Controls.Add(this.rsaStartDecrypt);
            this.rsaDecryptBox.Controls.Add(this.rsaDecryptPrivateBtn);
            this.rsaDecryptBox.Controls.Add(this.rsaDecryptCipherBtn);
            this.rsaDecryptBox.Controls.Add(this.rsaDecryptPlainFile);
            this.rsaDecryptBox.Controls.Add(this.rsaDecryptPrivateKeyFile);
            this.rsaDecryptBox.Controls.Add(this.rsaDecryptCipherFile);
            this.rsaDecryptBox.Controls.Add(this.label14);
            this.rsaDecryptBox.Controls.Add(this.label13);
            this.rsaDecryptBox.Controls.Add(this.label12);
            this.rsaDecryptBox.Location = new System.Drawing.Point(21, 233);
            this.rsaDecryptBox.Name = "rsaDecryptBox";
            this.rsaDecryptBox.Size = new System.Drawing.Size(838, 203);
            this.rsaDecryptBox.TabIndex = 4;
            this.rsaDecryptBox.TabStop = false;
            this.rsaDecryptBox.Text = "Decrypt";
            // 
            // rsaStartDecrypt
            // 
            this.rsaStartDecrypt.Location = new System.Drawing.Point(378, 143);
            this.rsaStartDecrypt.Name = "rsaStartDecrypt";
            this.rsaStartDecrypt.Size = new System.Drawing.Size(75, 23);
            this.rsaStartDecrypt.TabIndex = 8;
            this.rsaStartDecrypt.Text = "Decrypt";
            this.rsaStartDecrypt.UseVisualStyleBackColor = true;
            this.rsaStartDecrypt.Click += new System.EventHandler(this.rsaStartDecrypt_Click);
            // 
            // rsaDecryptPrivateBtn
            // 
            this.rsaDecryptPrivateBtn.Location = new System.Drawing.Point(654, 67);
            this.rsaDecryptPrivateBtn.Name = "rsaDecryptPrivateBtn";
            this.rsaDecryptPrivateBtn.Size = new System.Drawing.Size(75, 23);
            this.rsaDecryptPrivateBtn.TabIndex = 7;
            this.rsaDecryptPrivateBtn.Text = "Choose file";
            this.rsaDecryptPrivateBtn.UseVisualStyleBackColor = true;
            this.rsaDecryptPrivateBtn.Click += new System.EventHandler(this.rsaDecryptPrivateBtn_Click);
            // 
            // rsaDecryptCipherBtn
            // 
            this.rsaDecryptCipherBtn.Location = new System.Drawing.Point(654, 28);
            this.rsaDecryptCipherBtn.Name = "rsaDecryptCipherBtn";
            this.rsaDecryptCipherBtn.Size = new System.Drawing.Size(75, 23);
            this.rsaDecryptCipherBtn.TabIndex = 6;
            this.rsaDecryptCipherBtn.Text = "Choose file";
            this.rsaDecryptCipherBtn.UseVisualStyleBackColor = true;
            this.rsaDecryptCipherBtn.Click += new System.EventHandler(this.rsaDecryptCipherBtn_Click);
            // 
            // rsaDecryptPlainFile
            // 
            this.rsaDecryptPlainFile.Location = new System.Drawing.Point(104, 94);
            this.rsaDecryptPlainFile.Name = "rsaDecryptPlainFile";
            this.rsaDecryptPlainFile.Size = new System.Drawing.Size(501, 20);
            this.rsaDecryptPlainFile.TabIndex = 5;
            // 
            // rsaDecryptPrivateKeyFile
            // 
            this.rsaDecryptPrivateKeyFile.Location = new System.Drawing.Point(104, 67);
            this.rsaDecryptPrivateKeyFile.Name = "rsaDecryptPrivateKeyFile";
            this.rsaDecryptPrivateKeyFile.Size = new System.Drawing.Size(501, 20);
            this.rsaDecryptPrivateKeyFile.TabIndex = 4;
            // 
            // rsaDecryptCipherFile
            // 
            this.rsaDecryptCipherFile.Location = new System.Drawing.Point(104, 33);
            this.rsaDecryptCipherFile.Name = "rsaDecryptCipherFile";
            this.rsaDecryptCipherFile.Size = new System.Drawing.Size(501, 20);
            this.rsaDecryptCipherFile.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Plain text file";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Private key file";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Cipher file text";
            // 
            // rsaEncryptBox
            // 
            this.rsaEncryptBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rsaEncryptBox.Controls.Add(this.rsaStartEncrypt);
            this.rsaEncryptBox.Controls.Add(this.rsaEncryptPublicBtn);
            this.rsaEncryptBox.Controls.Add(this.rsaEncryptPlainBtn);
            this.rsaEncryptBox.Controls.Add(this.rsaEncryptCipherFile);
            this.rsaEncryptBox.Controls.Add(this.rsaEncryptPublicKey);
            this.rsaEncryptBox.Controls.Add(this.rsaEncryptPlainFile);
            this.rsaEncryptBox.Controls.Add(this.label11);
            this.rsaEncryptBox.Controls.Add(this.label10);
            this.rsaEncryptBox.Controls.Add(this.label9);
            this.rsaEncryptBox.Location = new System.Drawing.Point(21, 61);
            this.rsaEncryptBox.Name = "rsaEncryptBox";
            this.rsaEncryptBox.Size = new System.Drawing.Size(838, 150);
            this.rsaEncryptBox.TabIndex = 3;
            this.rsaEncryptBox.TabStop = false;
            this.rsaEncryptBox.Text = "Encrypt";
            // 
            // rsaStartEncrypt
            // 
            this.rsaStartEncrypt.Location = new System.Drawing.Point(378, 121);
            this.rsaStartEncrypt.Name = "rsaStartEncrypt";
            this.rsaStartEncrypt.Size = new System.Drawing.Size(75, 23);
            this.rsaStartEncrypt.TabIndex = 8;
            this.rsaStartEncrypt.Text = "Encrypt";
            this.rsaStartEncrypt.UseVisualStyleBackColor = true;
            this.rsaStartEncrypt.Click += new System.EventHandler(this.rsaStartEncrypt_Click);
            // 
            // rsaEncryptPublicBtn
            // 
            this.rsaEncryptPublicBtn.Location = new System.Drawing.Point(654, 48);
            this.rsaEncryptPublicBtn.Name = "rsaEncryptPublicBtn";
            this.rsaEncryptPublicBtn.Size = new System.Drawing.Size(75, 23);
            this.rsaEncryptPublicBtn.TabIndex = 7;
            this.rsaEncryptPublicBtn.Text = "Choose file";
            this.rsaEncryptPublicBtn.UseVisualStyleBackColor = true;
            this.rsaEncryptPublicBtn.Click += new System.EventHandler(this.rsaEncryptPublicBtn_Click);
            // 
            // rsaEncryptPlainBtn
            // 
            this.rsaEncryptPlainBtn.Location = new System.Drawing.Point(654, 14);
            this.rsaEncryptPlainBtn.Name = "rsaEncryptPlainBtn";
            this.rsaEncryptPlainBtn.Size = new System.Drawing.Size(75, 23);
            this.rsaEncryptPlainBtn.TabIndex = 6;
            this.rsaEncryptPlainBtn.Text = "Choose file";
            this.rsaEncryptPlainBtn.UseVisualStyleBackColor = true;
            this.rsaEncryptPlainBtn.Click += new System.EventHandler(this.rsaEncryptPlainBtn_Click);
            // 
            // rsaEncryptCipherFile
            // 
            this.rsaEncryptCipherFile.Location = new System.Drawing.Point(104, 82);
            this.rsaEncryptCipherFile.Name = "rsaEncryptCipherFile";
            this.rsaEncryptCipherFile.Size = new System.Drawing.Size(501, 20);
            this.rsaEncryptCipherFile.TabIndex = 5;
            // 
            // rsaEncryptPublicKey
            // 
            this.rsaEncryptPublicKey.Location = new System.Drawing.Point(104, 48);
            this.rsaEncryptPublicKey.Name = "rsaEncryptPublicKey";
            this.rsaEncryptPublicKey.Size = new System.Drawing.Size(501, 20);
            this.rsaEncryptPublicKey.TabIndex = 4;
            // 
            // rsaEncryptPlainFile
            // 
            this.rsaEncryptPlainFile.Location = new System.Drawing.Point(104, 17);
            this.rsaEncryptPlainFile.Name = "rsaEncryptPlainFile";
            this.rsaEncryptPlainFile.Size = new System.Drawing.Size(501, 20);
            this.rsaEncryptPlainFile.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Cipher text file";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Public key file";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Plain text file";
            // 
            // rsaKeysSize
            // 
            this.rsaKeysSize.Location = new System.Drawing.Point(88, 27);
            this.rsaKeysSize.Name = "rsaKeysSize";
            this.rsaKeysSize.Size = new System.Drawing.Size(120, 20);
            this.rsaKeysSize.TabIndex = 2;
            this.rsaKeysSize.Text = "1024";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Keys size";
            // 
            // rsaGenerateKeysBtn
            // 
            this.rsaGenerateKeysBtn.Location = new System.Drawing.Point(359, 22);
            this.rsaGenerateKeysBtn.Name = "rsaGenerateKeysBtn";
            this.rsaGenerateKeysBtn.Size = new System.Drawing.Size(115, 23);
            this.rsaGenerateKeysBtn.TabIndex = 0;
            this.rsaGenerateKeysBtn.Text = "Generate keys";
            this.rsaGenerateKeysBtn.UseVisualStyleBackColor = true;
            this.rsaGenerateKeysBtn.Click += new System.EventHandler(this.rsaGenerateKeysBtn_Click);
            // 
            // envelopeTab
            // 
            this.envelopeTab.Controls.Add(this.envelopeDecryptBox);
            this.envelopeTab.Controls.Add(this.envelopeEncryptBox);
            this.envelopeTab.Location = new System.Drawing.Point(4, 22);
            this.envelopeTab.Name = "envelopeTab";
            this.envelopeTab.Padding = new System.Windows.Forms.Padding(3);
            this.envelopeTab.Size = new System.Drawing.Size(865, 464);
            this.envelopeTab.TabIndex = 3;
            this.envelopeTab.Text = "Envelope";
            this.envelopeTab.UseVisualStyleBackColor = true;
            // 
            // envelopeDecryptBox
            // 
            this.envelopeDecryptBox.Controls.Add(this.envelopeDecryptStartBtn);
            this.envelopeDecryptBox.Controls.Add(this.envelopeDecryptprivateBtn);
            this.envelopeDecryptBox.Controls.Add(this.envelopeDecryptEnvelopeBtn);
            this.envelopeDecryptBox.Controls.Add(this.envelopeDecryptPlain);
            this.envelopeDecryptBox.Controls.Add(this.envelopeDecryptPrivate);
            this.envelopeDecryptBox.Controls.Add(this.envelopeDecryptEnvelope);
            this.envelopeDecryptBox.Controls.Add(this.label20);
            this.envelopeDecryptBox.Controls.Add(this.label19);
            this.envelopeDecryptBox.Controls.Add(this.label18);
            this.envelopeDecryptBox.Location = new System.Drawing.Point(15, 199);
            this.envelopeDecryptBox.Name = "envelopeDecryptBox";
            this.envelopeDecryptBox.Size = new System.Drawing.Size(831, 170);
            this.envelopeDecryptBox.TabIndex = 1;
            this.envelopeDecryptBox.TabStop = false;
            this.envelopeDecryptBox.Text = "Decrypt";
            // 
            // envelopeDecryptStartBtn
            // 
            this.envelopeDecryptStartBtn.Location = new System.Drawing.Point(392, 130);
            this.envelopeDecryptStartBtn.Name = "envelopeDecryptStartBtn";
            this.envelopeDecryptStartBtn.Size = new System.Drawing.Size(116, 23);
            this.envelopeDecryptStartBtn.TabIndex = 8;
            this.envelopeDecryptStartBtn.Text = "Read envelope";
            this.envelopeDecryptStartBtn.UseVisualStyleBackColor = true;
            this.envelopeDecryptStartBtn.Click += new System.EventHandler(this.envelopeDecryptStartBtn_Click);
            // 
            // envelopeDecryptprivateBtn
            // 
            this.envelopeDecryptprivateBtn.Location = new System.Drawing.Point(714, 59);
            this.envelopeDecryptprivateBtn.Name = "envelopeDecryptprivateBtn";
            this.envelopeDecryptprivateBtn.Size = new System.Drawing.Size(75, 23);
            this.envelopeDecryptprivateBtn.TabIndex = 7;
            this.envelopeDecryptprivateBtn.Text = "Choose file";
            this.envelopeDecryptprivateBtn.UseVisualStyleBackColor = true;
            this.envelopeDecryptprivateBtn.Click += new System.EventHandler(this.envelopeDecryptprivateBtn_Click);
            // 
            // envelopeDecryptEnvelopeBtn
            // 
            this.envelopeDecryptEnvelopeBtn.Location = new System.Drawing.Point(714, 27);
            this.envelopeDecryptEnvelopeBtn.Name = "envelopeDecryptEnvelopeBtn";
            this.envelopeDecryptEnvelopeBtn.Size = new System.Drawing.Size(75, 23);
            this.envelopeDecryptEnvelopeBtn.TabIndex = 6;
            this.envelopeDecryptEnvelopeBtn.Text = "Choose file";
            this.envelopeDecryptEnvelopeBtn.UseVisualStyleBackColor = true;
            this.envelopeDecryptEnvelopeBtn.Click += new System.EventHandler(this.envelopeDecryptEnvelopeBtn_Click);
            // 
            // envelopeDecryptPlain
            // 
            this.envelopeDecryptPlain.Location = new System.Drawing.Point(107, 95);
            this.envelopeDecryptPlain.Name = "envelopeDecryptPlain";
            this.envelopeDecryptPlain.Size = new System.Drawing.Size(582, 20);
            this.envelopeDecryptPlain.TabIndex = 5;
            // 
            // envelopeDecryptPrivate
            // 
            this.envelopeDecryptPrivate.Location = new System.Drawing.Point(107, 62);
            this.envelopeDecryptPrivate.Name = "envelopeDecryptPrivate";
            this.envelopeDecryptPrivate.Size = new System.Drawing.Size(582, 20);
            this.envelopeDecryptPrivate.TabIndex = 4;
            // 
            // envelopeDecryptEnvelope
            // 
            this.envelopeDecryptEnvelope.Location = new System.Drawing.Point(107, 30);
            this.envelopeDecryptEnvelope.Name = "envelopeDecryptEnvelope";
            this.envelopeDecryptEnvelope.Size = new System.Drawing.Size(582, 20);
            this.envelopeDecryptEnvelope.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 95);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Plain text file";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 62);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Private key file";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Envelope file";
            // 
            // envelopeEncryptBox
            // 
            this.envelopeEncryptBox.Controls.Add(this.envelopeEncryptStart);
            this.envelopeEncryptBox.Controls.Add(this.envelopeEncryptPublicBtn);
            this.envelopeEncryptBox.Controls.Add(this.envelopeEncryptPlainBtn);
            this.envelopeEncryptBox.Controls.Add(this.envelopeEncryptEnvelope);
            this.envelopeEncryptBox.Controls.Add(this.label17);
            this.envelopeEncryptBox.Controls.Add(this.envelopeEncryptPublic);
            this.envelopeEncryptBox.Controls.Add(this.label16);
            this.envelopeEncryptBox.Controls.Add(this.envelopeEncryptPlain);
            this.envelopeEncryptBox.Controls.Add(this.label15);
            this.envelopeEncryptBox.Location = new System.Drawing.Point(15, 19);
            this.envelopeEncryptBox.Name = "envelopeEncryptBox";
            this.envelopeEncryptBox.Size = new System.Drawing.Size(831, 148);
            this.envelopeEncryptBox.TabIndex = 0;
            this.envelopeEncryptBox.TabStop = false;
            this.envelopeEncryptBox.Text = "Encrypt";
            // 
            // envelopeEncryptStart
            // 
            this.envelopeEncryptStart.Location = new System.Drawing.Point(402, 110);
            this.envelopeEncryptStart.Name = "envelopeEncryptStart";
            this.envelopeEncryptStart.Size = new System.Drawing.Size(106, 23);
            this.envelopeEncryptStart.TabIndex = 8;
            this.envelopeEncryptStart.Text = "Create envelope";
            this.envelopeEncryptStart.UseVisualStyleBackColor = true;
            this.envelopeEncryptStart.Click += new System.EventHandler(this.envelopeEncryptStart_Click);
            // 
            // envelopeEncryptPublicBtn
            // 
            this.envelopeEncryptPublicBtn.Location = new System.Drawing.Point(714, 57);
            this.envelopeEncryptPublicBtn.Name = "envelopeEncryptPublicBtn";
            this.envelopeEncryptPublicBtn.Size = new System.Drawing.Size(75, 23);
            this.envelopeEncryptPublicBtn.TabIndex = 7;
            this.envelopeEncryptPublicBtn.Text = "Choose file";
            this.envelopeEncryptPublicBtn.UseVisualStyleBackColor = true;
            this.envelopeEncryptPublicBtn.Click += new System.EventHandler(this.envelopeEncryptPublicBtn_Click);
            // 
            // envelopeEncryptPlainBtn
            // 
            this.envelopeEncryptPlainBtn.Location = new System.Drawing.Point(714, 29);
            this.envelopeEncryptPlainBtn.Name = "envelopeEncryptPlainBtn";
            this.envelopeEncryptPlainBtn.Size = new System.Drawing.Size(75, 23);
            this.envelopeEncryptPlainBtn.TabIndex = 6;
            this.envelopeEncryptPlainBtn.Text = "Choose file";
            this.envelopeEncryptPlainBtn.UseVisualStyleBackColor = true;
            this.envelopeEncryptPlainBtn.Click += new System.EventHandler(this.envelopeEncryptPlainBtn_Click);
            // 
            // envelopeEncryptEnvelope
            // 
            this.envelopeEncryptEnvelope.Location = new System.Drawing.Point(107, 84);
            this.envelopeEncryptEnvelope.Name = "envelopeEncryptEnvelope";
            this.envelopeEncryptEnvelope.Size = new System.Drawing.Size(582, 20);
            this.envelopeEncryptEnvelope.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 84);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Envelope file";
            // 
            // envelopeEncryptPublic
            // 
            this.envelopeEncryptPublic.Location = new System.Drawing.Point(107, 57);
            this.envelopeEncryptPublic.Name = "envelopeEncryptPublic";
            this.envelopeEncryptPublic.Size = new System.Drawing.Size(582, 20);
            this.envelopeEncryptPublic.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Public key file";
            // 
            // envelopeEncryptPlain
            // 
            this.envelopeEncryptPlain.Location = new System.Drawing.Point(107, 29);
            this.envelopeEncryptPlain.Name = "envelopeEncryptPlain";
            this.envelopeEncryptPlain.Size = new System.Drawing.Size(582, 20);
            this.envelopeEncryptPlain.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Plain text file";
            // 
            // signatureTab
            // 
            this.signatureTab.Controls.Add(this.signatureVerifyBox);
            this.signatureTab.Controls.Add(this.signatureCreateBox);
            this.signatureTab.Location = new System.Drawing.Point(4, 22);
            this.signatureTab.Name = "signatureTab";
            this.signatureTab.Padding = new System.Windows.Forms.Padding(3);
            this.signatureTab.Size = new System.Drawing.Size(865, 464);
            this.signatureTab.TabIndex = 4;
            this.signatureTab.Text = "Signature";
            this.signatureTab.UseVisualStyleBackColor = true;
            // 
            // signatureVerifyBox
            // 
            this.signatureVerifyBox.Controls.Add(this.signatureVerifyBtn);
            this.signatureVerifyBox.Controls.Add(this.signatureVerifyPublicBtn);
            this.signatureVerifyBox.Controls.Add(this.signatureVerifySignatureBtn);
            this.signatureVerifyBox.Controls.Add(this.signatureVerifyPublicKey);
            this.signatureVerifyBox.Controls.Add(this.signatureVerifySignatureFile);
            this.signatureVerifyBox.Controls.Add(this.label25);
            this.signatureVerifyBox.Controls.Add(this.label24);
            this.signatureVerifyBox.Location = new System.Drawing.Point(19, 202);
            this.signatureVerifyBox.Name = "signatureVerifyBox";
            this.signatureVerifyBox.Size = new System.Drawing.Size(840, 121);
            this.signatureVerifyBox.TabIndex = 1;
            this.signatureVerifyBox.TabStop = false;
            this.signatureVerifyBox.Text = "Verify";
            // 
            // signatureVerifyBtn
            // 
            this.signatureVerifyBtn.Location = new System.Drawing.Point(427, 82);
            this.signatureVerifyBtn.Name = "signatureVerifyBtn";
            this.signatureVerifyBtn.Size = new System.Drawing.Size(75, 23);
            this.signatureVerifyBtn.TabIndex = 6;
            this.signatureVerifyBtn.Text = "Verify";
            this.signatureVerifyBtn.UseVisualStyleBackColor = true;
            this.signatureVerifyBtn.Click += new System.EventHandler(this.signatureVerifyBtn_Click);
            // 
            // signatureVerifyPublicBtn
            // 
            this.signatureVerifyPublicBtn.Location = new System.Drawing.Point(723, 47);
            this.signatureVerifyPublicBtn.Name = "signatureVerifyPublicBtn";
            this.signatureVerifyPublicBtn.Size = new System.Drawing.Size(75, 23);
            this.signatureVerifyPublicBtn.TabIndex = 5;
            this.signatureVerifyPublicBtn.Text = "Choose file";
            this.signatureVerifyPublicBtn.UseVisualStyleBackColor = true;
            this.signatureVerifyPublicBtn.Click += new System.EventHandler(this.signatureVerifyPublicBtn_Click);
            // 
            // signatureVerifySignatureBtn
            // 
            this.signatureVerifySignatureBtn.Location = new System.Drawing.Point(723, 15);
            this.signatureVerifySignatureBtn.Name = "signatureVerifySignatureBtn";
            this.signatureVerifySignatureBtn.Size = new System.Drawing.Size(75, 23);
            this.signatureVerifySignatureBtn.TabIndex = 4;
            this.signatureVerifySignatureBtn.Text = "Choose file";
            this.signatureVerifySignatureBtn.UseVisualStyleBackColor = true;
            this.signatureVerifySignatureBtn.Click += new System.EventHandler(this.signatureVerifySignatureBtn_Click);
            // 
            // signatureVerifyPublicKey
            // 
            this.signatureVerifyPublicKey.Location = new System.Drawing.Point(127, 47);
            this.signatureVerifyPublicKey.Name = "signatureVerifyPublicKey";
            this.signatureVerifyPublicKey.Size = new System.Drawing.Size(577, 20);
            this.signatureVerifyPublicKey.TabIndex = 3;
            // 
            // signatureVerifySignatureFile
            // 
            this.signatureVerifySignatureFile.Location = new System.Drawing.Point(127, 20);
            this.signatureVerifySignatureFile.Name = "signatureVerifySignatureFile";
            this.signatureVerifySignatureFile.Size = new System.Drawing.Size(577, 20);
            this.signatureVerifySignatureFile.TabIndex = 2;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(10, 47);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(108, 13);
            this.label25.TabIndex = 1;
            this.label25.Text = "Sender public key file";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(10, 20);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Signature file";
            // 
            // signatureCreateBox
            // 
            this.signatureCreateBox.Controls.Add(this.signatureCreateSignature);
            this.signatureCreateBox.Controls.Add(this.signatureSignPrivateBtn);
            this.signatureCreateBox.Controls.Add(this.signatureSignPlainBtn);
            this.signatureCreateBox.Controls.Add(this.signatureSignSignature);
            this.signatureCreateBox.Controls.Add(this.signatureSignPrivateKey);
            this.signatureCreateBox.Controls.Add(this.signatureSignPlain);
            this.signatureCreateBox.Controls.Add(this.label23);
            this.signatureCreateBox.Controls.Add(this.label22);
            this.signatureCreateBox.Controls.Add(this.label21);
            this.signatureCreateBox.Location = new System.Drawing.Point(19, 16);
            this.signatureCreateBox.Name = "signatureCreateBox";
            this.signatureCreateBox.Size = new System.Drawing.Size(840, 144);
            this.signatureCreateBox.TabIndex = 0;
            this.signatureCreateBox.TabStop = false;
            this.signatureCreateBox.Text = "Sign";
            // 
            // signatureCreateSignature
            // 
            this.signatureCreateSignature.Location = new System.Drawing.Point(427, 109);
            this.signatureCreateSignature.Name = "signatureCreateSignature";
            this.signatureCreateSignature.Size = new System.Drawing.Size(91, 23);
            this.signatureCreateSignature.TabIndex = 8;
            this.signatureCreateSignature.Text = "Sign message";
            this.signatureCreateSignature.UseVisualStyleBackColor = true;
            this.signatureCreateSignature.Click += new System.EventHandler(this.signatureCreateSignature_Click);
            // 
            // signatureSignPrivateBtn
            // 
            this.signatureSignPrivateBtn.Location = new System.Drawing.Point(723, 49);
            this.signatureSignPrivateBtn.Name = "signatureSignPrivateBtn";
            this.signatureSignPrivateBtn.Size = new System.Drawing.Size(75, 23);
            this.signatureSignPrivateBtn.TabIndex = 7;
            this.signatureSignPrivateBtn.Text = "Choose file";
            this.signatureSignPrivateBtn.UseVisualStyleBackColor = true;
            this.signatureSignPrivateBtn.Click += new System.EventHandler(this.signatureSignPrivateBtn_Click);
            // 
            // signatureSignPlainBtn
            // 
            this.signatureSignPlainBtn.Location = new System.Drawing.Point(723, 20);
            this.signatureSignPlainBtn.Name = "signatureSignPlainBtn";
            this.signatureSignPlainBtn.Size = new System.Drawing.Size(75, 23);
            this.signatureSignPlainBtn.TabIndex = 6;
            this.signatureSignPlainBtn.Text = "Choose file";
            this.signatureSignPlainBtn.UseVisualStyleBackColor = true;
            this.signatureSignPlainBtn.Click += new System.EventHandler(this.signatureSignPlainBtn_Click);
            // 
            // signatureSignSignature
            // 
            this.signatureSignSignature.Location = new System.Drawing.Point(127, 83);
            this.signatureSignSignature.Name = "signatureSignSignature";
            this.signatureSignSignature.Size = new System.Drawing.Size(577, 20);
            this.signatureSignSignature.TabIndex = 5;
            // 
            // signatureSignPrivateKey
            // 
            this.signatureSignPrivateKey.Location = new System.Drawing.Point(127, 48);
            this.signatureSignPrivateKey.Name = "signatureSignPrivateKey";
            this.signatureSignPrivateKey.Size = new System.Drawing.Size(577, 20);
            this.signatureSignPrivateKey.TabIndex = 4;
            // 
            // signatureSignPlain
            // 
            this.signatureSignPlain.Location = new System.Drawing.Point(127, 20);
            this.signatureSignPlain.Name = "signatureSignPlain";
            this.signatureSignPlain.Size = new System.Drawing.Size(577, 20);
            this.signatureSignPlain.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 83);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(98, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Digital signature file";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 48);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(112, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "Sender private key file";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Plain text file";
            // 
            // signedEnvelopeTab
            // 
            this.signedEnvelopeTab.Controls.Add(this.signedEnvelopeOpenBox);
            this.signedEnvelopeTab.Controls.Add(this.signedEnvelopeCreateBox);
            this.signedEnvelopeTab.Location = new System.Drawing.Point(4, 22);
            this.signedEnvelopeTab.Name = "signedEnvelopeTab";
            this.signedEnvelopeTab.Padding = new System.Windows.Forms.Padding(3);
            this.signedEnvelopeTab.Size = new System.Drawing.Size(865, 464);
            this.signedEnvelopeTab.TabIndex = 5;
            this.signedEnvelopeTab.Text = "Signed envelope";
            this.signedEnvelopeTab.UseVisualStyleBackColor = true;
            // 
            // signedEnvelopeOpenBox
            // 
            this.signedEnvelopeOpenBox.Controls.Add(this.signedEnvelopeOpenBtn);
            this.signedEnvelopeOpenBox.Controls.Add(this.signedEnvelopeOpenSenderPublicBtn);
            this.signedEnvelopeOpenBox.Controls.Add(this.signedEnvelopeOpenReceiverPrivateBtn);
            this.signedEnvelopeOpenBox.Controls.Add(this.signedEnvelopeOpenEnvelopeBtn);
            this.signedEnvelopeOpenBox.Controls.Add(this.signedEnvelopeOpenPlain);
            this.signedEnvelopeOpenBox.Controls.Add(this.signedEnvelopeOpenSenderPublic);
            this.signedEnvelopeOpenBox.Controls.Add(this.signedEnvelopeOpenReceiverPrivate);
            this.signedEnvelopeOpenBox.Controls.Add(this.signedEnvelopeOpenEnvelope);
            this.signedEnvelopeOpenBox.Controls.Add(this.label33);
            this.signedEnvelopeOpenBox.Controls.Add(this.label32);
            this.signedEnvelopeOpenBox.Controls.Add(this.label31);
            this.signedEnvelopeOpenBox.Controls.Add(this.label30);
            this.signedEnvelopeOpenBox.Location = new System.Drawing.Point(19, 215);
            this.signedEnvelopeOpenBox.Name = "signedEnvelopeOpenBox";
            this.signedEnvelopeOpenBox.Size = new System.Drawing.Size(840, 187);
            this.signedEnvelopeOpenBox.TabIndex = 1;
            this.signedEnvelopeOpenBox.TabStop = false;
            this.signedEnvelopeOpenBox.Text = "Open";
            // 
            // signedEnvelopeOpenBtn
            // 
            this.signedEnvelopeOpenBtn.Location = new System.Drawing.Point(419, 147);
            this.signedEnvelopeOpenBtn.Name = "signedEnvelopeOpenBtn";
            this.signedEnvelopeOpenBtn.Size = new System.Drawing.Size(75, 23);
            this.signedEnvelopeOpenBtn.TabIndex = 22;
            this.signedEnvelopeOpenBtn.Text = "Open";
            this.signedEnvelopeOpenBtn.UseVisualStyleBackColor = true;
            this.signedEnvelopeOpenBtn.Click += new System.EventHandler(this.signedEnvelopeOpenBtn_Click);
            // 
            // signedEnvelopeOpenSenderPublicBtn
            // 
            this.signedEnvelopeOpenSenderPublicBtn.Location = new System.Drawing.Point(738, 83);
            this.signedEnvelopeOpenSenderPublicBtn.Name = "signedEnvelopeOpenSenderPublicBtn";
            this.signedEnvelopeOpenSenderPublicBtn.Size = new System.Drawing.Size(75, 23);
            this.signedEnvelopeOpenSenderPublicBtn.TabIndex = 21;
            this.signedEnvelopeOpenSenderPublicBtn.Text = "Choose file";
            this.signedEnvelopeOpenSenderPublicBtn.UseVisualStyleBackColor = true;
            this.signedEnvelopeOpenSenderPublicBtn.Click += new System.EventHandler(this.signedEnvelopeOpenSenderPublicBtn_Click);
            // 
            // signedEnvelopeOpenReceiverPrivateBtn
            // 
            this.signedEnvelopeOpenReceiverPrivateBtn.Location = new System.Drawing.Point(738, 50);
            this.signedEnvelopeOpenReceiverPrivateBtn.Name = "signedEnvelopeOpenReceiverPrivateBtn";
            this.signedEnvelopeOpenReceiverPrivateBtn.Size = new System.Drawing.Size(75, 23);
            this.signedEnvelopeOpenReceiverPrivateBtn.TabIndex = 20;
            this.signedEnvelopeOpenReceiverPrivateBtn.Text = "Choose file";
            this.signedEnvelopeOpenReceiverPrivateBtn.UseVisualStyleBackColor = true;
            this.signedEnvelopeOpenReceiverPrivateBtn.Click += new System.EventHandler(this.signedEnvelopeOpenReceiverPrivateBtn_Click);
            // 
            // signedEnvelopeOpenEnvelopeBtn
            // 
            this.signedEnvelopeOpenEnvelopeBtn.Location = new System.Drawing.Point(738, 19);
            this.signedEnvelopeOpenEnvelopeBtn.Name = "signedEnvelopeOpenEnvelopeBtn";
            this.signedEnvelopeOpenEnvelopeBtn.Size = new System.Drawing.Size(75, 23);
            this.signedEnvelopeOpenEnvelopeBtn.TabIndex = 19;
            this.signedEnvelopeOpenEnvelopeBtn.Text = "Choose file";
            this.signedEnvelopeOpenEnvelopeBtn.UseVisualStyleBackColor = true;
            this.signedEnvelopeOpenEnvelopeBtn.Click += new System.EventHandler(this.signedEnvelopeOpenEnvelopeBtn_Click);
            // 
            // signedEnvelopeOpenPlain
            // 
            this.signedEnvelopeOpenPlain.Location = new System.Drawing.Point(142, 117);
            this.signedEnvelopeOpenPlain.Name = "signedEnvelopeOpenPlain";
            this.signedEnvelopeOpenPlain.Size = new System.Drawing.Size(576, 20);
            this.signedEnvelopeOpenPlain.TabIndex = 18;
            // 
            // signedEnvelopeOpenSenderPublic
            // 
            this.signedEnvelopeOpenSenderPublic.Location = new System.Drawing.Point(142, 83);
            this.signedEnvelopeOpenSenderPublic.Name = "signedEnvelopeOpenSenderPublic";
            this.signedEnvelopeOpenSenderPublic.Size = new System.Drawing.Size(576, 20);
            this.signedEnvelopeOpenSenderPublic.TabIndex = 17;
            // 
            // signedEnvelopeOpenReceiverPrivate
            // 
            this.signedEnvelopeOpenReceiverPrivate.Location = new System.Drawing.Point(142, 55);
            this.signedEnvelopeOpenReceiverPrivate.Name = "signedEnvelopeOpenReceiverPrivate";
            this.signedEnvelopeOpenReceiverPrivate.Size = new System.Drawing.Size(576, 20);
            this.signedEnvelopeOpenReceiverPrivate.TabIndex = 16;
            // 
            // signedEnvelopeOpenEnvelope
            // 
            this.signedEnvelopeOpenEnvelope.Location = new System.Drawing.Point(142, 28);
            this.signedEnvelopeOpenEnvelope.Name = "signedEnvelopeOpenEnvelope";
            this.signedEnvelopeOpenEnvelope.Size = new System.Drawing.Size(576, 20);
            this.signedEnvelopeOpenEnvelope.TabIndex = 15;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(16, 83);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(92, 13);
            this.label33.TabIndex = 14;
            this.label33.Text = "Sender public key";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(16, 55);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(105, 13);
            this.label32.TabIndex = 13;
            this.label32.Text = "Receiver private key";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(16, 28);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(103, 13);
            this.label31.TabIndex = 12;
            this.label31.Text = "Signed envelope file";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(16, 117);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(66, 13);
            this.label30.TabIndex = 1;
            this.label30.Text = "Plain text file";
            // 
            // signedEnvelopeCreateBox
            // 
            this.signedEnvelopeCreateBox.Controls.Add(this.signedEnvelopeCreateBtn);
            this.signedEnvelopeCreateBox.Controls.Add(this.signedEnvelopeCreateSenderPrivateBtn);
            this.signedEnvelopeCreateBox.Controls.Add(this.signedEnvelopeCreateReceiverPublicBtn);
            this.signedEnvelopeCreateBox.Controls.Add(this.signedEnvelopeCreatePlainBtn);
            this.signedEnvelopeCreateBox.Controls.Add(this.signedEnvelopeCreateEnvelope);
            this.signedEnvelopeCreateBox.Controls.Add(this.signedEnvelopeCreateSenderPrivate);
            this.signedEnvelopeCreateBox.Controls.Add(this.signedEnvelopeCreateReceiverPublic);
            this.signedEnvelopeCreateBox.Controls.Add(this.signedEnvelopeCreatePlain);
            this.signedEnvelopeCreateBox.Controls.Add(this.label29);
            this.signedEnvelopeCreateBox.Controls.Add(this.label28);
            this.signedEnvelopeCreateBox.Controls.Add(this.label27);
            this.signedEnvelopeCreateBox.Controls.Add(this.label26);
            this.signedEnvelopeCreateBox.Location = new System.Drawing.Point(19, 22);
            this.signedEnvelopeCreateBox.Name = "signedEnvelopeCreateBox";
            this.signedEnvelopeCreateBox.Size = new System.Drawing.Size(840, 166);
            this.signedEnvelopeCreateBox.TabIndex = 0;
            this.signedEnvelopeCreateBox.TabStop = false;
            this.signedEnvelopeCreateBox.Text = "Create";
            // 
            // signedEnvelopeCreateBtn
            // 
            this.signedEnvelopeCreateBtn.Location = new System.Drawing.Point(419, 132);
            this.signedEnvelopeCreateBtn.Name = "signedEnvelopeCreateBtn";
            this.signedEnvelopeCreateBtn.Size = new System.Drawing.Size(75, 23);
            this.signedEnvelopeCreateBtn.TabIndex = 11;
            this.signedEnvelopeCreateBtn.Text = "Create";
            this.signedEnvelopeCreateBtn.UseVisualStyleBackColor = true;
            this.signedEnvelopeCreateBtn.Click += new System.EventHandler(this.signedEnvelopeCreateBtn_Click);
            // 
            // signedEnvelopeCreateSenderPrivateBtn
            // 
            this.signedEnvelopeCreateSenderPrivateBtn.Location = new System.Drawing.Point(738, 75);
            this.signedEnvelopeCreateSenderPrivateBtn.Name = "signedEnvelopeCreateSenderPrivateBtn";
            this.signedEnvelopeCreateSenderPrivateBtn.Size = new System.Drawing.Size(75, 23);
            this.signedEnvelopeCreateSenderPrivateBtn.TabIndex = 10;
            this.signedEnvelopeCreateSenderPrivateBtn.Text = "Choose file";
            this.signedEnvelopeCreateSenderPrivateBtn.UseVisualStyleBackColor = true;
            this.signedEnvelopeCreateSenderPrivateBtn.Click += new System.EventHandler(this.signedEnvelopeCreateSenderPrivateBtn_Click);
            // 
            // signedEnvelopeCreateReceiverPublicBtn
            // 
            this.signedEnvelopeCreateReceiverPublicBtn.Location = new System.Drawing.Point(738, 48);
            this.signedEnvelopeCreateReceiverPublicBtn.Name = "signedEnvelopeCreateReceiverPublicBtn";
            this.signedEnvelopeCreateReceiverPublicBtn.Size = new System.Drawing.Size(75, 23);
            this.signedEnvelopeCreateReceiverPublicBtn.TabIndex = 9;
            this.signedEnvelopeCreateReceiverPublicBtn.Text = "Choose file";
            this.signedEnvelopeCreateReceiverPublicBtn.UseVisualStyleBackColor = true;
            this.signedEnvelopeCreateReceiverPublicBtn.Click += new System.EventHandler(this.signedEnvelopeCreateReceiverPublicBtn_Click);
            // 
            // signedEnvelopeCreatePlainBtn
            // 
            this.signedEnvelopeCreatePlainBtn.Location = new System.Drawing.Point(738, 18);
            this.signedEnvelopeCreatePlainBtn.Name = "signedEnvelopeCreatePlainBtn";
            this.signedEnvelopeCreatePlainBtn.Size = new System.Drawing.Size(75, 23);
            this.signedEnvelopeCreatePlainBtn.TabIndex = 8;
            this.signedEnvelopeCreatePlainBtn.Text = "Choose file";
            this.signedEnvelopeCreatePlainBtn.UseVisualStyleBackColor = true;
            this.signedEnvelopeCreatePlainBtn.Click += new System.EventHandler(this.signedEnvelopeCreatePlainBtn_Click);
            // 
            // signedEnvelopeCreateEnvelope
            // 
            this.signedEnvelopeCreateEnvelope.Location = new System.Drawing.Point(142, 106);
            this.signedEnvelopeCreateEnvelope.Name = "signedEnvelopeCreateEnvelope";
            this.signedEnvelopeCreateEnvelope.Size = new System.Drawing.Size(576, 20);
            this.signedEnvelopeCreateEnvelope.TabIndex = 7;
            // 
            // signedEnvelopeCreateSenderPrivate
            // 
            this.signedEnvelopeCreateSenderPrivate.Location = new System.Drawing.Point(142, 75);
            this.signedEnvelopeCreateSenderPrivate.Name = "signedEnvelopeCreateSenderPrivate";
            this.signedEnvelopeCreateSenderPrivate.Size = new System.Drawing.Size(576, 20);
            this.signedEnvelopeCreateSenderPrivate.TabIndex = 6;
            // 
            // signedEnvelopeCreateReceiverPublic
            // 
            this.signedEnvelopeCreateReceiverPublic.Location = new System.Drawing.Point(142, 48);
            this.signedEnvelopeCreateReceiverPublic.Name = "signedEnvelopeCreateReceiverPublic";
            this.signedEnvelopeCreateReceiverPublic.Size = new System.Drawing.Size(576, 20);
            this.signedEnvelopeCreateReceiverPublic.TabIndex = 5;
            // 
            // signedEnvelopeCreatePlain
            // 
            this.signedEnvelopeCreatePlain.Location = new System.Drawing.Point(142, 20);
            this.signedEnvelopeCreatePlain.Name = "signedEnvelopeCreatePlain";
            this.signedEnvelopeCreatePlain.Size = new System.Drawing.Size(576, 20);
            this.signedEnvelopeCreatePlain.TabIndex = 4;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(16, 106);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(103, 13);
            this.label29.TabIndex = 3;
            this.label29.Text = "Signed envelope file";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(16, 75);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(96, 13);
            this.label28.TabIndex = 2;
            this.label28.Text = "Sender private key";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(16, 48);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(101, 13);
            this.label27.TabIndex = 1;
            this.label27.Text = "Receiver public key";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(16, 20);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(66, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "Plain text file";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 498);
            this.Controls.Add(this.tabControl);
            this.Name = "MainWindow";
            this.Text = "Crypto Algorithms";
            this.tabControl.ResumeLayout(false);
            this.aesTab.ResumeLayout(false);
            this.aesDecryptGroup.ResumeLayout(false);
            this.aesDecryptGroup.PerformLayout();
            this.aesEncryptGroup.ResumeLayout(false);
            this.aesEncryptGroup.PerformLayout();
            this.sha1Tab.ResumeLayout(false);
            this.sha1Tab.PerformLayout();
            this.rsaTab.ResumeLayout(false);
            this.rsaTab.PerformLayout();
            this.rsaDecryptBox.ResumeLayout(false);
            this.rsaDecryptBox.PerformLayout();
            this.rsaEncryptBox.ResumeLayout(false);
            this.rsaEncryptBox.PerformLayout();
            this.envelopeTab.ResumeLayout(false);
            this.envelopeDecryptBox.ResumeLayout(false);
            this.envelopeDecryptBox.PerformLayout();
            this.envelopeEncryptBox.ResumeLayout(false);
            this.envelopeEncryptBox.PerformLayout();
            this.signatureTab.ResumeLayout(false);
            this.signatureVerifyBox.ResumeLayout(false);
            this.signatureVerifyBox.PerformLayout();
            this.signatureCreateBox.ResumeLayout(false);
            this.signatureCreateBox.PerformLayout();
            this.signedEnvelopeTab.ResumeLayout(false);
            this.signedEnvelopeOpenBox.ResumeLayout(false);
            this.signedEnvelopeOpenBox.PerformLayout();
            this.signedEnvelopeCreateBox.ResumeLayout(false);
            this.signedEnvelopeCreateBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage aesTab;
        private System.Windows.Forms.TabPage sha1Tab;
        private System.Windows.Forms.GroupBox aesDecryptGroup;
        private System.Windows.Forms.GroupBox aesEncryptGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aesEncryptCipherFileLabel;
        private System.Windows.Forms.TextBox aesEncryptPlainFile;
        private System.Windows.Forms.TextBox aesEncryptIVFile;
        private System.Windows.Forms.TextBox aesEncryptKeyFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label aesIVLabel;
        private System.Windows.Forms.Label aesKeyLabel;
        private System.Windows.Forms.Button aesEncryptKeyChooseBtn;
        private System.Windows.Forms.TextBox aesEncryptCipherFile;
        private System.Windows.Forms.Button aesEncryptKeyGenerateBtn;
        private System.Windows.Forms.Button aesEncryptIVChooseBtn;
        private System.Windows.Forms.Button aesEncryptPlainChoosBtn;
        private System.Windows.Forms.Button aesEncryptIvGenerateBtn;
        private System.Windows.Forms.Button aesStartEncryptionBtn;
        private System.Windows.Forms.TextBox aesDecryptIvFile;
        private System.Windows.Forms.TextBox aesDecryptKeyFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button aesDecryptStartBtn;
        private System.Windows.Forms.TextBox aesDecryptPlainFile;
        private System.Windows.Forms.TextBox aesDecryptCipherFile;
        private System.Windows.Forms.Button aesDecryptCipherBtn;
        private System.Windows.Forms.Button aesDecryptChooseIvBtn;
        private System.Windows.Forms.Button aesDecryptChooseKeyBtn;
        private System.Windows.Forms.Button sha1PlainChooseBtn;
        private System.Windows.Forms.TextBox sha1HashFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sha1PlainFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button sha1CalculateHashBtn;
        private System.Windows.Forms.TabPage rsaTab;
        private System.Windows.Forms.TextBox rsaKeysSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button rsaGenerateKeysBtn;
        private System.Windows.Forms.GroupBox rsaEncryptBox;
        private System.Windows.Forms.Button rsaEncryptPlainBtn;
        private System.Windows.Forms.TextBox rsaEncryptCipherFile;
        private System.Windows.Forms.TextBox rsaEncryptPublicKey;
        private System.Windows.Forms.TextBox rsaEncryptPlainFile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button rsaEncryptPublicBtn;
        private System.Windows.Forms.Button rsaStartEncrypt;
        private System.Windows.Forms.GroupBox rsaDecryptBox;
        private System.Windows.Forms.Button rsaStartDecrypt;
        private System.Windows.Forms.Button rsaDecryptPrivateBtn;
        private System.Windows.Forms.Button rsaDecryptCipherBtn;
        private System.Windows.Forms.TextBox rsaDecryptPlainFile;
        private System.Windows.Forms.TextBox rsaDecryptPrivateKeyFile;
        private System.Windows.Forms.TextBox rsaDecryptCipherFile;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage envelopeTab;
        private System.Windows.Forms.GroupBox envelopeEncryptBox;
        private System.Windows.Forms.TextBox envelopeEncryptEnvelope;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox envelopeEncryptPublic;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox envelopeEncryptPlain;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button envelopeEncryptStart;
        private System.Windows.Forms.Button envelopeEncryptPublicBtn;
        private System.Windows.Forms.Button envelopeEncryptPlainBtn;
        private System.Windows.Forms.GroupBox envelopeDecryptBox;
        private System.Windows.Forms.Button envelopeDecryptStartBtn;
        private System.Windows.Forms.Button envelopeDecryptprivateBtn;
        private System.Windows.Forms.Button envelopeDecryptEnvelopeBtn;
        private System.Windows.Forms.TextBox envelopeDecryptPlain;
        private System.Windows.Forms.TextBox envelopeDecryptPrivate;
        private System.Windows.Forms.TextBox envelopeDecryptEnvelope;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage signatureTab;
        private System.Windows.Forms.GroupBox signatureCreateBox;
        private System.Windows.Forms.Button signatureCreateSignature;
        private System.Windows.Forms.Button signatureSignPrivateBtn;
        private System.Windows.Forms.Button signatureSignPlainBtn;
        private System.Windows.Forms.TextBox signatureSignSignature;
        private System.Windows.Forms.TextBox signatureSignPrivateKey;
        private System.Windows.Forms.TextBox signatureSignPlain;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox signatureVerifyBox;
        private System.Windows.Forms.Button signatureVerifyPublicBtn;
        private System.Windows.Forms.Button signatureVerifySignatureBtn;
        private System.Windows.Forms.TextBox signatureVerifyPublicKey;
        private System.Windows.Forms.TextBox signatureVerifySignatureFile;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button signatureVerifyBtn;
        private System.Windows.Forms.TabPage signedEnvelopeTab;
        private System.Windows.Forms.GroupBox signedEnvelopeCreateBox;
        private System.Windows.Forms.TextBox signedEnvelopeCreateEnvelope;
        private System.Windows.Forms.TextBox signedEnvelopeCreateSenderPrivate;
        private System.Windows.Forms.TextBox signedEnvelopeCreateReceiverPublic;
        private System.Windows.Forms.TextBox signedEnvelopeCreatePlain;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button signedEnvelopeCreateBtn;
        private System.Windows.Forms.Button signedEnvelopeCreateSenderPrivateBtn;
        private System.Windows.Forms.Button signedEnvelopeCreateReceiverPublicBtn;
        private System.Windows.Forms.Button signedEnvelopeCreatePlainBtn;
        private System.Windows.Forms.GroupBox signedEnvelopeOpenBox;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button signedEnvelopeOpenReceiverPrivateBtn;
        private System.Windows.Forms.Button signedEnvelopeOpenEnvelopeBtn;
        private System.Windows.Forms.TextBox signedEnvelopeOpenPlain;
        private System.Windows.Forms.TextBox signedEnvelopeOpenSenderPublic;
        private System.Windows.Forms.TextBox signedEnvelopeOpenReceiverPrivate;
        private System.Windows.Forms.TextBox signedEnvelopeOpenEnvelope;
        private System.Windows.Forms.Button signedEnvelopeOpenSenderPublicBtn;
        private System.Windows.Forms.Button signedEnvelopeOpenBtn;
    }
}

