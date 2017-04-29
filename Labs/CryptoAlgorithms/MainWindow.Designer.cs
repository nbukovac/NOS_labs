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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.aesTab = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.aesEncryptGroup = new System.Windows.Forms.GroupBox();
            this.aesDecryptGroup = new System.Windows.Forms.GroupBox();
            this.aesKeyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aesIVLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aesEncryptKeyFile = new System.Windows.Forms.TextBox();
            this.aesEncryptIVFile = new System.Windows.Forms.TextBox();
            this.aesEncryptPlainFile = new System.Windows.Forms.TextBox();
            this.aesEncryptCipherFile = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.aesEncryptKeyChooseBtn = new System.Windows.Forms.Button();
            this.aesEncryptKeyGenerateBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.aesTab.SuspendLayout();
            this.aesEncryptGroup.SuspendLayout();
            this.aesDecryptGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.aesTab);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(873, 497);
            this.tabControl1.TabIndex = 0;
            // 
            // aesTab
            // 
            this.aesTab.Controls.Add(this.aesDecryptGroup);
            this.aesTab.Controls.Add(this.aesEncryptGroup);
            this.aesTab.Location = new System.Drawing.Point(4, 22);
            this.aesTab.Name = "aesTab";
            this.aesTab.Padding = new System.Windows.Forms.Padding(3);
            this.aesTab.Size = new System.Drawing.Size(865, 471);
            this.aesTab.TabIndex = 0;
            this.aesTab.Text = "AES";
            this.aesTab.ToolTipText = "AES algorithm";
            this.aesTab.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // aesEncryptGroup
            // 
            this.aesEncryptGroup.Controls.Add(this.aesEncryptKeyGenerateBtn);
            this.aesEncryptGroup.Controls.Add(this.aesEncryptKeyChooseBtn);
            this.aesEncryptGroup.Controls.Add(this.textBox1);
            this.aesEncryptGroup.Controls.Add(this.aesEncryptCipherFile);
            this.aesEncryptGroup.Controls.Add(this.aesEncryptPlainFile);
            this.aesEncryptGroup.Controls.Add(this.aesEncryptIVFile);
            this.aesEncryptGroup.Controls.Add(this.aesEncryptKeyFile);
            this.aesEncryptGroup.Controls.Add(this.label3);
            this.aesEncryptGroup.Controls.Add(this.aesIVLabel);
            this.aesEncryptGroup.Controls.Add(this.aesKeyLabel);
            this.aesEncryptGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aesEncryptGroup.Location = new System.Drawing.Point(16, 20);
            this.aesEncryptGroup.Name = "aesEncryptGroup";
            this.aesEncryptGroup.Size = new System.Drawing.Size(830, 182);
            this.aesEncryptGroup.TabIndex = 0;
            this.aesEncryptGroup.TabStop = false;
            this.aesEncryptGroup.Text = "Encrypt";
            // 
            // aesDecryptGroup
            // 
            this.aesDecryptGroup.Controls.Add(this.label2);
            this.aesDecryptGroup.Controls.Add(this.label1);
            this.aesDecryptGroup.Location = new System.Drawing.Point(16, 226);
            this.aesDecryptGroup.Name = "aesDecryptGroup";
            this.aesDecryptGroup.Size = new System.Drawing.Size(830, 203);
            this.aesDecryptGroup.TabIndex = 1;
            this.aesDecryptGroup.TabStop = false;
            this.aesDecryptGroup.Text = "Decrypt";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(7, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "File containing IV";
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
            // aesEncryptKeyFile
            // 
            this.aesEncryptKeyFile.Location = new System.Drawing.Point(150, 20);
            this.aesEncryptKeyFile.Name = "aesEncryptKeyFile";
            this.aesEncryptKeyFile.Size = new System.Drawing.Size(443, 26);
            this.aesEncryptKeyFile.TabIndex = 3;
            // 
            // aesEncryptIVFile
            // 
            this.aesEncryptIVFile.Location = new System.Drawing.Point(150, 55);
            this.aesEncryptIVFile.Name = "aesEncryptIVFile";
            this.aesEncryptIVFile.Size = new System.Drawing.Size(443, 26);
            this.aesEncryptIVFile.TabIndex = 4;
            // 
            // aesEncryptPlainFile
            // 
            this.aesEncryptPlainFile.Location = new System.Drawing.Point(150, 93);
            this.aesEncryptPlainFile.Name = "aesEncryptPlainFile";
            this.aesEncryptPlainFile.Size = new System.Drawing.Size(443, 26);
            this.aesEncryptPlainFile.TabIndex = 5;
            // 
            // aesEncryptCipherFile
            // 
            this.aesEncryptCipherFile.AutoSize = true;
            this.aesEncryptCipherFile.Location = new System.Drawing.Point(6, 135);
            this.aesEncryptCipherFile.Name = "aesEncryptCipherFile";
            this.aesEncryptCipherFile.Size = new System.Drawing.Size(109, 20);
            this.aesEncryptCipherFile.TabIndex = 6;
            this.aesEncryptCipherFile.Text = "Cipher text file";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(443, 26);
            this.textBox1.TabIndex = 7;
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 505);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainWindow";
            this.Text = "Crypto Algorithms";
            this.tabControl1.ResumeLayout(false);
            this.aesTab.ResumeLayout(false);
            this.aesEncryptGroup.ResumeLayout(false);
            this.aesEncryptGroup.PerformLayout();
            this.aesDecryptGroup.ResumeLayout(false);
            this.aesDecryptGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage aesTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox aesDecryptGroup;
        private System.Windows.Forms.GroupBox aesEncryptGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aesEncryptCipherFile;
        private System.Windows.Forms.TextBox aesEncryptPlainFile;
        private System.Windows.Forms.TextBox aesEncryptIVFile;
        private System.Windows.Forms.TextBox aesEncryptKeyFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label aesIVLabel;
        private System.Windows.Forms.Label aesKeyLabel;
        private System.Windows.Forms.Button aesEncryptKeyChooseBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button aesEncryptKeyGenerateBtn;
    }
}

