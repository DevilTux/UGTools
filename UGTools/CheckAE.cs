using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UGTools.BusinessLogic;
using UGTools.Controls;
using UGTools.Entity;
using UGTools.Utils;

namespace UGTools
{
    public partial class CheckAE : Form
    {
        #region -- Private variables --
        
        private readonly CheckAccountBll _checkAccountBll = new CheckAccountBll();

        #endregion

        #region -- Constructor --
        
        public CheckAE()
        {
            InitializeComponent();
        }

        #endregion

        #region -- Private methods --
        private void LoadSetting()
        {
            
        }

        private void SetResult(string value)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action<string>(SetResult), new object[] { value });
                return;
            }
            textBoxOutput.Text += value;
            textBoxOutput.Text += "\r\n";
        }
        #endregion

        #region -- Controls --

        private void ButtonCheckClick(object sender, EventArgs e)
        {

            if (!bgwCheckAccount.IsBusy)
            {
                textBoxOutput.Text = string.Empty;
                bgwCheckAccount.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Đang chạy");
            }
        }

        private void BgwCheckAccountProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void BgwCheckAccountDowork(object sender, DoWorkEventArgs e)
        {

            var count = textBoxInput.Lines.Count();

            var emailposition = Convert.ToInt32(textBoxExEmailPos.Text);
            var passwordposition = Convert.ToInt32(textBoxExPassPos.Text);
            var splitChar = Convert.ToChar(textBoxExSplitChar.Text);
            var passLength = Convert.ToInt32(textBoxExPassLength.Text);
            var maxPart = emailposition;
            if (emailposition < passwordposition)
            {
                maxPart = passwordposition;
            }


            for (int i = 0; i < count; i++)
            {
                int percent = (i + 1)*100/count;

                var splitted = textBoxInput.Lines[i].Split(splitChar);
                if (splitted.Count() >= maxPart)
                {
                    var account = new Account {Username = splitted[0], Password = splitted[1]};
                    if (account.Password.Length < passLength)
                    {
                        bgwCheckAccount.ReportProgress(percent);
                        continue;
                    }
                    var checkResult = _checkAccountBll.CheckAe(account);

                    if (checkResult)
                    {
                        SetResult(string.Format("{0} | {1}", account.Username, account.Password));
                    }
                }
                bgwCheckAccount.ReportProgress(percent);
            }
        }

        private void TextBoxInputKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                textBoxInput.SelectAll();
            }
        }

        private void TextBoxOutputKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                textBoxOutput.SelectAll();
            }
        }

        private void OpenFileDialogSettingFileOk(object sender, CancelEventArgs e)
        {
            var filePath = openFileDialogSetting.FileName;
            textBoxSelectFile.Text = filePath;
            textBoxInput.Text = FileSupporter.Intance.ReadTextFromFile(filePath);

        }

        private void ButtonSelectFileClick(object sender, EventArgs e)
        {
            openFileDialogSetting.ShowDialog();
        }

        #endregion

    }
}
