namespace KursovaZadacha
{
    partial class NewCrProd
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
            this.cbLimit = new System.Windows.Forms.ComboBox();
            this.rbtnActiv = new System.Windows.Forms.RadioButton();
            this.rbtnNoActiv = new System.Windows.Forms.RadioButton();
            this.txtSumTo = new System.Windows.Forms.TextBox();
            this.txtSumFrom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbInterest = new System.Windows.Forms.ComboBox();
            this.txtbN = new System.Windows.Forms.TextBox();
            this.txtbCod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveCrP = new System.Windows.Forms.Button();
            this.btnExitCrP = new System.Windows.Forms.Button();
            this.ianiDataSet2 = new KursovaZadacha.ianiDataSet2();
            this.cREDITPRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cREDIT_PRODUCTTableAdapter = new KursovaZadacha.ianiDataSet2TableAdapters.CREDIT_PRODUCTTableAdapter();
            this.pRODPERIODSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROD_PERIODSTableAdapter = new KursovaZadacha.ianiDataSet2TableAdapters.PROD_PERIODSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ianiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREDITPRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODPERIODSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLimit
            // 
            this.cbLimit.DataSource = this.pRODPERIODSBindingSource;
            this.cbLimit.DisplayMember = "PROD_PERIOD";
            this.cbLimit.FormattingEnabled = true;
            this.cbLimit.Location = new System.Drawing.Point(202, 179);
            this.cbLimit.Name = "cbLimit";
            this.cbLimit.Size = new System.Drawing.Size(121, 21);
            this.cbLimit.TabIndex = 48;
            this.cbLimit.ValueMember = "PROD_CODE";
            // 
            // rbtnActiv
            // 
            this.rbtnActiv.AutoSize = true;
            this.rbtnActiv.Location = new System.Drawing.Point(233, 291);
            this.rbtnActiv.Name = "rbtnActiv";
            this.rbtnActiv.Size = new System.Drawing.Size(67, 17);
            this.rbtnActiv.TabIndex = 47;
            this.rbtnActiv.Text = "Активен";
            this.rbtnActiv.UseVisualStyleBackColor = true;
            // 
            // rbtnNoActiv
            // 
            this.rbtnNoActiv.AutoSize = true;
            this.rbtnNoActiv.Checked = true;
            this.rbtnNoActiv.Location = new System.Drawing.Point(139, 290);
            this.rbtnNoActiv.Name = "rbtnNoActiv";
            this.rbtnNoActiv.Size = new System.Drawing.Size(80, 17);
            this.rbtnNoActiv.TabIndex = 46;
            this.rbtnNoActiv.TabStop = true;
            this.rbtnNoActiv.Text = "Неактивен";
            this.rbtnNoActiv.UseVisualStyleBackColor = true;
            // 
            // txtSumTo
            // 
            this.txtSumTo.Location = new System.Drawing.Point(389, 239);
            this.txtSumTo.Name = "txtSumTo";
            this.txtSumTo.Size = new System.Drawing.Size(46, 20);
            this.txtSumTo.TabIndex = 45;
            // 
            // txtSumFrom
            // 
            this.txtSumFrom.Location = new System.Drawing.Point(293, 238);
            this.txtSumFrom.Name = "txtSumFrom";
            this.txtSumFrom.Size = new System.Drawing.Size(41, 20);
            this.txtSumFrom.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(361, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "до:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(266, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "от:";
            // 
            // cbInterest
            // 
            this.cbInterest.DataSource = this.cREDITPRODUCTBindingSource;
            this.cbInterest.DisplayMember = "INTEREST";
            this.cbInterest.FormattingEnabled = true;
            this.cbInterest.Location = new System.Drawing.Point(202, 131);
            this.cbInterest.Name = "cbInterest";
            this.cbInterest.Size = new System.Drawing.Size(121, 21);
            this.cbInterest.TabIndex = 41;
            this.cbInterest.ValueMember = "PROD_CODE";
            // 
            // txtbN
            // 
            this.txtbN.Location = new System.Drawing.Point(202, 86);
            this.txtbN.Name = "txtbN";
            this.txtbN.Size = new System.Drawing.Size(100, 20);
            this.txtbN.TabIndex = 40;
            // 
            // txtbCod
            // 
            this.txtbCod.Location = new System.Drawing.Point(202, 49);
            this.txtbCod.Name = "txtbCod";
            this.txtbCod.Size = new System.Drawing.Size(100, 20);
            this.txtbCod.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Статус";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Допустим интервал на искана сума";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Допустими срочности";
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(55, 134);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(38, 13);
            this.lblInterest.TabIndex = 35;
            this.lblInterest.Text = "Лихва";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Наименование";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Код на кр.продукт";
            // 
            // btnSaveCrP
            // 
            this.btnSaveCrP.Location = new System.Drawing.Point(375, 332);
            this.btnSaveCrP.Name = "btnSaveCrP";
            this.btnSaveCrP.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCrP.TabIndex = 49;
            this.btnSaveCrP.Text = "Запази";
            this.btnSaveCrP.UseVisualStyleBackColor = true;
            this.btnSaveCrP.Click += new System.EventHandler(this.btnSaveCrP_Click);
            // 
            // btnExitCrP
            // 
            this.btnExitCrP.Location = new System.Drawing.Point(144, 332);
            this.btnExitCrP.Name = "btnExitCrP";
            this.btnExitCrP.Size = new System.Drawing.Size(75, 23);
            this.btnExitCrP.TabIndex = 50;
            this.btnExitCrP.Text = "Изход";
            this.btnExitCrP.UseVisualStyleBackColor = true;
            // 
            // ianiDataSet2
            // 
            this.ianiDataSet2.DataSetName = "ianiDataSet2";
            this.ianiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cREDITPRODUCTBindingSource
            // 
            this.cREDITPRODUCTBindingSource.DataMember = "CREDIT_PRODUCT";
            this.cREDITPRODUCTBindingSource.DataSource = this.ianiDataSet2;
            // 
            // cREDIT_PRODUCTTableAdapter
            // 
            this.cREDIT_PRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // pRODPERIODSBindingSource
            // 
            this.pRODPERIODSBindingSource.DataMember = "PROD_PERIODS";
            this.pRODPERIODSBindingSource.DataSource = this.ianiDataSet2;
            // 
            // pROD_PERIODSTableAdapter
            // 
            this.pROD_PERIODSTableAdapter.ClearBeforeFill = true;
            // 
            // NewCrProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 386);
            this.Controls.Add(this.btnExitCrP);
            this.Controls.Add(this.btnSaveCrP);
            this.Controls.Add(this.cbLimit);
            this.Controls.Add(this.rbtnActiv);
            this.Controls.Add(this.rbtnNoActiv);
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
            this.Name = "NewCrProd";
            this.Text = "Нов kредитен продукт";
            this.Load += new System.EventHandler(this.NewCrProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ianiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREDITPRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODPERIODSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLimit;
        private System.Windows.Forms.RadioButton rbtnActiv;
        private System.Windows.Forms.RadioButton rbtnNoActiv;
        private System.Windows.Forms.TextBox txtSumTo;
        private System.Windows.Forms.TextBox txtSumFrom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbInterest;
        private System.Windows.Forms.TextBox txtbN;
        private System.Windows.Forms.TextBox txtbCod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveCrP;
        private System.Windows.Forms.Button btnExitCrP;
        private ianiDataSet2 ianiDataSet2;
        private System.Windows.Forms.BindingSource cREDITPRODUCTBindingSource;
        private ianiDataSet2TableAdapters.CREDIT_PRODUCTTableAdapter cREDIT_PRODUCTTableAdapter;
        private System.Windows.Forms.BindingSource pRODPERIODSBindingSource;
        private ianiDataSet2TableAdapters.PROD_PERIODSTableAdapter pROD_PERIODSTableAdapter;
    }
}