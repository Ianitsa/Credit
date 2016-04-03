namespace KursovaZadacha
{
    partial class frmSearchContract
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName_FirmName = new System.Windows.Forms.Label();
            this.lbl_EGN_BULSTAT = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcontractNo = new System.Windows.Forms.TextBox();
            this.txtName_FirmName = new System.Windows.Forms.TextBox();
            this.txtEGN_BULSTAT = new System.Windows.Forms.TextBox();
            this.cbVidCredit = new System.Windows.Forms.ComboBox();
            this.cbSrok = new System.Windows.Forms.ComboBox();
            this.btnExitSearchContract = new System.Windows.Forms.Button();
            this.btnSearchContract = new System.Windows.Forms.Button();
            this.dgv_SearchContract = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchContract)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер на договор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Срок";
            // 
            // lblName_FirmName
            // 
            this.lblName_FirmName.AutoSize = true;
            this.lblName_FirmName.Location = new System.Drawing.Point(40, 107);
            this.lblName_FirmName.Name = "lblName_FirmName";
            this.lblName_FirmName.Size = new System.Drawing.Size(71, 13);
            this.lblName_FirmName.TabIndex = 2;
            this.lblName_FirmName.Text = "Име/Фирма";
            // 
            // lbl_EGN_BULSTAT
            // 
            this.lbl_EGN_BULSTAT.AutoSize = true;
            this.lbl_EGN_BULSTAT.Location = new System.Drawing.Point(40, 150);
            this.lbl_EGN_BULSTAT.Name = "lbl_EGN_BULSTAT";
            this.lbl_EGN_BULSTAT.Size = new System.Drawing.Size(84, 13);
            this.lbl_EGN_BULSTAT.TabIndex = 3;
            this.lbl_EGN_BULSTAT.Text = "ЕГН/БУЛСТАТ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Вид кредит";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Договор";
            // 
            // txtcontractNo
            // 
            this.txtcontractNo.Location = new System.Drawing.Point(143, 34);
            this.txtcontractNo.Name = "txtcontractNo";
            this.txtcontractNo.Size = new System.Drawing.Size(100, 20);
            this.txtcontractNo.TabIndex = 9;
            // 
            // txtName_FirmName
            // 
            this.txtName_FirmName.Location = new System.Drawing.Point(143, 104);
            this.txtName_FirmName.Name = "txtName_FirmName";
            this.txtName_FirmName.Size = new System.Drawing.Size(100, 20);
            this.txtName_FirmName.TabIndex = 10;
            // 
            // txtEGN_BULSTAT
            // 
            this.txtEGN_BULSTAT.Location = new System.Drawing.Point(143, 150);
            this.txtEGN_BULSTAT.Name = "txtEGN_BULSTAT";
            this.txtEGN_BULSTAT.Size = new System.Drawing.Size(100, 20);
            this.txtEGN_BULSTAT.TabIndex = 11;
            // 
            // cbVidCredit
            // 
            this.cbVidCredit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVidCredit.FormattingEnabled = true;
            this.cbVidCredit.Items.AddRange(new object[] {
            "",
            "stocov_Kredit",
            "Parchen_Kredit"});
            this.cbVidCredit.Location = new System.Drawing.Point(122, 243);
            this.cbVidCredit.Name = "cbVidCredit";
            this.cbVidCredit.Size = new System.Drawing.Size(121, 21);
            this.cbVidCredit.TabIndex = 14;
            // 
            // cbSrok
            // 
            this.cbSrok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSrok.FormattingEnabled = true;
            this.cbSrok.Items.AddRange(new object[] {
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
            this.cbSrok.Location = new System.Drawing.Point(178, 68);
            this.cbSrok.Name = "cbSrok";
            this.cbSrok.Size = new System.Drawing.Size(65, 21);
            this.cbSrok.TabIndex = 15;
            // 
            // btnExitSearchContract
            // 
            this.btnExitSearchContract.Location = new System.Drawing.Point(110, 313);
            this.btnExitSearchContract.Name = "btnExitSearchContract";
            this.btnExitSearchContract.Size = new System.Drawing.Size(75, 23);
            this.btnExitSearchContract.TabIndex = 16;
            this.btnExitSearchContract.Text = "Изход";
            this.btnExitSearchContract.UseVisualStyleBackColor = true;
            this.btnExitSearchContract.Click += new System.EventHandler(this.btnExitSearchContract_Click);
            // 
            // btnSearchContract
            // 
            this.btnSearchContract.Location = new System.Drawing.Point(288, 312);
            this.btnSearchContract.Name = "btnSearchContract";
            this.btnSearchContract.Size = new System.Drawing.Size(75, 23);
            this.btnSearchContract.TabIndex = 17;
            this.btnSearchContract.Text = "Търси";
            this.btnSearchContract.UseVisualStyleBackColor = true;
            this.btnSearchContract.Click += new System.EventHandler(this.btnSearchContract_Click);
            // 
            // dgv_SearchContract
            // 
            this.dgv_SearchContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SearchContract.Location = new System.Drawing.Point(387, 50);
            this.dgv_SearchContract.Name = "dgv_SearchContract";
            this.dgv_SearchContract.Size = new System.Drawing.Size(240, 150);
            this.dgv_SearchContract.TabIndex = 19;
            this.dgv_SearchContract.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_SearchContract_RowHeaderMouseDoubleClick);
            // 
            // frmSearchContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 379);
            this.Controls.Add(this.dgv_SearchContract);
            this.Controls.Add(this.btnSearchContract);
            this.Controls.Add(this.btnExitSearchContract);
            this.Controls.Add(this.cbSrok);
            this.Controls.Add(this.cbVidCredit);
            this.Controls.Add(this.txtEGN_BULSTAT);
            this.Controls.Add(this.txtName_FirmName);
            this.Controls.Add(this.txtcontractNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_EGN_BULSTAT);
            this.Controls.Add(this.lblName_FirmName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSearchContract";
            this.Text = "Търсене на договор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSearchContract_FormClosing);
            this.Load += new System.EventHandler(this.frmSearchContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchContract)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName_FirmName;
        private System.Windows.Forms.Label lbl_EGN_BULSTAT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcontractNo;
        private System.Windows.Forms.TextBox txtName_FirmName;
        private System.Windows.Forms.TextBox txtEGN_BULSTAT;
        private System.Windows.Forms.ComboBox cbVidCredit;
        private System.Windows.Forms.ComboBox cbSrok;
        private System.Windows.Forms.Button btnExitSearchContract;
        private System.Windows.Forms.Button btnSearchContract;
        private System.Windows.Forms.DataGridView dgv_SearchContract;
    }
}