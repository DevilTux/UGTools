namespace UGTools
{
    partial class CheckAE2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckAE2));
            this.gwbCheckAE = new Gecko.GeckoWebBrowser();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.bgwCheckAe = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.textBoxEmailPos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPassPos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSplitChar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPassLength = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gwbCheckAE
            // 
            this.gwbCheckAE.DisableWmImeSetContext = false;
            this.gwbCheckAE.Location = new System.Drawing.Point(12, 200);
            this.gwbCheckAE.Name = "gwbCheckAE";
            this.gwbCheckAE.Size = new System.Drawing.Size(740, 200);
            this.gwbCheckAE.TabIndex = 0;
            this.gwbCheckAE.UseHttpActivityObserver = false;
            this.gwbCheckAE.Navigated += new System.EventHandler<Gecko.GeckoNavigatedEventArgs>(this.GwbCheckAENavigated);
            this.gwbCheckAE.DocumentCompleted += new System.EventHandler(this.GwbCheckAEDocumentCompleted);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 420);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(740, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 2;
            // 
            // bgwCheckAe
            // 
            this.bgwCheckAe.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BbgwCheckAeDoWork);
            this.bgwCheckAe.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgwCheckAeProgressChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // textBoxInput
            // 
            this.textBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInput.Location = new System.Drawing.Point(10, 10);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxInput.Size = new System.Drawing.Size(230, 180);
            this.textBoxInput.TabIndex = 3;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOutput.Location = new System.Drawing.Point(280, 10);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(230, 180);
            this.textBoxOutput.TabIndex = 4;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(526, 12);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.TabIndex = 5;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.ButtonCheckClick);
            // 
            // textBoxEmailPos
            // 
            this.textBoxEmailPos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmailPos.Location = new System.Drawing.Point(708, 14);
            this.textBoxEmailPos.Name = "textBoxEmailPos";
            this.textBoxEmailPos.Size = new System.Drawing.Size(44, 20);
            this.textBoxEmailPos.TabIndex = 6;
            this.textBoxEmailPos.Text = "1";
            this.textBoxEmailPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(633, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(633, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pass";
            // 
            // textBoxPassPos
            // 
            this.textBoxPassPos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassPos.Location = new System.Drawing.Point(708, 49);
            this.textBoxPassPos.Name = "textBoxPassPos";
            this.textBoxPassPos.Size = new System.Drawing.Size(44, 20);
            this.textBoxPassPos.TabIndex = 8;
            this.textBoxPassPos.Text = "2";
            this.textBoxPassPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(633, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Char";
            // 
            // textBoxSplitChar
            // 
            this.textBoxSplitChar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSplitChar.Location = new System.Drawing.Point(708, 86);
            this.textBoxSplitChar.Name = "textBoxSplitChar";
            this.textBoxSplitChar.Size = new System.Drawing.Size(44, 20);
            this.textBoxSplitChar.TabIndex = 10;
            this.textBoxSplitChar.Text = "|";
            this.textBoxSplitChar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(633, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pass length";
            // 
            // textBoxPassLength
            // 
            this.textBoxPassLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassLength.Location = new System.Drawing.Point(708, 124);
            this.textBoxPassLength.Name = "textBoxPassLength";
            this.textBoxPassLength.Size = new System.Drawing.Size(44, 20);
            this.textBoxPassLength.TabIndex = 12;
            this.textBoxPassLength.Text = "6";
            this.textBoxPassLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CheckAE2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 457);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPassLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSplitChar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPassPos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEmailPos);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gwbCheckAE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckAE2";
            this.Text = "CheckAE2";
            this.Load += new System.EventHandler(this.CheckAE2Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gecko.GeckoWebBrowser gwbCheckAE;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker bgwCheckAe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.TextBox textBoxEmailPos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPassPos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSplitChar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPassLength;
    }
}