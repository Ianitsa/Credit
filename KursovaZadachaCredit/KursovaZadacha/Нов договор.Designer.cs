namespace KursovaZadacha
{
    partial class frmNewContract
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
            this.gbMainDate = new System.Windows.Forms.GroupBox();
            this.lblClientID = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnMan = new System.Windows.Forms.RadioButton();
            this.rbtnWaman = new System.Windows.Forms.RadioButton();
            this.rbtnFL = new System.Windows.Forms.RadioButton();
            this.rbtnJL = new System.Windows.Forms.RadioButton();
            this.txtTel_contr = new System.Windows.Forms.TextBox();
            this.txtAddressContract = new System.Windows.Forms.TextBox();
            this.txtE_mail_contr = new System.Windows.Forms.TextBox();
            this.txtBULSTAT_Contr = new System.Windows.Forms.TextBox();
            this.txtFirmName = new System.Windows.Forms.TextBox();
            this.txtEGN_contr = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtNoContract = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDateOfCredit = new System.Windows.Forms.GroupBox();
            this.cb_credit_contr = new System.Windows.Forms.ComboBox();
            this.btnIzchisli = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtPurposeCredit_contr = new System.Windows.Forms.TextBox();
            this.txtWantValue = new System.Windows.Forms.TextBox();
            this.txtEndContract_contr = new System.Windows.Forms.TextBox();
            this.cbLimit = new System.Windows.Forms.ComboBox();
            this.txtBeginContract_contr = new System.Windows.Forms.TextBox();
            this.lblPurposeCredit_contr = new System.Windows.Forms.Label();
            this.lblWantValue = new System.Windows.Forms.Label();
            this.lblEndContract_contr = new System.Windows.Forms.Label();
            this.lblBeginContract_contr = new System.Windows.Forms.Label();
            this.lblLimit = new System.Windows.Forms.Label();
            this.lblCredit_contr = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gbCreditPlan = new System.Windows.Forms.GroupBox();
            this.dtpMaturity = new System.Windows.Forms.DateTimePicker();
            this.txtSizePayment = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtNumPayment = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSizePayment = new System.Windows.Forms.Label();
            this.lblMaturity = new System.Windows.Forms.Label();
            this.lblNumPayment = new System.Windows.Forms.Label();
            this.btnSaveContract = new System.Windows.Forms.Button();
            this.btnReviewContract = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ianiDataSet = new KursovaZadacha.ianiDataSet();
            this.cREDITPRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cREDIT_PRODUCTTableAdapter = new KursovaZadacha.ianiDataSetTableAdapters.CREDIT_PRODUCTTableAdapter();
            this.gbMainDate.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbDateOfCredit.SuspendLayout();
            this.gbCreditPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ianiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREDITPRODUCTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMainDate
            // 
            this.gbMainDate.Controls.Add(this.lblClientID);
            this.gbMainDate.Controls.Add(this.txtClientID);
            this.gbMainDate.Controls.Add(this.panel1);
            this.gbMainDate.Controls.Add(this.rbtnFL);
            this.gbMainDate.Controls.Add(this.rbtnJL);
            this.gbMainDate.Controls.Add(this.txtTel_contr);
            this.gbMainDate.Controls.Add(this.txtAddressContract);
            this.gbMainDate.Controls.Add(this.txtE_mail_contr);
            this.gbMainDate.Controls.Add(this.txtBULSTAT_Contr);
            this.gbMainDate.Controls.Add(this.txtFirmName);
            this.gbMainDate.Controls.Add(this.txtEGN_contr);
            this.gbMainDate.Controls.Add(this.txtFullName);
            this.gbMainDate.Controls.Add(this.txtNoContract);
            this.gbMainDate.Controls.Add(this.label10);
            this.gbMainDate.Controls.Add(this.label9);
            this.gbMainDate.Controls.Add(this.label8);
            this.gbMainDate.Controls.Add(this.label7);
            this.gbMainDate.Controls.Add(this.label6);
            this.gbMainDate.Controls.Add(this.label5);
            this.gbMainDate.Controls.Add(this.label4);
            this.gbMainDate.Controls.Add(this.label3);
            this.gbMainDate.Controls.Add(this.label2);
            this.gbMainDate.Controls.Add(this.label1);
            this.gbMainDate.Location = new System.Drawing.Point(6, 12);
            this.gbMainDate.Name = "gbMainDate";
            this.gbMainDate.Size = new System.Drawing.Size(327, 393);
            this.gbMainDate.TabIndex = 0;
            this.gbMainDate.TabStop = false;
            this.gbMainDate.Text = "Основни данни";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(10, 49);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(57, 13);
            this.lblClientID.TabIndex = 35;
            this.lblClientID.Text = "Клиент №";
            this.lblClientID.Visible = false;
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(126, 46);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(100, 20);
            this.txtClientID.TabIndex = 34;
            this.txtClientID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnMan);
            this.panel1.Controls.Add(this.rbtnWaman);
            this.panel1.Location = new System.Drawing.Point(104, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 33);
            this.panel1.TabIndex = 32;
            // 
            // rbtnMan
            // 
            this.rbtnMan.AutoSize = true;
            this.rbtnMan.Location = new System.Drawing.Point(103, 3);
            this.rbtnMan.Name = "rbtnMan";
            this.rbtnMan.Size = new System.Drawing.Size(49, 17);
            this.rbtnMan.TabIndex = 30;
            this.rbtnMan.Text = "Мъж";
            this.rbtnMan.UseVisualStyleBackColor = true;
            this.rbtnMan.Visible = false;
            // 
            // rbtnWaman
            // 
            this.rbtnWaman.AutoSize = true;
            this.rbtnWaman.Checked = true;
            this.rbtnWaman.Location = new System.Drawing.Point(23, 3);
            this.rbtnWaman.Name = "rbtnWaman";
            this.rbtnWaman.Size = new System.Drawing.Size(54, 17);
            this.rbtnWaman.TabIndex = 29;
            this.rbtnWaman.TabStop = true;
            this.rbtnWaman.Text = "Жена";
            this.rbtnWaman.UseVisualStyleBackColor = true;
            this.rbtnWaman.Visible = false;
            // 
            // rbtnFL
            // 
            this.rbtnFL.AutoSize = true;
            this.rbtnFL.Checked = true;
            this.rbtnFL.Location = new System.Drawing.Point(182, 67);
            this.rbtnFL.Name = "rbtnFL";
            this.rbtnFL.Size = new System.Drawing.Size(44, 17);
            this.rbtnFL.TabIndex = 31;
            this.rbtnFL.TabStop = true;
            this.rbtnFL.Text = "ФЛ";
            this.rbtnFL.UseVisualStyleBackColor = true;
            // 
            // rbtnJL
            // 
            this.rbtnJL.AutoSize = true;
            this.rbtnJL.Location = new System.Drawing.Point(130, 70);
            this.rbtnJL.Name = "rbtnJL";
            this.rbtnJL.Size = new System.Drawing.Size(42, 17);
            this.rbtnJL.TabIndex = 30;
            this.rbtnJL.Text = "ЮЛ";
            this.rbtnJL.UseVisualStyleBackColor = true;
            // 
            // txtTel_contr
            // 
            this.txtTel_contr.Location = new System.Drawing.Point(110, 355);
            this.txtTel_contr.Name = "txtTel_contr";
            this.txtTel_contr.Size = new System.Drawing.Size(100, 20);
            this.txtTel_contr.TabIndex = 17;
            // 
            // txtAddressContract
            // 
            this.txtAddressContract.Location = new System.Drawing.Point(110, 323);
            this.txtAddressContract.Name = "txtAddressContract";
            this.txtAddressContract.Size = new System.Drawing.Size(100, 20);
            this.txtAddressContract.TabIndex = 16;
            // 
            // txtE_mail_contr
            // 
            this.txtE_mail_contr.Location = new System.Drawing.Point(110, 293);
            this.txtE_mail_contr.Name = "txtE_mail_contr";
            this.txtE_mail_contr.Size = new System.Drawing.Size(100, 20);
            this.txtE_mail_contr.TabIndex = 15;
            // 
            // txtBULSTAT_Contr
            // 
            this.txtBULSTAT_Contr.Location = new System.Drawing.Point(110, 258);
            this.txtBULSTAT_Contr.Name = "txtBULSTAT_Contr";
            this.txtBULSTAT_Contr.Size = new System.Drawing.Size(100, 20);
            this.txtBULSTAT_Contr.TabIndex = 14;
            // 
            // txtFirmName
            // 
            this.txtFirmName.Location = new System.Drawing.Point(110, 219);
            this.txtFirmName.Name = "txtFirmName";
            this.txtFirmName.Size = new System.Drawing.Size(100, 20);
            this.txtFirmName.TabIndex = 13;
            // 
            // txtEGN_contr
            // 
            this.txtEGN_contr.Location = new System.Drawing.Point(126, 133);
            this.txtEGN_contr.Name = "txtEGN_contr";
            this.txtEGN_contr.Size = new System.Drawing.Size(100, 20);
            this.txtEGN_contr.TabIndex = 12;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(126, 96);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 20);
            this.txtFullName.TabIndex = 11;
            // 
            // txtNoContract
            // 
            this.txtNoContract.Location = new System.Drawing.Point(126, 20);
            this.txtNoContract.Name = "txtNoContract";
            this.txtNoContract.Size = new System.Drawing.Size(100, 20);
            this.txtNoContract.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Телефон";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Адрес";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "E-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Булстат";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Име на фирма";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Пол";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ЕГН";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Име и фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер на договор";
            // 
            // gbDateOfCredit
            // 
            this.gbDateOfCredit.Controls.Add(this.cb_credit_contr);
            this.gbDateOfCredit.Controls.Add(this.btnIzchisli);
            this.gbDateOfCredit.Controls.Add(this.dateTimePicker1);
            this.gbDateOfCredit.Controls.Add(this.txtPurposeCredit_contr);
            this.gbDateOfCredit.Controls.Add(this.txtWantValue);
            this.gbDateOfCredit.Controls.Add(this.txtEndContract_contr);
            this.gbDateOfCredit.Controls.Add(this.cbLimit);
            this.gbDateOfCredit.Controls.Add(this.txtBeginContract_contr);
            this.gbDateOfCredit.Controls.Add(this.lblPurposeCredit_contr);
            this.gbDateOfCredit.Controls.Add(this.lblWantValue);
            this.gbDateOfCredit.Controls.Add(this.lblEndContract_contr);
            this.gbDateOfCredit.Controls.Add(this.lblBeginContract_contr);
            this.gbDateOfCredit.Controls.Add(this.lblLimit);
            this.gbDateOfCredit.Controls.Add(this.lblCredit_contr);
            this.gbDateOfCredit.Controls.Add(this.label11);
            this.gbDateOfCredit.Location = new System.Drawing.Point(339, 12);
            this.gbDateOfCredit.Name = "gbDateOfCredit";
            this.gbDateOfCredit.Size = new System.Drawing.Size(366, 393);
            this.gbDateOfCredit.TabIndex = 1;
            this.gbDateOfCredit.TabStop = false;
            this.gbDateOfCredit.Text = "Данни за креит";
            // 
            // cb_credit_contr
            // 
            this.cb_credit_contr.DataSource = this.cREDITPRODUCTBindingSource;
            this.cb_credit_contr.DisplayMember = "PROD_NAME";
            this.cb_credit_contr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_credit_contr.FormattingEnabled = true;
            this.cb_credit_contr.Location = new System.Drawing.Point(122, 69);
            this.cb_credit_contr.Name = "cb_credit_contr";
            this.cb_credit_contr.Size = new System.Drawing.Size(121, 21);
            this.cb_credit_contr.TabIndex = 15;
            this.cb_credit_contr.ValueMember = "PROD_CODE";
            this.cb_credit_contr.SelectedIndexChanged += new System.EventHandler(this.cb_credit_contr_SelectedIndexChanged);
            // 
            // btnIzchisli
            // 
            this.btnIzchisli.Location = new System.Drawing.Point(143, 339);
            this.btnIzchisli.Name = "btnIzchisli";
            this.btnIzchisli.Size = new System.Drawing.Size(75, 23);
            this.btnIzchisli.TabIndex = 14;
            this.btnIzchisli.Text = "Изчисли";
            this.btnIzchisli.UseVisualStyleBackColor = true;
            this.btnIzchisli.Click += new System.EventHandler(this.btnIzchisli_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // txtPurposeCredit_contr
            // 
            this.txtPurposeCredit_contr.Location = new System.Drawing.Point(6, 286);
            this.txtPurposeCredit_contr.Name = "txtPurposeCredit_contr";
            this.txtPurposeCredit_contr.Size = new System.Drawing.Size(284, 20);
            this.txtPurposeCredit_contr.TabIndex = 12;
            // 
            // txtWantValue
            // 
            this.txtWantValue.Location = new System.Drawing.Point(143, 219);
            this.txtWantValue.Name = "txtWantValue";
            this.txtWantValue.Size = new System.Drawing.Size(100, 20);
            this.txtWantValue.TabIndex = 11;
            this.txtWantValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtWantValue_Validating);
            this.txtWantValue.Validated += new System.EventHandler(this.txtWantValue_Validated);
            // 
            // txtEndContract_contr
            // 
            this.txtEndContract_contr.Location = new System.Drawing.Point(143, 174);
            this.txtEndContract_contr.Name = "txtEndContract_contr";
            this.txtEndContract_contr.Size = new System.Drawing.Size(100, 20);
            this.txtEndContract_contr.TabIndex = 10;
            // 
            // cbLimit
            // 
            this.cbLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLimit.FormattingEnabled = true;
            this.cbLimit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18"});
            this.cbLimit.Location = new System.Drawing.Point(122, 99);
            this.cbLimit.Name = "cbLimit";
            this.cbLimit.Size = new System.Drawing.Size(121, 21);
            this.cbLimit.TabIndex = 9;
            this.cbLimit.SelectedIndexChanged += new System.EventHandler(this.cbLimit_SelectedIndexChanged);
            // 
            // txtBeginContract_contr
            // 
            this.txtBeginContract_contr.Location = new System.Drawing.Point(143, 136);
            this.txtBeginContract_contr.Name = "txtBeginContract_contr";
            this.txtBeginContract_contr.Size = new System.Drawing.Size(100, 20);
            this.txtBeginContract_contr.TabIndex = 4;
            // 
            // lblPurposeCredit_contr
            // 
            this.lblPurposeCredit_contr.AutoSize = true;
            this.lblPurposeCredit_contr.Location = new System.Drawing.Point(16, 265);
            this.lblPurposeCredit_contr.Name = "lblPurposeCredit_contr";
            this.lblPurposeCredit_contr.Size = new System.Drawing.Size(145, 13);
            this.lblPurposeCredit_contr.TabIndex = 6;
            this.lblPurposeCredit_contr.Text = "Предназначение на кредит";
            // 
            // lblWantValue
            // 
            this.lblWantValue.AutoSize = true;
            this.lblWantValue.Location = new System.Drawing.Point(28, 222);
            this.lblWantValue.Name = "lblWantValue";
            this.lblWantValue.Size = new System.Drawing.Size(73, 13);
            this.lblWantValue.TabIndex = 5;
            this.lblWantValue.Text = "Искана сума";
            // 
            // lblEndContract_contr
            // 
            this.lblEndContract_contr.AutoSize = true;
            this.lblEndContract_contr.Location = new System.Drawing.Point(34, 174);
            this.lblEndContract_contr.Name = "lblEndContract_contr";
            this.lblEndContract_contr.Size = new System.Drawing.Size(70, 13);
            this.lblEndContract_contr.TabIndex = 4;
            this.lblEndContract_contr.Text = "Край на дог.";
            // 
            // lblBeginContract_contr
            // 
            this.lblBeginContract_contr.AutoSize = true;
            this.lblBeginContract_contr.Location = new System.Drawing.Point(34, 139);
            this.lblBeginContract_contr.Name = "lblBeginContract_contr";
            this.lblBeginContract_contr.Size = new System.Drawing.Size(82, 13);
            this.lblBeginContract_contr.TabIndex = 3;
            this.lblBeginContract_contr.Text = "Начало на дог.";
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(46, 99);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(32, 13);
            this.lblLimit.TabIndex = 2;
            this.lblLimit.Text = "Срок";
            // 
            // lblCredit_contr
            // 
            this.lblCredit_contr.AutoSize = true;
            this.lblCredit_contr.Location = new System.Drawing.Point(40, 69);
            this.lblCredit_contr.Name = "lblCredit_contr";
            this.lblCredit_contr.Size = new System.Drawing.Size(64, 13);
            this.lblCredit_contr.TabIndex = 1;
            this.lblCredit_contr.Text = "Вид кредит";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Дата";
            // 
            // gbCreditPlan
            // 
            this.gbCreditPlan.Controls.Add(this.dtpMaturity);
            this.gbCreditPlan.Controls.Add(this.txtSizePayment);
            this.gbCreditPlan.Controls.Add(this.txtTotal);
            this.gbCreditPlan.Controls.Add(this.txtNumPayment);
            this.gbCreditPlan.Controls.Add(this.lblTotal);
            this.gbCreditPlan.Controls.Add(this.lblSizePayment);
            this.gbCreditPlan.Controls.Add(this.lblMaturity);
            this.gbCreditPlan.Controls.Add(this.lblNumPayment);
            this.gbCreditPlan.Location = new System.Drawing.Point(6, 411);
            this.gbCreditPlan.Name = "gbCreditPlan";
            this.gbCreditPlan.Size = new System.Drawing.Size(638, 100);
            this.gbCreditPlan.TabIndex = 2;
            this.gbCreditPlan.TabStop = false;
            this.gbCreditPlan.Text = "Погасителен план";
            // 
            // dtpMaturity
            // 
            this.dtpMaturity.Location = new System.Drawing.Point(87, 49);
            this.dtpMaturity.Name = "dtpMaturity";
            this.dtpMaturity.Size = new System.Drawing.Size(200, 20);
            this.dtpMaturity.TabIndex = 9;
            // 
            // txtSizePayment
            // 
            this.txtSizePayment.Location = new System.Drawing.Point(433, 17);
            this.txtSizePayment.Name = "txtSizePayment";
            this.txtSizePayment.Size = new System.Drawing.Size(100, 20);
            this.txtSizePayment.TabIndex = 8;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(433, 47);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // txtNumPayment
            // 
            this.txtNumPayment.Location = new System.Drawing.Point(120, 17);
            this.txtNumPayment.Name = "txtNumPayment";
            this.txtNumPayment.Size = new System.Drawing.Size(100, 20);
            this.txtNumPayment.TabIndex = 6;
            this.txtNumPayment.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(326, 54);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(72, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Сумарен ред";
            // 
            // lblSizePayment
            // 
            this.lblSizePayment.AutoSize = true;
            this.lblSizePayment.Location = new System.Drawing.Point(327, 20);
            this.lblSizePayment.Name = "lblSizePayment";
            this.lblSizePayment.Size = new System.Drawing.Size(100, 13);
            this.lblSizePayment.TabIndex = 2;
            this.lblSizePayment.Text = "Размер на вноска";
            // 
            // lblMaturity
            // 
            this.lblMaturity.AutoSize = true;
            this.lblMaturity.Location = new System.Drawing.Point(6, 55);
            this.lblMaturity.Name = "lblMaturity";
            this.lblMaturity.Size = new System.Drawing.Size(41, 13);
            this.lblMaturity.TabIndex = 1;
            this.lblMaturity.Text = "Падеж";
            // 
            // lblNumPayment
            // 
            this.lblNumPayment.AutoSize = true;
            this.lblNumPayment.Location = new System.Drawing.Point(3, 20);
            this.lblNumPayment.Name = "lblNumPayment";
            this.lblNumPayment.Size = new System.Drawing.Size(95, 13);
            this.lblNumPayment.TabIndex = 0;
            this.lblNumPayment.Text = "Номер на вноска";
            this.lblNumPayment.Visible = false;
            // 
            // btnSaveContract
            // 
            this.btnSaveContract.Location = new System.Drawing.Point(103, 522);
            this.btnSaveContract.Name = "btnSaveContract";
            this.btnSaveContract.Size = new System.Drawing.Size(75, 23);
            this.btnSaveContract.TabIndex = 3;
            this.btnSaveContract.Text = "Запази";
            this.btnSaveContract.UseVisualStyleBackColor = true;
            this.btnSaveContract.Click += new System.EventHandler(this.btnSaveContract_Click);
            // 
            // btnReviewContract
            // 
            this.btnReviewContract.Location = new System.Drawing.Point(439, 522);
            this.btnReviewContract.Name = "btnReviewContract";
            this.btnReviewContract.Size = new System.Drawing.Size(121, 23);
            this.btnReviewContract.TabIndex = 4;
            this.btnReviewContract.Text = "Прегд на договора";
            this.btnReviewContract.UseVisualStyleBackColor = true;
            this.btnReviewContract.Click += new System.EventHandler(this.btnReviewContract_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ianiDataSet
            // 
            this.ianiDataSet.DataSetName = "ianiDataSet";
            this.ianiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cREDITPRODUCTBindingSource
            // 
            this.cREDITPRODUCTBindingSource.DataMember = "CREDIT_PRODUCT";
            this.cREDITPRODUCTBindingSource.DataSource = this.ianiDataSet;
            // 
            // cREDIT_PRODUCTTableAdapter
            // 
            this.cREDIT_PRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // frmNewContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 557);
            this.Controls.Add(this.btnReviewContract);
            this.Controls.Add(this.btnSaveContract);
            this.Controls.Add(this.gbCreditPlan);
            this.Controls.Add(this.gbDateOfCredit);
            this.Controls.Add(this.gbMainDate);
            this.Name = "frmNewContract";
            this.Text = "Нов договор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNewContract_FormClosing);
            this.Load += new System.EventHandler(this.frmNewContract_Load);
            this.gbMainDate.ResumeLayout(false);
            this.gbMainDate.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbDateOfCredit.ResumeLayout(false);
            this.gbDateOfCredit.PerformLayout();
            this.gbCreditPlan.ResumeLayout(false);
            this.gbCreditPlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ianiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREDITPRODUCTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMainDate;
        private System.Windows.Forms.TextBox txtTel_contr;
        private System.Windows.Forms.TextBox txtAddressContract;
        private System.Windows.Forms.TextBox txtE_mail_contr;
        private System.Windows.Forms.TextBox txtBULSTAT_Contr;
        private System.Windows.Forms.TextBox txtFirmName;
        private System.Windows.Forms.TextBox txtEGN_contr;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtNoContract;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDateOfCredit;
        private System.Windows.Forms.Label lblPurposeCredit_contr;
        private System.Windows.Forms.Label lblWantValue;
        private System.Windows.Forms.Label lblEndContract_contr;
        private System.Windows.Forms.Label lblBeginContract_contr;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.Label lblCredit_contr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbCreditPlan;
        private System.Windows.Forms.TextBox txtBeginContract_contr;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSizePayment;
        private System.Windows.Forms.Label lblMaturity;
        private System.Windows.Forms.Label lblNumPayment;
        private System.Windows.Forms.TextBox txtPurposeCredit_contr;
        private System.Windows.Forms.TextBox txtWantValue;
        private System.Windows.Forms.TextBox txtEndContract_contr;
        private System.Windows.Forms.ComboBox cbLimit;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtNumPayment;
        private System.Windows.Forms.Button btnSaveContract;
        private System.Windows.Forms.Button btnReviewContract;
        private System.Windows.Forms.RadioButton rbtnWaman;
        private System.Windows.Forms.RadioButton rbtnJL;
        private System.Windows.Forms.RadioButton rbtnFL;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtSizePayment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnMan;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnIzchisli;
        private System.Windows.Forms.ComboBox cb_credit_contr;
        private System.Windows.Forms.DateTimePicker dtpMaturity;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label lblClientID;
        private ianiDataSet ianiDataSet;
        private System.Windows.Forms.BindingSource cREDITPRODUCTBindingSource;
        private ianiDataSetTableAdapters.CREDIT_PRODUCTTableAdapter cREDIT_PRODUCTTableAdapter;
    }
}