namespace UGTools
{
    partial class RoboForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoboForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSaveSetting = new System.Windows.Forms.Button();
            this.checkBoxAutoDetect = new System.Windows.Forms.CheckBox();
            this.buttonLoadSetting = new System.Windows.Forms.Button();
            this.textBoxExSplitChar = new System.Windows.Forms.TextBox();
            this.textBoxExExpMonth = new System.Windows.Forms.TextBox();
            this.textBoxExCvn = new System.Windows.Forms.TextBox();
            this.textBoxExLastname = new System.Windows.Forms.TextBox();
            this.textBoxExAddress2 = new System.Windows.Forms.TextBox();
            this.textBoxExState = new System.Windows.Forms.TextBox();
            this.textBoxExZipcode = new System.Windows.Forms.TextBox();
            this.textBoxExCity = new System.Windows.Forms.TextBox();
            this.textBoxExPhone = new System.Windows.Forms.TextBox();
            this.textBoxExAddress1 = new System.Windows.Forms.TextBox();
            this.textBoxExFirstname = new System.Windows.Forms.TextBox();
            this.textBoxExExpYear = new System.Windows.Forms.TextBox();
            this.textBoxExCardNum = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.dgvListCC = new System.Windows.Forms.DataGridView();
            this.CardType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cvn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiredMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiredYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zipcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bgwFilterCc = new System.ComponentModel.BackgroundWorker();
            this.buttonFilterCard = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxExEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.rbtUserSameEmail = new System.Windows.Forms.RadioButton();
            this.rbtAutoGenerateUser = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxExAllFilename = new System.Windows.Forms.TextBox();
            this.textBoxExRfFilename = new System.Windows.Forms.TextBox();
            this.buttonSelectFolderPath = new System.Windows.Forms.Button();
            this.textBoxExFolderPath = new System.Windows.Forms.TextBox();
            this.rbtExportAllToFile = new System.Windows.Forms.RadioButton();
            this.rbtExportToRoboForm = new System.Windows.Forms.RadioButton();
            this.fbdSavedPath = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonExport = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCC)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSaveSetting);
            this.groupBox1.Controls.Add(this.checkBoxAutoDetect);
            this.groupBox1.Controls.Add(this.buttonLoadSetting);
            this.groupBox1.Controls.Add(this.textBoxExSplitChar);
            this.groupBox1.Controls.Add(this.textBoxExExpMonth);
            this.groupBox1.Controls.Add(this.textBoxExCvn);
            this.groupBox1.Controls.Add(this.textBoxExLastname);
            this.groupBox1.Controls.Add(this.textBoxExAddress2);
            this.groupBox1.Controls.Add(this.textBoxExState);
            this.groupBox1.Controls.Add(this.textBoxExZipcode);
            this.groupBox1.Controls.Add(this.textBoxExCity);
            this.groupBox1.Controls.Add(this.textBoxExPhone);
            this.groupBox1.Controls.Add(this.textBoxExAddress1);
            this.groupBox1.Controls.Add(this.textBoxExFirstname);
            this.groupBox1.Controls.Add(this.textBoxExExpYear);
            this.groupBox1.Controls.Add(this.textBoxExCardNum);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 399);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // buttonSaveSetting
            // 
            this.buttonSaveSetting.Location = new System.Drawing.Point(61, 337);
            this.buttonSaveSetting.Name = "buttonSaveSetting";
            this.buttonSaveSetting.Size = new System.Drawing.Size(40, 21);
            this.buttonSaveSetting.TabIndex = 16;
            this.buttonSaveSetting.Text = "Save";
            this.buttonSaveSetting.UseVisualStyleBackColor = true;
            this.buttonSaveSetting.Click += new System.EventHandler(this.ButtonSaveSettingClick);
            // 
            // checkBoxAutoDetect
            // 
            this.checkBoxAutoDetect.AutoSize = true;
            this.checkBoxAutoDetect.Location = new System.Drawing.Point(4, 367);
            this.checkBoxAutoDetect.Name = "checkBoxAutoDetect";
            this.checkBoxAutoDetect.Size = new System.Drawing.Size(110, 17);
            this.checkBoxAutoDetect.TabIndex = 15;
            this.checkBoxAutoDetect.Text = "Tự nhận dạng CC";
            this.checkBoxAutoDetect.UseVisualStyleBackColor = true;
            // 
            // buttonLoadSetting
            // 
            this.buttonLoadSetting.Location = new System.Drawing.Point(15, 337);
            this.buttonLoadSetting.Name = "buttonLoadSetting";
            this.buttonLoadSetting.Size = new System.Drawing.Size(40, 21);
            this.buttonLoadSetting.TabIndex = 14;
            this.buttonLoadSetting.Text = "Load";
            this.buttonLoadSetting.UseVisualStyleBackColor = true;
            this.buttonLoadSetting.Click += new System.EventHandler(this.ButtonLoadSettingClick);
            // 
            // textBoxExSplitChar
            // 
            this.textBoxExSplitChar.Location = new System.Drawing.Point(80, 308);
            this.textBoxExSplitChar.Name = "textBoxExSplitChar";
            this.textBoxExSplitChar.Size = new System.Drawing.Size(30, 20);
            this.textBoxExSplitChar.TabIndex = 13;
            this.textBoxExSplitChar.Text = "|";
            this.textBoxExSplitChar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxExExpMonth
            // 
            this.textBoxExExpMonth.Location = new System.Drawing.Point(80, 62);
            this.textBoxExExpMonth.Name = "textBoxExExpMonth";
            this.textBoxExExpMonth.Size = new System.Drawing.Size(30, 20);
            this.textBoxExExpMonth.TabIndex = 3;
            this.textBoxExExpMonth.Text = "3";
            this.textBoxExExpMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxExCvn
            // 
            this.textBoxExCvn.Location = new System.Drawing.Point(80, 39);
            this.textBoxExCvn.Name = "textBoxExCvn";
            this.textBoxExCvn.Size = new System.Drawing.Size(30, 20);
            this.textBoxExCvn.TabIndex = 2;
            this.textBoxExCvn.Text = "2";
            this.textBoxExCvn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxExLastname
            // 
            this.textBoxExLastname.Location = new System.Drawing.Point(80, 132);
            this.textBoxExLastname.Name = "textBoxExLastname";
            this.textBoxExLastname.Size = new System.Drawing.Size(30, 20);
            this.textBoxExLastname.TabIndex = 6;
            this.textBoxExLastname.Text = "6";
            this.textBoxExLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxExAddress2
            // 
            this.textBoxExAddress2.Location = new System.Drawing.Point(80, 178);
            this.textBoxExAddress2.Name = "textBoxExAddress2";
            this.textBoxExAddress2.Size = new System.Drawing.Size(30, 20);
            this.textBoxExAddress2.TabIndex = 8;
            this.textBoxExAddress2.Text = "8";
            this.textBoxExAddress2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxExState
            // 
            this.textBoxExState.Location = new System.Drawing.Point(80, 248);
            this.textBoxExState.Name = "textBoxExState";
            this.textBoxExState.Size = new System.Drawing.Size(30, 20);
            this.textBoxExState.TabIndex = 11;
            this.textBoxExState.Text = "11";
            this.textBoxExState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxExZipcode
            // 
            this.textBoxExZipcode.Location = new System.Drawing.Point(80, 225);
            this.textBoxExZipcode.Name = "textBoxExZipcode";
            this.textBoxExZipcode.Size = new System.Drawing.Size(30, 20);
            this.textBoxExZipcode.TabIndex = 10;
            this.textBoxExZipcode.Text = "10";
            this.textBoxExZipcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxExCity
            // 
            this.textBoxExCity.Location = new System.Drawing.Point(80, 201);
            this.textBoxExCity.Name = "textBoxExCity";
            this.textBoxExCity.Size = new System.Drawing.Size(30, 20);
            this.textBoxExCity.TabIndex = 9;
            this.textBoxExCity.Text = "9";
            this.textBoxExCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxExPhone
            // 
            this.textBoxExPhone.Location = new System.Drawing.Point(80, 271);
            this.textBoxExPhone.Name = "textBoxExPhone";
            this.textBoxExPhone.Size = new System.Drawing.Size(30, 20);
            this.textBoxExPhone.TabIndex = 12;
            this.textBoxExPhone.Text = "12";
            this.textBoxExPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxExAddress1
            // 
            this.textBoxExAddress1.Location = new System.Drawing.Point(80, 155);
            this.textBoxExAddress1.Name = "textBoxExAddress1";
            this.textBoxExAddress1.Size = new System.Drawing.Size(30, 20);
            this.textBoxExAddress1.TabIndex = 7;
            this.textBoxExAddress1.Text = "7";
            this.textBoxExAddress1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxExFirstname
            // 
            this.textBoxExFirstname.Location = new System.Drawing.Point(80, 109);
            this.textBoxExFirstname.Name = "textBoxExFirstname";
            this.textBoxExFirstname.Size = new System.Drawing.Size(30, 20);
            this.textBoxExFirstname.TabIndex = 5;
            this.textBoxExFirstname.Text = "5";
            this.textBoxExFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxExExpYear
            // 
            this.textBoxExExpYear.Location = new System.Drawing.Point(80, 85);
            this.textBoxExExpYear.Name = "textBoxExExpYear";
            this.textBoxExExpYear.Size = new System.Drawing.Size(30, 20);
            this.textBoxExExpYear.TabIndex = 4;
            this.textBoxExExpYear.Text = "4";
            this.textBoxExExpYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxExCardNum
            // 
            this.textBoxExCardNum.Location = new System.Drawing.Point(80, 16);
            this.textBoxExCardNum.Name = "textBoxExCardNum";
            this.textBoxExCardNum.Size = new System.Drawing.Size(30, 20);
            this.textBoxExCardNum.TabIndex = 1;
            this.textBoxExCardNum.Text = "1";
            this.textBoxExCardNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 311);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Split Char";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Cvn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "City";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "State";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Exp Month";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Zipcode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Last name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Exp Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Card Num";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 422);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(730, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(140, 9);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(600, 140);
            this.textBoxInput.TabIndex = 2;
            this.textBoxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxInputKeyDown);
            // 
            // dgvListCC
            // 
            this.dgvListCC.AllowUserToAddRows = false;
            this.dgvListCC.AllowUserToDeleteRows = false;
            this.dgvListCC.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvListCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CardType,
            this.CardNumber,
            this.Cvn,
            this.ExpiredMonth,
            this.ExpiredYear,
            this.FirstName,
            this.LastName,
            this.Address1,
            this.Address2,
            this.City,
            this.State,
            this.Zipcode,
            this.PhoneNumber});
            this.dgvListCC.Location = new System.Drawing.Point(140, 167);
            this.dgvListCC.Name = "dgvListCC";
            this.dgvListCC.ReadOnly = true;
            this.dgvListCC.Size = new System.Drawing.Size(600, 139);
            this.dgvListCC.TabIndex = 3;
            // 
            // CardType
            // 
            this.CardType.DataPropertyName = "CardType";
            this.CardType.HeaderText = "CardType";
            this.CardType.Name = "CardType";
            this.CardType.ReadOnly = true;
            // 
            // CardNumber
            // 
            this.CardNumber.DataPropertyName = "CardNumber";
            this.CardNumber.HeaderText = "Cardnum";
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.ReadOnly = true;
            // 
            // Cvn
            // 
            this.Cvn.DataPropertyName = "Cvn";
            this.Cvn.HeaderText = "Cvn";
            this.Cvn.Name = "Cvn";
            this.Cvn.ReadOnly = true;
            // 
            // ExpiredMonth
            // 
            this.ExpiredMonth.DataPropertyName = "ExpiredMonth";
            this.ExpiredMonth.HeaderText = "Month";
            this.ExpiredMonth.Name = "ExpiredMonth";
            this.ExpiredMonth.ReadOnly = true;
            // 
            // ExpiredYear
            // 
            this.ExpiredYear.DataPropertyName = "ExpiredYear";
            this.ExpiredYear.HeaderText = "Year";
            this.ExpiredYear.Name = "ExpiredYear";
            this.ExpiredYear.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Address1
            // 
            this.Address1.DataPropertyName = "Address1";
            this.Address1.HeaderText = "Address1";
            this.Address1.Name = "Address1";
            this.Address1.ReadOnly = true;
            // 
            // Address2
            // 
            this.Address2.DataPropertyName = "Address2";
            this.Address2.HeaderText = "Address2";
            this.Address2.Name = "Address2";
            this.Address2.ReadOnly = true;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "State";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // Zipcode
            // 
            this.Zipcode.DataPropertyName = "Zipcode";
            this.Zipcode.HeaderText = "Zipcode";
            this.Zipcode.Name = "Zipcode";
            this.Zipcode.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Phone";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // bgwFilterCc
            // 
            this.bgwFilterCc.WorkerReportsProgress = true;
            this.bgwFilterCc.WorkerSupportsCancellation = true;
            this.bgwFilterCc.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwFilterCcDoWork);
            // 
            // buttonFilterCard
            // 
            this.buttonFilterCard.Location = new System.Drawing.Point(670, 387);
            this.buttonFilterCard.Name = "buttonFilterCard";
            this.buttonFilterCard.Size = new System.Drawing.Size(75, 21);
            this.buttonFilterCard.TabIndex = 4;
            this.buttonFilterCard.Text = "Lọc CC";
            this.buttonFilterCard.UseVisualStyleBackColor = true;
            this.buttonFilterCard.Click += new System.EventHandler(this.ButtonFilterCardClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxExEmail);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.rbtUserSameEmail);
            this.groupBox2.Controls.Add(this.rbtAutoGenerateUser);
            this.groupBox2.Location = new System.Drawing.Point(140, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 88);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Authenticate";
            // 
            // textBoxExEmail
            // 
            this.textBoxExEmail.Location = new System.Drawing.Point(45, 62);
            this.textBoxExEmail.Name = "textBoxExEmail";
            this.textBoxExEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxExEmail.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Email";
            // 
            // rbtUserSameEmail
            // 
            this.rbtUserSameEmail.AutoSize = true;
            this.rbtUserSameEmail.Location = new System.Drawing.Point(5, 42);
            this.rbtUserSameEmail.Name = "rbtUserSameEmail";
            this.rbtUserSameEmail.Size = new System.Drawing.Size(103, 17);
            this.rbtUserSameEmail.TabIndex = 1;
            this.rbtUserSameEmail.Text = "Username=email";
            this.rbtUserSameEmail.UseVisualStyleBackColor = true;
            // 
            // rbtAutoGenerateUser
            // 
            this.rbtAutoGenerateUser.AutoSize = true;
            this.rbtAutoGenerateUser.Checked = true;
            this.rbtAutoGenerateUser.Location = new System.Drawing.Point(5, 19);
            this.rbtAutoGenerateUser.Name = "rbtAutoGenerateUser";
            this.rbtAutoGenerateUser.Size = new System.Drawing.Size(105, 17);
            this.rbtAutoGenerateUser.TabIndex = 0;
            this.rbtAutoGenerateUser.TabStop = true;
            this.rbtAutoGenerateUser.Text = "Tự tạo username";
            this.rbtAutoGenerateUser.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.textBoxExAllFilename);
            this.groupBox3.Controls.Add(this.textBoxExRfFilename);
            this.groupBox3.Controls.Add(this.buttonSelectFolderPath);
            this.groupBox3.Controls.Add(this.textBoxExFolderPath);
            this.groupBox3.Controls.Add(this.rbtExportAllToFile);
            this.groupBox3.Controls.Add(this.rbtExportToRoboForm);
            this.groupBox3.Location = new System.Drawing.Point(300, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 93);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Roboform";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(170, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "(1...n)";
            // 
            // textBoxExAllFilename
            // 
            this.textBoxExAllFilename.Location = new System.Drawing.Point(130, 40);
            this.textBoxExAllFilename.Name = "textBoxExAllFilename";
            this.textBoxExAllFilename.Size = new System.Drawing.Size(40, 20);
            this.textBoxExAllFilename.TabIndex = 12;
            this.textBoxExAllFilename.Text = "AA";
            this.textBoxExAllFilename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxExRfFilename
            // 
            this.textBoxExRfFilename.Location = new System.Drawing.Point(130, 17);
            this.textBoxExRfFilename.Name = "textBoxExRfFilename";
            this.textBoxExRfFilename.Size = new System.Drawing.Size(40, 20);
            this.textBoxExRfFilename.TabIndex = 11;
            this.textBoxExRfFilename.Text = "AA";
            this.textBoxExRfFilename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSelectFolderPath
            // 
            this.buttonSelectFolderPath.Location = new System.Drawing.Point(130, 61);
            this.buttonSelectFolderPath.Name = "buttonSelectFolderPath";
            this.buttonSelectFolderPath.Size = new System.Drawing.Size(75, 21);
            this.buttonSelectFolderPath.TabIndex = 9;
            this.buttonSelectFolderPath.Text = "Chọn folder";
            this.buttonSelectFolderPath.UseVisualStyleBackColor = true;
            this.buttonSelectFolderPath.Click += new System.EventHandler(this.ButtonSelectFolderPathClick);
            // 
            // textBoxExFolderPath
            // 
            this.textBoxExFolderPath.Location = new System.Drawing.Point(5, 62);
            this.textBoxExFolderPath.Name = "textBoxExFolderPath";
            this.textBoxExFolderPath.Size = new System.Drawing.Size(120, 20);
            this.textBoxExFolderPath.TabIndex = 8;
            // 
            // rbtExportAllToFile
            // 
            this.rbtExportAllToFile.AutoSize = true;
            this.rbtExportAllToFile.Location = new System.Drawing.Point(5, 42);
            this.rbtExportAllToFile.Name = "rbtExportAllToFile";
            this.rbtExportAllToFile.Size = new System.Drawing.Size(105, 17);
            this.rbtExportAllToFile.TabIndex = 1;
            this.rbtExportAllToFile.Text = "Xuất tất cả ra file";
            this.rbtExportAllToFile.UseVisualStyleBackColor = true;
            // 
            // rbtExportToRoboForm
            // 
            this.rbtExportToRoboForm.AutoSize = true;
            this.rbtExportToRoboForm.Checked = true;
            this.rbtExportToRoboForm.Location = new System.Drawing.Point(5, 19);
            this.rbtExportToRoboForm.Name = "rbtExportToRoboForm";
            this.rbtExportToRoboForm.Size = new System.Drawing.Size(111, 17);
            this.rbtExportToRoboForm.TabIndex = 0;
            this.rbtExportToRoboForm.TabStop = true;
            this.rbtExportToRoboForm.Text = "Xuất ra RoboForm";
            this.rbtExportToRoboForm.UseVisualStyleBackColor = true;
            // 
            // fbdSavedPath
            // 
            this.fbdSavedPath.Description = "Thư mục lưu file";
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(670, 346);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 21);
            this.buttonExport.TabIndex = 7;
            this.buttonExport.Text = "Xuất";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.ButtonExportClick);
            // 
            // RoboForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 457);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonFilterCard);
            this.Controls.Add(this.dgvListCC);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RoboForm";
            this.Text = "RoboForm";
            this.Load += new System.EventHandler(this.RoboFormLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCC)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxExCardNum;
        private System.Windows.Forms.TextBox textBoxExExpMonth;
        private System.Windows.Forms.TextBox textBoxExCvn;
        private System.Windows.Forms.TextBox textBoxExLastname;
        private System.Windows.Forms.TextBox textBoxExAddress2;
        private System.Windows.Forms.TextBox textBoxExState;
        private System.Windows.Forms.TextBox textBoxExZipcode;
        private System.Windows.Forms.TextBox textBoxExCity;
        private System.Windows.Forms.TextBox textBoxExPhone;
        private System.Windows.Forms.TextBox textBoxExAddress1;
        private System.Windows.Forms.TextBox textBoxExFirstname;
        private System.Windows.Forms.TextBox textBoxExExpYear;
        private System.Windows.Forms.TextBox textBoxExSplitChar;
        private System.Windows.Forms.Button buttonLoadSetting;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.CheckBox checkBoxAutoDetect;
        private System.ComponentModel.BackgroundWorker bgwFilterCc;
        private System.Windows.Forms.Button buttonFilterCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cvn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiredMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiredYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address2;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zipcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridView dgvListCC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtAutoGenerateUser;
        private System.Windows.Forms.RadioButton rbtUserSameEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxExEmail;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtExportToRoboForm;
        private System.Windows.Forms.RadioButton rbtExportAllToFile;
        private System.Windows.Forms.TextBox textBoxExFolderPath;
        private System.Windows.Forms.Button buttonSelectFolderPath;
        private System.Windows.Forms.TextBox textBoxExRfFilename;
        private System.Windows.Forms.FolderBrowserDialog fbdSavedPath;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxExAllFilename;
        private System.Windows.Forms.Button buttonSaveSetting;
        private System.Windows.Forms.ToolTip toolTip;
    }
}