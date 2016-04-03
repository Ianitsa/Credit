namespace KursovaZadacha
{
    partial class frmSearchCreditProduct
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodCrP = new System.Windows.Forms.TextBox();
            this.txtCrPName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSumFrom = new System.Windows.Forms.TextBox();
            this.txtSumTo = new System.Windows.Forms.TextBox();
            this.btnExitSearchCrP = new System.Windows.Forms.Button();
            this.btnSearchCrP = new System.Windows.Forms.Button();
            this.dgvCP = new System.Windows.Forms.DataGridView();
            this.rbtnNoActiv = new System.Windows.Forms.RadioButton();
            this.rbtnAktiv = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код на кр.продукт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Наименование";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Допустим интервал на искана сума";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Статус";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Кредитен продукт";
            // 
            // txtCodCrP
            // 
            this.txtCodCrP.Location = new System.Drawing.Point(156, 60);
            this.txtCodCrP.Name = "txtCodCrP";
            this.txtCodCrP.Size = new System.Drawing.Size(100, 20);
            this.txtCodCrP.TabIndex = 7;
            // 
            // txtCrPName
            // 
            this.txtCrPName.Location = new System.Drawing.Point(156, 96);
            this.txtCrPName.Name = "txtCrPName";
            this.txtCrPName.Size = new System.Drawing.Size(100, 20);
            this.txtCrPName.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "от:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(319, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "до:";
            // 
            // txtSumFrom
            // 
            this.txtSumFrom.Location = new System.Drawing.Point(244, 126);
            this.txtSumFrom.Name = "txtSumFrom";
            this.txtSumFrom.Size = new System.Drawing.Size(58, 20);
            this.txtSumFrom.TabIndex = 12;
            // 
            // txtSumTo
            // 
            this.txtSumTo.Location = new System.Drawing.Point(347, 126);
            this.txtSumTo.Name = "txtSumTo";
            this.txtSumTo.Size = new System.Drawing.Size(64, 20);
            this.txtSumTo.TabIndex = 13;
            // 
            // btnExitSearchCrP
            // 
            this.btnExitSearchCrP.Location = new System.Drawing.Point(108, 351);
            this.btnExitSearchCrP.Name = "btnExitSearchCrP";
            this.btnExitSearchCrP.Size = new System.Drawing.Size(75, 23);
            this.btnExitSearchCrP.TabIndex = 17;
            this.btnExitSearchCrP.Text = "Изход";
            this.btnExitSearchCrP.UseVisualStyleBackColor = true;
            this.btnExitSearchCrP.Click += new System.EventHandler(this.btnExitSearchCrP_Click);
            // 
            // btnSearchCrP
            // 
            this.btnSearchCrP.Location = new System.Drawing.Point(385, 351);
            this.btnSearchCrP.Name = "btnSearchCrP";
            this.btnSearchCrP.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCrP.TabIndex = 18;
            this.btnSearchCrP.Text = "Търси";
            this.btnSearchCrP.UseVisualStyleBackColor = true;
            this.btnSearchCrP.Click += new System.EventHandler(this.btnSearchCrP_Click);
            // 
            // dgvCP
            // 
            this.dgvCP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCP.Location = new System.Drawing.Point(21, 191);
            this.dgvCP.Name = "dgvCP";
            this.dgvCP.Size = new System.Drawing.Size(682, 122);
            this.dgvCP.TabIndex = 24;
            this.toolTip1.SetToolTip(this.dgvCP, "Dabal klik na zaglawnata chast");
            this.dgvCP.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCP_RowHeaderMouseDoubleClick);
            // 
            // rbtnNoActiv
            // 
            this.rbtnNoActiv.AutoSize = true;
            this.rbtnNoActiv.Location = new System.Drawing.Point(108, 12);
            this.rbtnNoActiv.Name = "rbtnNoActiv";
            this.rbtnNoActiv.Size = new System.Drawing.Size(80, 17);
            this.rbtnNoActiv.TabIndex = 31;
            this.rbtnNoActiv.Text = "Неактивен";
            this.rbtnNoActiv.UseVisualStyleBackColor = true;
            // 
            // rbtnAktiv
            // 
            this.rbtnAktiv.AutoSize = true;
            this.rbtnAktiv.Location = new System.Drawing.Point(194, 12);
            this.rbtnAktiv.Name = "rbtnAktiv";
            this.rbtnAktiv.Size = new System.Drawing.Size(67, 17);
            this.rbtnAktiv.TabIndex = 32;
            this.rbtnAktiv.Text = "Активен";
            this.rbtnAktiv.UseVisualStyleBackColor = true;
            // 
            // frmSearchCreditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 386);
            this.Controls.Add(this.rbtnAktiv);
            this.Controls.Add(this.rbtnNoActiv);
            this.Controls.Add(this.dgvCP);
            this.Controls.Add(this.btnSearchCrP);
            this.Controls.Add(this.btnExitSearchCrP);
            this.Controls.Add(this.txtSumTo);
            this.Controls.Add(this.txtSumFrom);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCrPName);
            this.Controls.Add(this.txtCodCrP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSearchCreditProduct";
            this.Text = "Търсене на кредитен продукт";
            this.Load += new System.EventHandler(this.frmSearchCreditProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodCrP;
        private System.Windows.Forms.TextBox txtCrPName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSumFrom;
        private System.Windows.Forms.TextBox txtSumTo;
        private System.Windows.Forms.Button btnExitSearchCrP;
        private System.Windows.Forms.Button btnSearchCrP;
        private System.Windows.Forms.DataGridView dgvCP;
        private System.Windows.Forms.RadioButton rbtnNoActiv;
        private System.Windows.Forms.RadioButton rbtnAktiv;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}