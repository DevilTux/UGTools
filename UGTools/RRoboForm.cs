using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ROBOFORMLib;
using Telerik.WinControls.UI;
using UGTools.BusinessLogic;
using UGTools.DataAccess;
using UGTools.Entity;


namespace UGTools
{
    public partial class RRoboForm : Telerik.WinControls.UI.RadForm
    {
        private readonly string _identityPath = Application.StartupPath + "\\Config\\ducmami";
        private readonly RoboFormBll _roboFormBll = new RoboFormBll();
        private readonly string _intPath = string.Format("{0}\\Config\\Roboform.ini", Application.StartupPath);
        public RRoboForm()
        {
            InitializeComponent();
        }

        private void RadButtonLoadSettingClick(object sender, EventArgs e)
        {
            if (File.Exists(_intPath))
            {
                var iniSetting = new IniFile(_intPath);
                radTextBoxCardNum.Text = iniSetting.IniReadValue("CardInfo", "CardNumPos");
                radTextBoxCvn.Text = iniSetting.IniReadValue("CardInfo", "CvnPos");
                radTextBoxExpMonth.Text = iniSetting.IniReadValue("CardInfo", "ExpMonthPos");
                radTextBoxExpYear.Text = iniSetting.IniReadValue("CardInfo", "ExpYearPos");
                radTextBoxFirstname.Text = iniSetting.IniReadValue("CardInfo", "FirstnamePos");
                radTextBoxLastname.Text = iniSetting.IniReadValue("CardInfo", "LastnamePos");
                radTextBoxAddress1.Text = iniSetting.IniReadValue("CardInfo", "Address1Pos");
                radTextBoxAddress2.Text = iniSetting.IniReadValue("CardInfo", "Address2Pos");
                radTextBoxCity.Text = iniSetting.IniReadValue("CardInfo", "CityPos");
                radTextBoxZipcode.Text = iniSetting.IniReadValue("CardInfo", "ZipcodePos");
                radTextBoxState.Text = iniSetting.IniReadValue("CardInfo", "StatePos");
                radTextBoxPhone.Text = iniSetting.IniReadValue("CardInfo", "PhonePos");
                radTextBoxSplitChar.Text = iniSetting.IniReadValue("CardInfo", "SplitChar");
            }
        }

        private void RadButtonSaveSettingClick(object sender, EventArgs e)
        {
            if (!File.Exists(_intPath))
            {
                File.Create(_intPath);
            }
            var iniSetting = new IniFile(_intPath);
            iniSetting.IniWriteValue("CardInfo", "CardNumPos", radTextBoxCardNum.Text);
            iniSetting.IniWriteValue("CardInfo", "CvnPos", radTextBoxCvn.Text);
            iniSetting.IniWriteValue("CardInfo", "ExpMonthPos", radTextBoxExpMonth.Text);
            iniSetting.IniWriteValue("CardInfo", "ExpYearPos", radTextBoxExpYear.Text);
            iniSetting.IniWriteValue("CardInfo", "FirstnamePos", radTextBoxFirstname.Text);
            iniSetting.IniWriteValue("CardInfo", "LastnamePos", radTextBoxLastname.Text);
            iniSetting.IniWriteValue("CardInfo", "Address1Pos", radTextBoxAddress1.Text);
            iniSetting.IniWriteValue("CardInfo", "Address2Pos", radTextBoxAddress2.Text);
            iniSetting.IniWriteValue("CardInfo", "CityPos", radTextBoxCity.Text);
            iniSetting.IniWriteValue("CardInfo", "ZipcodePos", radTextBoxZipcode.Text);
            iniSetting.IniWriteValue("CardInfo", "StatePos", radTextBoxState.Text);
            iniSetting.IniWriteValue("CardInfo", "PhonePos", radTextBoxPhone.Text);
            iniSetting.IniWriteValue("CardInfo", "SplitChar", radTextBoxSplitChar.Text);
        }

        private void RadButtonFilterCardClick(object sender, EventArgs e)
        {
            var listPersonal = new List<FullInfo>();
            var count = radTextBoxInput.Lines.Length;
            var roboformBll = new RoboFormBll();
            if (radCheckBoxAutoDetect.Checked)
            {

            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    try
                    {
                        var line = radTextBoxInput.Lines[i];
                        var part = line.Split(Convert.ToChar(radTextBoxSplitChar.Text));
                        var tmpFullInfo = new FullInfo();

                        #region cc info

                        var cardNumPos = Convert.ToInt32(radTextBoxCardNum.Text);
                        if (cardNumPos > 0)
                            tmpFullInfo.CardNumber = part[cardNumPos - 1].Trim();

                        var cvnPos = Convert.ToInt32(radTextBoxCvn.Text);
                        if (cvnPos > 0)
                            tmpFullInfo.Cvn = Convert.ToInt32(part[cvnPos - 1].Trim());

                        var expMonthPos = Convert.ToInt32(radTextBoxExpMonth.Text);
                        if (expMonthPos > 0)
                            tmpFullInfo.ExpiredMonth = part[expMonthPos - 1].Trim();

                        var expYearPos = Convert.ToInt32(radTextBoxExpYear.Text);
                        if (expYearPos > 0)
                            tmpFullInfo.ExpiredYear = part[expYearPos - 1].Trim();

                        #endregion

                        #region address

                        var address1Pos = Convert.ToInt32(radTextBoxAddress1.Text);
                        if (address1Pos > 0)
                            tmpFullInfo.Address1 = part[address1Pos - 1].Trim();

                        var address2Pos = Convert.ToInt32(radTextBoxAddress2.Text);
                        if (address2Pos > 0)
                            tmpFullInfo.Address2 = part[address2Pos - 1].Trim();

                        var cityPos = Convert.ToInt32(radTextBoxCity.Text);
                        if (cityPos > 0)
                            tmpFullInfo.City = part[cityPos - 1].Trim();

                        var statePos = Convert.ToInt32(radTextBoxState.Text);
                        if (statePos > 0)
                            tmpFullInfo.State = part[statePos - 1].Trim();

                        var zipcodePos = Convert.ToInt32(radTextBoxZipcode.Text);
                        if (zipcodePos > 0)
                            tmpFullInfo.Zipcode = part[zipcodePos - 1].Trim();

                        var phonePos = Convert.ToInt32(radTextBoxPhone.Text);
                        if (phonePos > 0)
                            tmpFullInfo.PhoneNumber = part[phonePos - 1].Trim();

                        #endregion

                        #region account

                        #endregion

                        var firstnamePos = Convert.ToInt32(radTextBoxFirstname.Text);
                        if (firstnamePos > 0)
                            tmpFullInfo.FirstName = part[firstnamePos - 1].Trim();

                        var lastnamePos = Convert.ToInt32(radTextBoxLastname.Text);
                        if (lastnamePos > 0)
                            tmpFullInfo.LastName = part[lastnamePos - 1].Trim();

                        //tmpFullInfo.Birthday = roboformBll.RandomBirthday();

                        //tmpFullInfo.Username = roboformBll.RandomUsername(tmpFullInfo.FirstName,
                        //                                                  tmpFullInfo.LastName);
                        //tmpFullInfo.Password = roboformBll.RandomPassword();

                        //tmpFullInfo.Email = string.Empty;
                        listPersonal.Add(tmpFullInfo);
                    }
                    catch (Exception exception)
                    {
                        continue;
                    }
                }
                radGridViewListCC.AutoGenerateColumns = false;
                radGridViewListCC.DataSource = listPersonal;
            }
        }

        private void RadButtonExportClick(object sender, EventArgs e)
        {
            var toolbox = new RfToolbox();
            var rootFolder = toolbox.RootUserDataDir;

            if (radRadioButtonExportToRoboForm.IsChecked)
            {
                var currentRow = radGridViewListCC.CurrentRow;
                //MessageBox.Show(currentRow.Index.ToString());
                if (currentRow != null)
                {
                    var roboform = ConvertToRf(currentRow, radCheckBoxAutoDetect.Checked);
                    roboform.SaveToFile(string.Format("{0}\\{1}", rootFolder, radTextBoxFirstname.Text));
                    toolbox.RefreshUserDataDir();
                    MessageBox.Show("Xuất thành công");
                }
            }
            if (radRadioButtonExportAllToFile.IsChecked)
            {
                if (string.IsNullOrEmpty(radBrowseEditorFolderPath.Value))
                {
                    MessageBox.Show("Bạn phải chọn thư mục xuất ra");
                    return;
                }
                var count = radGridViewListCC.Rows.Count;
                var filePathStr = string.Format("{0}\\{1}", radBrowseEditorFolderPath.Value, radTextBoxAllFileName.Text);
                for (int i = 0; i < count; i++)
                {
                    var tmpRoboform = ConvertToRf(radGridViewListCC.Rows[i], radCheckBoxAutoDetect.Checked);
                    tmpRoboform.SaveToFile(string.Format("{0}{1:D4}", filePathStr, i + 1));
                }
                MessageBox.Show("Xuất thành công");
            }
        }
        private RfIdentity ConvertToRf(GridViewRowInfo row, bool autoDetect)
        {
            if (row != null)
            {
                var roboform = new RfIdentity();
                roboform.LoadFromFile(_identityPath, "");

                if (!autoDetect)
                {
                    #region thong tin chung

                    roboform.Fields["Title"].Value = "Mr";
                    roboform.Fields["Sex"].Value = "Male";
                    var birthday = _roboFormBll.RandomBirthday();
                    roboform.Fields["Birth Day"].Value = birthday.Day.ToString();
                    roboform.Fields["Birth Month"].Value = birthday.Month.ToString();
                    roboform.Fields["Birth Year"].Value = birthday.Year.ToString();

                    #endregion

                    #region address

                    if (row.Cells["FirstName"].Value != null)
                    {
                        roboform.Fields["First Name"].Value = row.Cells["FirstName"].Value.ToString();
                    }

                    if (row.Cells["LastName"].Value != null)
                    {
                        roboform.Fields["Last Name"].Value = row.Cells["LastName"].Value.ToString();
                    }

                    if (row.Cells["Address1"].Value != null)
                    {
                        roboform.Fields["Address Line 1"].Value = row.Cells["Address1"].Value.ToString();
                    }

                    if (row.Cells["Address2"].Value != null)
                    {
                        roboform.Fields["Address Line 2"].Value = row.Cells["Address2"].Value.ToString();
                    }

                    if (row.Cells["City"].Value != null)
                    {
                        roboform.Fields["City"].Value = row.Cells["City"].Value.ToString();
                    }

                    if (row.Cells["State"].Value != null)
                    {
                        roboform.Fields["State Or Province"].Value = row.Cells["State"].Value.ToString();
                    }
                    if (row.Cells["Zipcode"].Value != null)
                    {
                        roboform.Fields["Zip Or PostCode"].Value = row.Cells["Zipcode"].Value.ToString();
                    }

                    if (row.Cells["PhoneNumber"].Value != null)
                    {
                        roboform.Fields["Phone"].Value = row.Cells["PhoneNumber"].Value.ToString();
                    }

                    #endregion

                    #region credit card

                    if (row.Cells["CardNumber"].Value != null)
                    {
                        var cardnum = row.Cells["CardNumber"].Value.ToString();
                        roboform.Fields["Card Number"].Value = cardnum;
                        if (cardnum.StartsWith("3"))
                        {
                            roboform.Fields["Card Type"].Value = "American Express";
                        }
                        else if (cardnum.StartsWith("4"))
                        {
                            roboform.Fields["Card Type"].Value = "Visa";
                        }
                        else if (cardnum.StartsWith("5"))
                        {
                            roboform.Fields["Card Type"].Value = "Master Card";
                        }
                        else if (cardnum.StartsWith("6"))
                        {
                            roboform.Fields["Card Type"].Value = "Discover";
                        }
                    }

                    if (row.Cells["Cvn"].Value != null)
                    {
                        roboform.Fields["Card Validation Code"].Value = row.Cells["Cvn"].Value.ToString();
                    }

                    if (row.Cells["ExpiredMonth"].Value != null)
                    {
                        roboform.Fields["Card Expires Month"].Value = row.Cells["ExpiredMonth"].Value.ToString();
                    }

                    if (row.Cells["ExpiredYear"].Value != null)
                    {
                        roboform.Fields["Card Expires Year"].Value = row.Cells["ExpiredYear"].Value.ToString();
                    }

                    roboform.Fields["Card User Name"].Value = string.Format("{0} {1}",
                                                                            row.Cells["FirstName"].Value,
                                                                            row.Cells["LastName"].Value);

                    #endregion

                    if (radRadioButtonAutoGenerateUser.IsChecked)
                    {
                        var randomuser = _roboFormBll.RandomUsername(roboform.Fields["First Name"].Value,
                                                                     roboform.Fields["Last Name"].Value);
                        var randompass = _roboFormBll.RandomPassword();
                        roboform.Fields["User ID"].Value = randomuser;
                        roboform.Fields["Password"].Value = randompass;
                    }
                    return roboform;
                }
                else
                {

                    return roboform;
                }


            }
            return null;
        }
    }
}
