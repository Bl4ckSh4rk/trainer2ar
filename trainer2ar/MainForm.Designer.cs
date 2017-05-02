namespace trainer2ar
{
    partial class MainForm
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
            this.openTrainer = new System.Windows.Forms.Button();
            this.saveCode = new System.Windows.Forms.Button();
            this.codeOutput = new System.Windows.Forms.RichTextBox();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.gameFRLG = new System.Windows.Forms.RadioButton();
            this.gameE = new System.Windows.Forms.RadioButton();
            this.gameRS = new System.Windows.Forms.RadioButton();
            this.regionPanel = new System.Windows.Forms.Panel();
            this.regionJP = new System.Windows.Forms.RadioButton();
            this.regionUS = new System.Windows.Forms.RadioButton();
            this.arVersionPanel = new System.Windows.Forms.Panel();
            this.ar12 = new System.Windows.Forms.RadioButton();
            this.ar34 = new System.Windows.Forms.RadioButton();
            this.cryptoPanel = new System.Windows.Forms.Panel();
            this.decrypted = new System.Windows.Forms.RadioButton();
            this.encrypted = new System.Windows.Forms.RadioButton();
            this.generateCode = new System.Windows.Forms.Button();
            this.gamePanel.SuspendLayout();
            this.regionPanel.SuspendLayout();
            this.arVersionPanel.SuspendLayout();
            this.cryptoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // openTrainer
            // 
            this.openTrainer.Location = new System.Drawing.Point(13, 13);
            this.openTrainer.Name = "openTrainer";
            this.openTrainer.Size = new System.Drawing.Size(122, 23);
            this.openTrainer.TabIndex = 0;
            this.openTrainer.Text = "Open Trainer";
            this.openTrainer.UseVisualStyleBackColor = true;
            this.openTrainer.Click += new System.EventHandler(this.openTrainer_Click);
            // 
            // saveCode
            // 
            this.saveCode.Enabled = false;
            this.saveCode.Location = new System.Drawing.Point(13, 41);
            this.saveCode.Name = "saveCode";
            this.saveCode.Size = new System.Drawing.Size(122, 23);
            this.saveCode.TabIndex = 1;
            this.saveCode.Text = "Save Code";
            this.saveCode.UseVisualStyleBackColor = true;
            this.saveCode.Click += new System.EventHandler(this.saveCode_Click);
            // 
            // codeOutput
            // 
            this.codeOutput.Font = new System.Drawing.Font("Consolas", 10F);
            this.codeOutput.Location = new System.Drawing.Point(141, 42);
            this.codeOutput.Name = "codeOutput";
            this.codeOutput.ReadOnly = true;
            this.codeOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.codeOutput.Size = new System.Drawing.Size(151, 272);
            this.codeOutput.TabIndex = 2;
            this.codeOutput.Text = "";
            // 
            // gamePanel
            // 
            this.gamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamePanel.Controls.Add(this.gameFRLG);
            this.gamePanel.Controls.Add(this.gameE);
            this.gamePanel.Controls.Add(this.gameRS);
            this.gamePanel.Enabled = false;
            this.gamePanel.Location = new System.Drawing.Point(13, 71);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(122, 73);
            this.gamePanel.TabIndex = 3;
            // 
            // gameFRLG
            // 
            this.gameFRLG.AutoSize = true;
            this.gameFRLG.Location = new System.Drawing.Point(4, 52);
            this.gameFRLG.Name = "gameFRLG";
            this.gameFRLG.Size = new System.Drawing.Size(117, 17);
            this.gameFRLG.TabIndex = 2;
            this.gameFRLG.Text = "FireRed/LeafGreen";
            this.gameFRLG.UseVisualStyleBackColor = true;
            // 
            // gameE
            // 
            this.gameE.AutoSize = true;
            this.gameE.Location = new System.Drawing.Point(4, 28);
            this.gameE.Name = "gameE";
            this.gameE.Size = new System.Drawing.Size(63, 17);
            this.gameE.TabIndex = 1;
            this.gameE.Text = "Emerald";
            this.gameE.UseVisualStyleBackColor = true;
            // 
            // gameRS
            // 
            this.gameRS.AutoSize = true;
            this.gameRS.Checked = true;
            this.gameRS.Location = new System.Drawing.Point(4, 4);
            this.gameRS.Name = "gameRS";
            this.gameRS.Size = new System.Drawing.Size(97, 17);
            this.gameRS.TabIndex = 0;
            this.gameRS.TabStop = true;
            this.gameRS.Text = "Ruby/Sapphire";
            this.gameRS.UseVisualStyleBackColor = true;
            // 
            // regionPanel
            // 
            this.regionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regionPanel.Controls.Add(this.regionJP);
            this.regionPanel.Controls.Add(this.regionUS);
            this.regionPanel.Enabled = false;
            this.regionPanel.Location = new System.Drawing.Point(13, 151);
            this.regionPanel.Name = "regionPanel";
            this.regionPanel.Size = new System.Drawing.Size(122, 50);
            this.regionPanel.TabIndex = 4;
            // 
            // regionJP
            // 
            this.regionJP.AutoSize = true;
            this.regionJP.Location = new System.Drawing.Point(4, 28);
            this.regionJP.Name = "regionJP";
            this.regionJP.Size = new System.Drawing.Size(37, 17);
            this.regionJP.TabIndex = 1;
            this.regionJP.Text = "JP";
            this.regionJP.UseVisualStyleBackColor = true;
            // 
            // regionUS
            // 
            this.regionUS.AutoSize = true;
            this.regionUS.Checked = true;
            this.regionUS.Location = new System.Drawing.Point(4, 4);
            this.regionUS.Name = "regionUS";
            this.regionUS.Size = new System.Drawing.Size(60, 17);
            this.regionUS.TabIndex = 0;
            this.regionUS.TabStop = true;
            this.regionUS.Text = "US/EU";
            this.regionUS.UseVisualStyleBackColor = true;
            // 
            // arVersionPanel
            // 
            this.arVersionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arVersionPanel.Controls.Add(this.ar12);
            this.arVersionPanel.Controls.Add(this.ar34);
            this.arVersionPanel.Enabled = false;
            this.arVersionPanel.Location = new System.Drawing.Point(13, 207);
            this.arVersionPanel.Name = "arVersionPanel";
            this.arVersionPanel.Size = new System.Drawing.Size(122, 50);
            this.arVersionPanel.TabIndex = 5;
            // 
            // ar12
            // 
            this.ar12.AutoSize = true;
            this.ar12.Location = new System.Drawing.Point(4, 28);
            this.ar12.Name = "ar12";
            this.ar12.Size = new System.Drawing.Size(63, 17);
            this.ar12.TabIndex = 1;
            this.ar12.Text = "ARv1/2";
            this.ar12.UseVisualStyleBackColor = true;
            // 
            // ar34
            // 
            this.ar34.AutoSize = true;
            this.ar34.Checked = true;
            this.ar34.Location = new System.Drawing.Point(4, 4);
            this.ar34.Name = "ar34";
            this.ar34.Size = new System.Drawing.Size(63, 17);
            this.ar34.TabIndex = 0;
            this.ar34.TabStop = true;
            this.ar34.Text = "ARv3/4";
            this.ar34.UseVisualStyleBackColor = true;
            // 
            // cryptoPanel
            // 
            this.cryptoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryptoPanel.Controls.Add(this.decrypted);
            this.cryptoPanel.Controls.Add(this.encrypted);
            this.cryptoPanel.Enabled = false;
            this.cryptoPanel.Location = new System.Drawing.Point(13, 264);
            this.cryptoPanel.Name = "cryptoPanel";
            this.cryptoPanel.Size = new System.Drawing.Size(122, 50);
            this.cryptoPanel.TabIndex = 6;
            // 
            // decrypted
            // 
            this.decrypted.AutoSize = true;
            this.decrypted.Location = new System.Drawing.Point(4, 27);
            this.decrypted.Name = "decrypted";
            this.decrypted.Size = new System.Drawing.Size(74, 17);
            this.decrypted.TabIndex = 1;
            this.decrypted.Text = "Decrypted";
            this.decrypted.UseVisualStyleBackColor = true;
            // 
            // encrypted
            // 
            this.encrypted.AutoSize = true;
            this.encrypted.Checked = true;
            this.encrypted.Location = new System.Drawing.Point(4, 3);
            this.encrypted.Name = "encrypted";
            this.encrypted.Size = new System.Drawing.Size(73, 17);
            this.encrypted.TabIndex = 0;
            this.encrypted.TabStop = true;
            this.encrypted.Text = "Encrypted";
            this.encrypted.UseVisualStyleBackColor = true;
            // 
            // generateCode
            // 
            this.generateCode.Enabled = false;
            this.generateCode.Location = new System.Drawing.Point(141, 13);
            this.generateCode.Name = "generateCode";
            this.generateCode.Size = new System.Drawing.Size(151, 23);
            this.generateCode.TabIndex = 7;
            this.generateCode.Text = "Generate Code";
            this.generateCode.UseVisualStyleBackColor = true;
            this.generateCode.Click += new System.EventHandler(this.generateCode_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 327);
            this.Controls.Add(this.generateCode);
            this.Controls.Add(this.cryptoPanel);
            this.Controls.Add(this.arVersionPanel);
            this.Controls.Add(this.regionPanel);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.codeOutput);
            this.Controls.Add(this.saveCode);
            this.Controls.Add(this.openTrainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "trainer2ar";
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.regionPanel.ResumeLayout(false);
            this.regionPanel.PerformLayout();
            this.arVersionPanel.ResumeLayout(false);
            this.arVersionPanel.PerformLayout();
            this.cryptoPanel.ResumeLayout(false);
            this.cryptoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openTrainer;
        private System.Windows.Forms.Button saveCode;
        private System.Windows.Forms.RichTextBox codeOutput;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.RadioButton gameFRLG;
        private System.Windows.Forms.RadioButton gameE;
        private System.Windows.Forms.RadioButton gameRS;
        private System.Windows.Forms.Panel regionPanel;
        private System.Windows.Forms.RadioButton regionJP;
        private System.Windows.Forms.RadioButton regionUS;
        private System.Windows.Forms.Panel arVersionPanel;
        private System.Windows.Forms.RadioButton ar12;
        private System.Windows.Forms.RadioButton ar34;
        private System.Windows.Forms.Panel cryptoPanel;
        private System.Windows.Forms.RadioButton decrypted;
        private System.Windows.Forms.RadioButton encrypted;
        private System.Windows.Forms.Button generateCode;
    }
}

