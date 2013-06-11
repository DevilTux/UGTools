using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ROBOFORMLib;
using UGTools.BusinessLogic;
using UGTools.DataAccess;
using UGTools.Controls;
using UGTools.Entity;
using System.IO;
namespace UGTools
{
    public partial class RoboForm : Form
    {
        private readonly string _identityPath = Application.StartupPath + "\\Config\\ducmami";
        private readonly RoboFormBll _roboFormBll = new RoboFormBll();
        private readonly string _intPath = string.Format("{0}\\Config\\Roboform.ini", Application.StartupPath);
        public RoboForm()
        {
            InitializeComponent();
        }
        private void RoboFormLoad(object sender, EventArgs e)
        {
            LoadToolTip();
        }

        private void ButtonLoadSettingClick(object sender, EventArgs e)
        {
            if (File.Exists(_intPath))
            {
                var iniSetting = new IniFile(_intPath);
                textBoxExCardNum.Text = iniSetting.IniReadValue("CardInfo", "CardNumPos");
                textBoxExCvn.Text = iniSetting.IniReadValue("CardInfo", "CvnPos");
                textBoxExExpMonth.Text = iniSetting.IniReadValue("CardInfo", "ExpMonthPos");
                textBoxExExpYear.Text = iniSetting.IniReadValue("CardInfo", "ExpYearPos");
                textBoxExFirstname.Text = iniSetting.IniReadValue("CardInfo", "FirstnamePos");
                textBoxExLastname.Text = iniSetting.IniReadValue("CardInfo", "LastnamePos");
                textBoxExAddress1.Text = iniSetting.IniReadValue("CardInfo", "Address1Pos");
                textBoxExAddress2.Text = iniSetting.IniReadValue("CardInfo", "Address2Pos");
                textBoxExCity.Text = iniSetting.IniReadValue("CardInfo", "CityPos");
                textBoxExZipcode.Text = iniSetting.IniReadValue("CardInfo", "ZipcodePos");
                textBoxExState.Text = iniSetting.IniReadValue("CardInfo", "StatePos");
                textBoxExPhone.Text = iniSetting.IniReadValue("CardInfo", "PhonePos");
                textBoxExSplitChar.Text = iniSetting.IniReadValue("CardInfo", "SplitChar");
            }
        }
        private void ButtonSaveSettingClick(object sender, EventArgs e)
        {
            if (!File.Exists(_intPath))
            {
                File.Create(_intPath);
            }
            var iniSetting = new IniFile(_intPath);
            iniSetting.IniWriteValue("CardInfo", "CardNumPos", textBoxExCardNum.Text);
            iniSetting.IniWriteValue("CardInfo", "CvnPos", textBoxExCvn.Text);
            iniSetting.IniWriteValue("CardInfo", "ExpMonthPos", textBoxExExpMonth.Text);
            iniSetting.IniWriteValue("CardInfo", "ExpYearPos", textBoxExExpYear.Text);
            iniSetting.IniWriteValue("CardInfo", "FirstnamePos", textBoxExFirstname.Text);
            iniSetting.IniWriteValue("CardInfo", "LastnamePos", textBoxExLastname.Text);
            iniSetting.IniWriteValue("CardInfo", "Address1Pos", textBoxExAddress1.Text);
            iniSetting.IniWriteValue("CardInfo", "Address2Pos", textBoxExAddress2.Text);
            iniSetting.IniWriteValue("CardInfo", "CityPos", textBoxExCity.Text);
            iniSetting.IniWriteValue("CardInfo", "ZipcodePos", textBoxExZipcode.Text);
            iniSetting.IniWriteValue("CardInfo", "StatePos", textBoxExState.Text);
            iniSetting.IniWriteValue("CardInfo", "PhonePos", textBoxExPhone.Text);
            iniSetting.IniWriteValue("CardInfo", "SplitChar", textBoxExSplitChar.Text);

        }
        private void TextBoxInputKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode==Keys.A)
            {
                textBoxInput.SelectAll();
            }
        }

        private void BgwFilterCcDoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void ButtonFilterCardClick(object sender, EventArgs e)
        {
            //bgwFilterCc.RunWorkerAsync();
            var listPersonal = new List<FullInfo>();
            var count = textBoxInput.Lines.Count();
            var roboformBll = new RoboFormBll();
            if (checkBoxAutoDetect.Checked)
            {

            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    try
                    {
                        var line = textBoxInput.Lines[i];
                        var part = line.Split(Convert.ToChar(textBoxExSplitChar.Text));
                        var tmpFullInfo = new FullInfo();

                        #region cc info

                        var cardNumPos = Convert.ToInt32(textBoxExCardNum.Text);
                        if (cardNumPos > 0)
                            tmpFullInfo.CardNumber = part[cardNumPos - 1].Trim();

                        var cvnPos = Convert.ToInt32(textBoxExCvn.Text);
                        if (cvnPos > 0)
                            tmpFullInfo.Cvn = Convert.ToInt32(part[cvnPos - 1].Trim());

                        var expMonthPos = Convert.ToInt32(textBoxExExpMonth.Text);
                        if (expMonthPos > 0)
                            tmpFullInfo.ExpiredMonth = part[expMonthPos - 1].Trim();

                        var expYearPos = Convert.ToInt32(textBoxExExpYear.Text);
                        if (expYearPos > 0)
                            tmpFullInfo.ExpiredYear = part[expYearPos - 1].Trim();

                        #endregion

                        #region address

                        var address1Pos = Convert.ToInt32(textBoxExAddress1.Text);
                        if (address1Pos > 0)
                            tmpFullInfo.Address1 = part[address1Pos - 1].Trim();

                        var address2Pos = Convert.ToInt32(textBoxExAddress2.Text);
                        if (address2Pos > 0)
                            tmpFullInfo.Address2 = part[address2Pos - 1].Trim();

                        var cityPos = Convert.ToInt32(textBoxExCity.Text);
                        if (cityPos > 0)
                            tmpFullInfo.City = part[cityPos - 1].Trim();

                        var statePos = Convert.ToInt32(textBoxExState.Text);
                        if (statePos > 0)
                            tmpFullInfo.State = part[statePos - 1].Trim();

                        var zipcodePos = Convert.ToInt32(textBoxExZipcode.Text);
                        if (zipcodePos > 0)
                            tmpFullInfo.Zipcode = part[zipcodePos - 1].Trim();

                        var phonePos = Convert.ToInt32(textBoxExPhone.Text);
                        if (phonePos > 0)
                            tmpFullInfo.PhoneNumber = part[phonePos - 1].Trim();

                        #endregion

                        #region account

                        #endregion

                        var firstnamePos = Convert.ToInt32(textBoxExFirstname.Text);
                        if (firstnamePos > 0)
                            tmpFullInfo.FirstName = part[firstnamePos - 1].Trim();

                        var lastnamePos = Convert.ToInt32(textBoxExLastname.Text);
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
                dgvListCC.AutoGenerateColumns = false;
                dgvListCC.DataSource = listPersonal;
            }
        }

        private void ButtonSelectFolderPathClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxExFolderPath.Text))
            {
                fbdSavedPath.SelectedPath = textBoxExFolderPath.Text;
            }
            if (fbdSavedPath.ShowDialog()==DialogResult.OK)
            {
                textBoxExFolderPath.Text = fbdSavedPath.SelectedPath;
            }
        }

        private void ButtonExportClick(object sender, EventArgs e)
        {
            //MessageBox.Show(string.Format("{0:D4}", 31));
            
            var toolbox = new RfToolbox();
            var rootFolder = toolbox.RootUserDataDir;

            if (rbtExportToRoboForm.Checked)
            {
                var currentRow = dgvListCC.CurrentRow;
                //MessageBox.Show(currentRow.Index.ToString());
                if (currentRow!=null)
                {
                    var roboform = ConvertToRf(currentRow, checkBoxAutoDetect.Checked);
                    roboform.SaveToFile(string.Format("{0}\\{1}", rootFolder, textBoxExRfFilename.Text));
                    toolbox.RefreshUserDataDir();
                    MessageBox.Show("Xuất thành công");
                }
            }
            if (rbtExportAllToFile.Checked)
            {
                if (string.IsNullOrEmpty(textBoxExFolderPath.Text))
                {
                    MessageBox.Show("Bạn phải chọn thư mục xuất ra");
                    return;
                }
                var count = dgvListCC.Rows.Count;
                var filePathStr = string.Format("{0}\\{1}",textBoxExFolderPath.Text,textBoxExAllFilename.Text);
                for (int i = 0; i < count; i++)
                {
                    var tmpRoboform = ConvertToRf(dgvListCC.Rows[i], checkBoxAutoDetect.Checked);
                    tmpRoboform.SaveToFile(string.Format("{0}{1:D4}", filePathStr,i+1));
                }
                MessageBox.Show("Xuất thành công");
            }
        }

        private RfIdentity ConvertToRf(DataGridViewRow row, bool autoDetect)
        {
            if (row!=null)
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
                    
                    if (rbtAutoGenerateUser.Checked)
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
        private void LoadToolTip()
        {
            toolTip.SetToolTip(textBoxExRfFilename, "Tên file bạn muốn xuất ra RoboForm");
            toolTip.SetToolTip(textBoxExAllFilename, "Tên file bạn muốn xuất tất cả ra\r\nVD:AA --> AA0000,AA0001...,AA000n");
            toolTip.SetToolTip(textBoxExFolderPath, "Thư mục lưu file");
            toolTip.SetToolTip(textBoxExFolderPath, "");
            toolTip.SetToolTip(textBoxExFolderPath, "");

        }

        
    }
}
