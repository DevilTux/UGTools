namespace UGTools
{
    partial class CheckAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckAE));
            this.bgwCheckAccount = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.openFileDialogSetting = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSelectFile = new System.Windows.Forms.TextBox();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbAE = new System.Windows.Forms.RadioButton();
            this.rbBedBath = new System.Windows.Forms.RadioButton();
            this.textBoxExPassPos = new UGTools.Controls.TextBoxEx();
            this.textBoxExPassLength = new UGTools.Controls.TextBoxEx();
            this.textBoxExSplitChar = new UGTools.Controls.TextBoxEx();
            this.textBoxExEmailPos = new UGTools.Controls.TextBoxEx();
            this.SuspendLayout();
            // 
            // bgwCheckAccount
            // 
            this.bgwCheckAccount.WorkerReportsProgress = true;
            this.bgwCheckAccount.WorkerSupportsCancellation = true;
            this.bgwCheckAccount.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwCheckAccountDowork);
            this.bgwCheckAccount.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgwCheckAccountProgressChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "Live account:";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(325, 45);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(280, 360);
            this.textBoxOutput.TabIndex = 10;
            this.textBoxOutput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxOutputKeyDown);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(630, 327);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(100, 23);
            this.buttonCheck.TabIndex = 9;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.ButtonCheckClick);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(20, 460);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(585, 25);
            this.progressBar.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "List mail/pass:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(20, 45);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxInput.Size = new System.Drawing.Size(280, 360);
            this.textBoxInput.TabIndex = 6;
            this.textBoxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxInputKeyDown);
            // 
            // openFileDialogSetting
            // 
            this.openFileDialogSetting.Filter = "*.txt|";
            this.openFileDialogSetting.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialogSettingFileOk);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lấy từ file:";
            // 
            // textBoxSelectFile
            // 
            this.textBoxSelectFile.Location = new System.Drawing.Point(110, 418);
            this.textBoxSelectFile.Name = "textBoxSelectFile";
            this.textBoxSelectFile.Size = new System.Drawing.Size(400, 20);
            this.textBoxSelectFile.TabIndex = 13;
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(530, 415);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectFile.TabIndex = 14;
            this.buttonSelectFile.Text = "Chọn";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.ButtonSelectFileClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(610, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 14);
            this.label3.TabIndex = 15;
            this.label3.Text = "Vị trí email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(610, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 14);
            this.label4.TabIndex = 16;
            this.label4.Text = "Vị trí pass:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(610, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 14);
            this.label5.TabIndex = 17;
            this.label5.Text = "KT phân cách:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(610, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 14);
            this.label7.TabIndex = 18;
            this.label7.Text = "Độ dài pass:";
            // 
            // rbAE
            // 
            this.rbAE.AutoSize = true;
            this.rbAE.Location = new System.Drawing.Point(613, 178);
            this.rbAE.Name = "rbAE";
            this.rbAE.Size = new System.Drawing.Size(62, 18);
            this.rbAE.TabIndex = 23;
            this.rbAE.TabStop = true;
            this.rbAE.Text = "AE.com";
            this.rbAE.UseVisualStyleBackColor = true;
            // 
            // rbBedBath
            // 
            this.rbBedBath.AutoSize = true;
            this.rbBedBath.Location = new System.Drawing.Point(613, 210);
            this.rbBedBath.Name = "rbBedBath";
            this.rbBedBath.Size = new System.Drawing.Size(65, 18);
            this.rbBedBath.TabIndex = 24;
            this.rbBedBath.TabStop = true;
            this.rbBedBath.Text = "Bedbath";
            this.rbBedBath.UseVisualStyleBackColor = true;
            // 
            // textBoxExPassPos
            // 
            this.textBoxExPassPos.Location = new System.Drawing.Point(690, 83);
            this.textBoxExPassPos.Name = "textBoxExPassPos";
            this.textBoxExPassPos.Size = new System.Drawing.Size(40, 20);
            this.textBoxExPassPos.TabIndex = 22;
            this.textBoxExPassPos.Text = "2";
            this.textBoxExPassPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxExPassLength
            // 
            this.textBoxExPassLength.Location = new System.Drawing.Point(690, 143);
            this.textBoxExPassLength.Name = "textBoxExPassLength";
            this.textBoxExPassLength.Size = new System.Drawing.Size(40, 20);
            this.textBoxExPassLength.TabIndex = 21;
            this.textBoxExPassLength.Text = "6";
            this.textBoxExPassLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxExSplitChar
            // 
            this.textBoxExSplitChar.Location = new System.Drawing.Point(690, 113);
            this.textBoxExSplitChar.Name = "textBoxExSplitChar";
            this.textBoxExSplitChar.Size = new System.Drawing.Size(40, 20);
            this.textBoxExSplitChar.TabIndex = 20;
            this.textBoxExSplitChar.Text = "|";
            this.textBoxExSplitChar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxExEmailPos
            // 
            this.textBoxExEmailPos.Location = new System.Drawing.Point(690, 53);
            this.textBoxExEmailPos.Name = "textBoxExEmailPos";
            this.textBoxExEmailPos.Size = new System.Drawing.Size(40, 20);
            this.textBoxExEmailPos.TabIndex = 19;
            this.textBoxExEmailPos.Text = "1";
            this.textBoxExEmailPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CheckAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 492);
            this.Controls.Add(this.rbBedBath);
            this.Controls.Add(this.rbAE);
            this.Controls.Add(this.textBoxExPassPos);
            this.Controls.Add(this.textBoxExPassLength);
            this.Controls.Add(this.textBoxExSplitChar);
            this.Controls.Add(this.textBoxExEmailPos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.textBoxSelectFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckAE";
            this.Text = "Check AE.com";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgwCheckAccount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.OpenFileDialog openFileDialogSetting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSelectFile;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private Controls.TextBoxEx textBoxExEmailPos;
        private Controls.TextBoxEx textBoxExSplitChar;
        private Controls.TextBoxEx textBoxExPassLength;
        private Controls.TextBoxEx textBoxExPassPos;
        private System.Windows.Forms.RadioButton rbAE;
        private System.Windows.Forms.RadioButton rbBedBath;
    }
}