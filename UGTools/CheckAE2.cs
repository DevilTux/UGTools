using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gecko;
using Gecko.DOM;
using UGTools.Entity;

namespace UGTools
{
    public partial class CheckAE2 : Form
    {
        private bool _loadedLoginForm;
        private static int _navigateCount;
        private static bool _isChecked;
       
        private static int _checkedLine;
        private static Account _account;
        public CheckAE2()
        {
            InitializeComponent();
            GeckoWebBrowser.UseCustomPrompt();
            PromptFactory.PromptServiceCreator = () => new NoPromptServices(); // Tắt hoàn toàn các thông báo alert, prompt, v.v.
            Xpcom.Initialize(Application.StartupPath + "/xulrunner/");
        }

        private void CheckAE2Load(object sender, EventArgs e)
        {
            gwbCheckAE.Navigate("https://m.ae.com/web/flat/account_login.jsp?");
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

        private void GwbCheckAEDocumentCompleted(object sender, EventArgs e)
        {
            if (_navigateCount == 3)
            {
                _navigateCount = 0;
                _isChecked = true;
            }
            var formLogin = (GeckoFormElement)gwbCheckAE.Document.GetElementById("loginForm");
            if (formLogin!=null &&!_loadedLoginForm)
            {
                _loadedLoginForm = true;
                //22 2
                GeckoInputElement buttonSubmit = (GeckoInputElement)formLogin.Elements[24];
                GeckoInputElement textboxEmail = (GeckoInputElement)formLogin.Elements[20];
                GeckoInputElement textboxPass = (GeckoInputElement)formLogin.Elements[22];

                if (buttonSubmit != null && textboxEmail!=null && textboxPass!=null)
                {
                    textboxEmail.Value = "asdasd@asdasd.com";
                    textboxPass.Value = "asdasd@asdasd.com";
                    buttonSubmit.Click();
                }
            }
        }

        

        private void GwbCheckAENavigated(object sender, GeckoNavigatedEventArgs e)
        {
            _navigateCount++;
            label1.Text = string.Format("{0}", _navigateCount);
        }

        private void BbgwCheckAeDoWork(object sender, DoWorkEventArgs e)
        {
            var count = textBoxInput.Lines.Count();

            var emailposition = Convert.ToInt32(textBoxEmailPos.Text);
            var passwordposition = Convert.ToInt32(textBoxPassPos.Text);
            var splitChar = Convert.ToChar(textBoxSplitChar.Text);
            var passLength = Convert.ToInt32(textBoxPassLength.Text);
            //var maxPart = emailposition;
            //if (emailposition < passwordposition)
            //{
            //    maxPart = passwordposition;
            //}

            while (_checkedLine<count)
            {
                _navigateCount = 0;
                int percent = (_checkedLine + 1) * 100 / count;
                
                var splitted = textBoxInput.Lines[_checkedLine].Split(splitChar);
                var account = new Account { Username = splitted[0], Password = splitted[1] };

                gwbCheckAE.Navigate("https://m.ae.com/web/flat/account_login.jsp?");

            }

            for (int i = 0; i < count; i++)
            {
                int percent = (i + 1) * 100 / count;

                var splitted = textBoxInput.Lines[i].Split(splitChar);
                //if (splitted.Count() >= maxPart)
                //{
                    var account = new Account { Username = splitted[0], Password = splitted[1] };
                    if (account.Password.Length < passLength)
                    {
                        bgwCheckAe.ReportProgress(percent);
                        continue;
                    }
                    //var checkResult = _checkAccountBll.CheckAe(account);

                    //if (checkResult)
                    //{
                    //    SetResult(string.Format("{0} | {1}", account.Username, account.Password));
                    //}
                //}
                bgwCheckAe.ReportProgress(percent);
            }
        }

        private void BgwCheckAeProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void ButtonCheckClick(object sender, EventArgs e)
        {
            if (!bgwCheckAe.IsBusy)
            {
                textBoxOutput.Text = string.Empty;
                bgwCheckAe.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Đang chạy");
            }
        }
    }
}
