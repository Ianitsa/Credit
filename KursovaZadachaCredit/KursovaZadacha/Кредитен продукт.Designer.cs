namespace KursovaZadacha
{
    partial class frmCreditProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbCod = new System.Windows.Forms.TextBox();
            this.txtbN = new System.Windows.Forms.TextBox();
            this.cbInterest = new System.Windows.Forms.ComboBox();
            this.cREDITPRODUCTBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ianiDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ianiDataSet2 = new KursovaZadacha.ianiDataSet2();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSumFrom = new System.Windows.Forms.TextBox();
            this.txtSumTo = new System.Windows.Forms.TextBox();
            this.btnExitCrP = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSaveCrP = new System.Windows.Forms.Button();
            this.rbtnNoActiv = new System.Windows.Forms.RadioButton();
            this.rbtnActiv = new System.Windows.Forms.RadioButton();
            this.ianiDataSet = new KursovaZadacha.ianiDataSet();
            this.cREDITPRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cREDIT_PRODUCTTableAdapter = new KursovaZadacha.ianiDataSetTableAdapters.CREDIT_PRODUCTTableAdapter();
            this.ianiDataSet1 = new KursovaZadacha.ianiDataSet1();
            this.iNTERESTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNTERESTTableAdapter = new KursovaZadacha.ianiDataSet1TableAdapters.INTERESTTableAdapter();
            this.cbLimit = new System.Windows.Forms.ComboBox();
            this.pRODPERIODSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ianiDataSet11 = new KursovaZadacha.ianiDataSet1();
            this.ianiDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cREDITPRODUCTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cREDIT_PRODUCTTableAdapter1 = new KursovaZadacha.ianiDataSet1TableAdapters.CREDIT_PRODUCTTableAdapter();
            this.cREDIT_PRODUCTTableAdapter2 = new KursovaZadacha.ianiDataSet2TableAdapters.CREDIT_PRODUCTTableAdapter();
            this.pROD_PERIODSTableAdapter = new KursovaZadacha.ianiDataSet2TableAdapters.PROD_PERIODSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cREDITPRODUCTBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ianiDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ianiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ianiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREDITPRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ianiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNTERESTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODPERIODSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ianiDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ianiDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREDITPRODUCTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код на кр.продукт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Наименование";
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(31, 113);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(38, 13);
            this.lblInterest.TabIndex = 2;
            this.lblInterest.Text = "Лихва";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Допустими срочности";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Допустим интервал на искана сума";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Статус";
            // 
            // txtbCod
            // 
            this.txtbCod.Location = new System.Drawing.Point(178, 28);
            this.txtbCod.Name = "txtbCod";
            this.txtbCod.Size = new System.Drawing.Size(100, 20);
            this.txtbCod.TabIndex = 6;
            // 
            // txtbN
            // 
            this.txtbN.Location = new System.Drawing.Point(178, 65);
            this.txtbN.Name = "txtbN";
            this.txtbN.Size = new System.Drawing.Size(100, 20);
            this.txtbN.TabIndex = 7;
            // 
            // cbInterest
            // 
            this.cbInterest.DataSource = this.cREDITPRODUCTBindingSource2;
            this.cbInterest.DisplayMember = "INTEREST";
            this.cbInterest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInterest.FormattingEnabled = true;
            this.cbInterest.Location = new System.Drawing.Point(178, 110);
            this.cbInterest.Name = "cbInterest";
            this.cbInterest.Size = new System.Drawing.Size(121, 21);
            this.cbInterest.TabIndex = 8;
            this.cbInterest.ValueMember = "PROD_CODE";
            // 
            // cREDITPRODUCTBindingSource2
            // 
            this.cREDITPRODUCTBindingSource2.DataMember = "CREDIT_PRODUCT";
            this.cREDITPRODUCTBindingSource2.DataSource = this.ianiDataSet2BindingSource;
            // 
            // ianiDataSet2BindingSource
            // 
            this.ianiDataSet2BindingSource.DataSource = this.ianiDataSet2;
            this.ianiDataSet2BindingSource.Position = 0;
            // 
            // ianiDataSet2
            // 
            this.ianiDataSet2.DataSetName = "ianiDataSet2";
            this.ianiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "от:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(337, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "до:";
            // 
            // txtSumFrom
            // 
            this.txtSumFrom.Location = new System.Drawing.Point(269, 217);
            this.txtSumFrom.Name = "txtSumFrom";
            this.txtSumFrom.Size = new System.Drawing.Size(41, 20);
            this.txtSumFrom.TabIndex = 15;
            // 
            // txtSumTo
            // 
            this.txtSumTo.Location = new System.Drawing.Point(365, 218);
            this.txtSumTo.Name = "txtSumTo";
            this.txtSumTo.Size = new System.Drawing.Size(46, 20);
            this.txtSumTo.TabIndex = 16;
            // 
            // btnExitCrP
            // 
            this.btnExitCrP.Location = new System.Drawing.Point(76, 354);
            this.btnExitCrP.Name = "btnExitCrP";
            this.btnExitCrP.Size = new System.Drawing.Size(75, 23);
            this.btnExitCrP.TabIndex = 19;
            this.btnExitCrP.Text = "Изход";
            this.btnExitCrP.UseVisualStyleBackColor = true;
            this.btnExitCrP.Click += new System.EventHandler(this.btnExitCrP_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(305, 354);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Редакция";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSaveCrP
            // 
            this.btnSaveCrP.Location = new System.Drawing.Point(518, 354);
            this.btnSaveCrP.Name = "btnSaveCrP";
            this.btnSaveCrP.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCrP.TabIndex = 21;
            this.btnSaveCrP.Text = "Запази";
            this.btnSaveCrP.UseVisualStyleBackColor = true;
            this.btnSaveCrP.Click += new System.EventHandler(this.btnSaveCrP_Click);
            // 
            // rbtnNoActiv
            // 
            this.rbtnNoActiv.AutoSize = true;
            this.rbtnNoActiv.Checked = true;
            this.rbtnNoActiv.Location = new System.Drawing.Point(115, 269);
            this.rbtnNoActiv.Name = "rbtnNoActiv";
            this.rbtnNoActiv.Size = new System.Drawing.Size(80, 17);
            this.rbtnNoActiv.TabIndex = 30;
            this.rbtnNoActiv.TabStop = true;
            this.rbtnNoActiv.Text = "Неактивен";
            this.rbtnNoActiv.UseVisualStyleBackColor = true;
            // 
            // rbtnActiv
            // 
            this.rbtnActiv.AutoSize = true;
            this.rbtnActiv.Location = new System.Drawing.Point(209, 270);
            this.rbtnActiv.Name = "rbtnActiv";
            this.rbtnActiv.Size = new System.Drawing.Size(67, 17);
            this.rbtnActiv.TabIndex = 31;
            this.rbtnActiv.Text = "Активен";
            this.rbtnActiv.UseVisualStyleBackColor = true;
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
            // ianiDataSet1
            // 
            this.ianiDataSet1.DataSetName = "ianiDataSet1";
            this.ianiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iNTERESTBindingSource
            // 
            this.iNTERESTBindingSource.DataMember = "INTEREST";
            this.iNTERESTBindingSource.DataSource = this.ianiDataSet1;
            // 
            // iNTERESTTableAdapter
            // 
            this.iNTERESTTableAdapter.ClearBeforeFill = true;
            // 
            // cbLimit
            // 
            this.cbLimit.DataSource = this.pRODPERIODSBindingSource;
            this.cbLimit.DisplayMember = "PROD_PERIOD";
            this.cbLimit.FormattingEnabled = true;
            this.cbLimit.Location = new System.Drawing.Point(178, 158);
            this.cbLimit.Name = "cbLimit";
            this.cbLimit.Size = new System.Drawing.Size(121, 21);
            this.cbLimit.TabIndex = 32;
            this.cbLimit.ValueMember = "PROD_CODE";
            // 
            // pRODPERIODSBindingSource
            // 
            this.pRODPERIODSBindingSource.DataMember = "PROD_PERIODS";
            this.pRODPERIODSBindingSource.DataSource = this.ianiDataSet2BindingSource;
            // 
            // ianiDataSet11
            // 
            this.ianiDataSet11.DataSetName = "ianiDataSet1";
            this.ianiDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ianiDataSet1BindingSource
            // 
            this.ianiDataSet1BindingSource.DataSource = this.ianiDataSet1;
            this.ianiDataSet1BindingSource.Position = 0;
            // 
            // cREDITPRODUCTBindingSource1
            // 
            this.cREDITPRODUCTBindingSource1.DataMember = "CREDIT_PRODUCT";
            this.cREDITPRODUCTBindingSource1.DataSource = this.ianiDataSet1BindingSource;
            // 
            // cREDIT_PRODUCTTableAdapter1
            // 
            this.cREDIT_PRODUCTTableAdapter1.ClearBeforeFill = true;
            // 
            // cREDIT_PRODUCTTableAdapter2
            // 
            this.cREDIT_PRODUCTTableAdapter2.ClearBeforeFill = true;
            // 
            // pROD_PERIODSTableAdapter
            // 
            this.pROD_PERIODSTableAdapter.ClearBeforeFill = true;
            // 
            // frmCreditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 389);
            this.Controls.Add(this.cbLimit);
            this.Controls.Add(this.rbtnActiv);
            this.Controls.Add(this.rbtnNoActiv);
            this.Controls.Add(this.btnSaveCrP);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExitCrP);
            this.Controls.Add(this.txtSumTo);
            this.Controls.Add(this.txtSumFrom);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbInterest);
            this.Controls.Add(this.txtbN);
            this.Controls.Add(this.txtbCod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCreditProduct";
            this.Text = "Кредитен продукт";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCreditProduct_FormClosing);
            this.Load += new System.EventHandler(this.frmCreditProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cREDITPRODUCTBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ianiDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ianiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ianiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREDITPRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ianiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNTERESTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODPERIODSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ianiDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ianiDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREDITPRODUCTBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbCod;
        private System.Windows.Forms.TextBox txtbN;
        private System.Windows.Forms.ComboBox cbInterest;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSumFrom;
        private System.Windows.Forms.TextBox txtSumTo;
        private System.Windows.Forms.Button btnExitCrP;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSaveCrP;
        private System.Windows.Forms.RadioButton rbtnNoActiv;
        private System.Windows.Forms.RadioButton rbtnActiv;
        private ianiDataSet ianiDataSet;
        private System.Windows.Forms.BindingSource cREDITPRODUCTBindingSource;
        private ianiDataSetTableAdapters.CREDIT_PRODUCTTableAdapter cREDIT_PRODUCTTableAdapter;
        private ianiDataSet1 ianiDataSet1;
        private System.Windows.Forms.BindingSource iNTERESTBindingSource;
        private ianiDataSet1TableAdapters.INTERESTTableAdapter iNTERESTTableAdapter;
        private System.Windows.Forms.ComboBox cbLimit;
        private System.Windows.Forms.BindingSource ianiDataSet1BindingSource;
        private ianiDataSet1 ianiDataSet11;
        private System.Windows.Forms.BindingSource cREDITPRODUCTBindingSource1;
        private ianiDataSet1TableAdapters.CREDIT_PRODUCTTableAdapter cREDIT_PRODUCTTableAdapter1;
        private System.Windows.Forms.BindingSource ianiDataSet2BindingSource;
        private ianiDataSet2 ianiDataSet2;
        private System.Windows.Forms.BindingSource cREDITPRODUCTBindingSource2;
        private ianiDataSet2TableAdapters.CREDIT_PRODUCTTableAdapter cREDIT_PRODUCTTableAdapter2;
        private System.Windows.Forms.BindingSource pRODPERIODSBindingSource;
        private ianiDataSet2TableAdapters.PROD_PERIODSTableAdapter pROD_PERIODSTableAdapter;
    }
}