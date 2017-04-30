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
            this.tabControl.SuspendLayout();
            this.aesTab.SuspendLayout();
            this.aesDecryptGroup.SuspendLayout();
            this.aesEncryptGroup.SuspendLayout();
            this.sha1Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.aesTab);
            this.tabControl.Controls.Add(this.sha1Tab);
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
    }
}

