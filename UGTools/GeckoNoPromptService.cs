using System;

using System.Windows.Forms;
using Gecko;

namespace UGTools
{
    public class NoPromptServices : nsIPromptService2, nsIPrompt
    {
        #region Implementation of nsIPromptService2

        public void Alert(nsIDOMWindow aParent, string aDialogTitle, string aText)
        {

        }

        public void AlertCheck(nsIDOMWindow aParent, string aDialogTitle, string aText, string aCheckMsg, ref bool aCheckState)
        {
            //throw new NotImplementedException();
        }

        public bool Confirm(nsIDOMWindow aParent, string aDialogTitle, string aText)
        {
            return true;
        }

        public bool ConfirmCheck(nsIDOMWindow aParent, string aDialogTitle, string aText, string aCheckMsg, ref bool aCheckState)
        {
            return true;
        }

        public int ConfirmEx(nsIDOMWindow aParent, string aDialogTitle, string aText, uint aButtonFlags, string aButton0Title, string aButton1Title, string aButton2Title, string aCheckMsg, ref bool aCheckState)
        {
            DialogResult result = MessageBox.Show(aText, aDialogTitle, MessageBoxButtons.YesNoCancel);
            switch (result)
            {
                case DialogResult.Yes:
                    return 0;
                case DialogResult.No:
                    return 1;
                case DialogResult.Cancel:
                    return 2;
            }
            return 0;
        }

        public bool Prompt(nsIDOMWindow aParent, string aDialogTitle, string aText, ref string aValue, string aCheckMsg, ref bool aCheckState)
        {
            return true;
        }

        public bool PromptUsernameAndPassword(nsIDOMWindow aParent, string aDialogTitle, string aText, ref string aUsername, ref string aPassword, string aCheckMsg, ref bool aCheckState)
        {
            return true;
        }

        public bool PromptPassword(nsIDOMWindow aParent, string aDialogTitle, string aText, ref string aPassword, string aCheckMsg, ref bool aCheckState)
        {
            return true;
        }

        public bool Select(nsIDOMWindow aParent, string aDialogTitle, string aText, uint aCount, IntPtr[] aSelectList, ref int aOutSelection)
        {
            return true;
        }

        public bool PromptAuth(nsIDOMWindow aParent, nsIChannel aChannel, uint level, nsIAuthInformation authInfo, string checkboxLabel, ref bool checkValue)
        {
            return true;
        }

        public nsICancelable AsyncPromptAuth(nsIDOMWindow aParent, nsIChannel aChannel, nsIAuthPromptCallback aCallback, nsISupports aContext, uint level, nsIAuthInformation authInfo, string checkboxLabel, ref bool checkValue)
        {
            return null;
        }

        #endregion

        #region Implementation of nsIPrompt

        public void Alert(string dialogTitle, string text)
        {
            //MessageBox.Show(text, dialogTitle);
            //throw new NotImplementedException();
        }

        public void AlertCheck(string dialogTitle, string text, string checkMsg, ref bool checkValue)
        {

            throw new NotImplementedException();
        }

        public bool Confirm(string dialogTitle, string text)
        {
            return true;
        }

        public bool ConfirmCheck(string dialogTitle, string text, string checkMsg, ref bool checkValue)
        {
            throw new NotImplementedException();
            return true;
        }

        public int ConfirmEx(string dialogTitle, string text, uint buttonFlags, string button0Title, string button1Title, string button2Title, string checkMsg, ref bool checkValue)
        {
            DialogResult result = MessageBox.Show(text, dialogTitle, MessageBoxButtons.YesNoCancel);
            switch (result)
            {
                case DialogResult.Yes:
                    return 0;
                case DialogResult.No:
                    return 1;
                case DialogResult.Cancel:
                    return 2;
            }
            return 0;
        }

        public bool Prompt(string dialogTitle, string text, ref string value, string checkMsg, ref bool checkValue)
        {
            throw new NotImplementedException();
            return true;
        }

        public bool PromptPassword(string dialogTitle, string text, ref string password, string checkMsg, ref bool checkValue)
        {
            throw new NotImplementedException();
            return true;
        }

        public bool PromptUsernameAndPassword(string dialogTitle, string text, ref string username, ref string password, string checkMsg, ref bool checkValue)
        {
            throw new NotImplementedException();
            return true;
        }

        public bool Select(string dialogTitle, string text, uint count, IntPtr[] selectList, ref int outSelection)
        {
            throw new NotImplementedException();
            return true;
        }

        #endregion
    }
}
