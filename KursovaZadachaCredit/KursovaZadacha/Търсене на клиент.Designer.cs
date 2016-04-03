namespace KursovaZadacha
{
    partial class frmSearchClient
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
            this.lblType = new System.Windows.Forms.Label();
            this.lblCLient_id_SurchC = new System.Windows.Forms.Label();
            this.lblEGN = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txt_ID_SCustomer = new System.Windows.Forms.TextBox();
            this.txtBoxEGN = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearching = new System.Windows.Forms.Button();
            this.btnNewClient = new System.Windows.Forms.Button();
            this.rbtnJL_C = new System.Windows.Forms.RadioButton();
            this.rbtnFL_C = new System.Windows.Forms.RadioButton();
            this.dgv_SearchClient = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Същ_клиентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchClient)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(16, 17);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(26, 13);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Тип";
            // 
            // lblCLient_id_SurchC
            // 
            this.lblCLient_id_SurchC.AutoSize = true;
            this.lblCLient_id_SurchC.Location = new System.Drawing.Point(16, 51);
            this.lblCLient_id_SurchC.Name = "lblCLient_id_SurchC";
            this.lblCLient_id_SurchC.Size = new System.Drawing.Size(57, 13);
            this.lblCLient_id_SurchC.TabIndex = 1;
            this.lblCLient_id_SurchC.Text = "Клиент №";
            this.lblCLient_id_SurchC.Visible = false;
            // 
            // lblEGN
            // 
            this.lblEGN.AutoSize = true;
            this.lblEGN.Location = new System.Drawing.Point(16, 111);
            this.lblEGN.Name = "lblEGN";
            this.lblEGN.Size = new System.Drawing.Size(82, 13);
            this.lblEGN.TabIndex = 2;
            this.lblEGN.Text = "ЕГН/BULSTAT";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(16, 154);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(71, 13);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Име/Фирма";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(16, 228);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(35, 13);
            this.lblMail.TabIndex = 5;
            this.lblMail.Text = "E-mail";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(16, 264);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 13);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Телефон";
            // 
            // txt_ID_SCustomer
            // 
            this.txt_ID_SCustomer.Location = new System.Drawing.Point(112, 51);
            this.txt_ID_SCustomer.Name = "txt_ID_SCustomer";
            this.txt_ID_SCustomer.Size = new System.Drawing.Size(100, 20);
            this.txt_ID_SCustomer.TabIndex = 10;
            this.txt_ID_SCustomer.Visible = false;
            // 
            // txtBoxEGN
            // 
            this.txtBoxEGN.Location = new System.Drawing.Point(112, 111);
            this.txtBoxEGN.Name = "txtBoxEGN";
            this.txtBoxEGN.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEGN.TabIndex = 11;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(112, 151);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 20);
            this.txtFullName.TabIndex = 12;
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Location = new System.Drawing.Point(112, 228);
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMail.TabIndex = 14;
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(112, 264);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPhone.TabIndex = 15;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(326, 21);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(49, 13);
            this.lblClient.TabIndex = 16;
            this.lblClient.Text = "Клиенти";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(22, 308);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Изход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearching
            // 
            this.btnSearching.Location = new System.Drawing.Point(198, 308);
            this.btnSearching.Name = "btnSearching";
            this.btnSearching.Size = new System.Drawing.Size(75, 23);
            this.btnSearching.TabIndex = 18;
            this.btnSearching.Text = "Търси";
            this.btnSearching.UseVisualStyleBackColor = true;
            this.btnSearching.Click += new System.EventHandler(this.btnSearching_Click);
            // 
            // btnNewClient
            // 
            this.btnNewClient.Location = new System.Drawing.Point(369, 308);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(75, 23);
            this.btnNewClient.TabIndex = 19;
            this.btnNewClient.Text = "Нов клиент";
            this.btnNewClient.UseVisualStyleBackColor = true;
            this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
            // 
            // rbtnJL_C
            // 
            this.rbtnJL_C.AutoSize = true;
            this.rbtnJL_C.Location = new System.Drawing.Point(112, 17);
            this.rbtnJL_C.Name = "rbtnJL_C";
            this.rbtnJL_C.Size = new System.Drawing.Size(42, 17);
            this.rbtnJL_C.TabIndex = 27;
            this.rbtnJL_C.TabStop = true;
            this.rbtnJL_C.Text = "ЮЛ";
            this.rbtnJL_C.UseVisualStyleBackColor = true;
            // 
            // rbtnFL_C
            // 
            this.rbtnFL_C.AutoSize = true;
            this.rbtnFL_C.Location = new System.Drawing.Point(168, 17);
            this.rbtnFL_C.Name = "rbtnFL_C";
            this.rbtnFL_C.Size = new System.Drawing.Size(44, 17);
            this.rbtnFL_C.TabIndex = 28;
            this.rbtnFL_C.TabStop = true;
            this.rbtnFL_C.Text = "ФЛ";
            this.rbtnFL_C.UseVisualStyleBackColor = true;
            // 
            // dgv_SearchClient
            // 
            this.dgv_SearchClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SearchClient.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_SearchClient.Location = new System.Drawing.Point(251, 51);
            this.dgv_SearchClient.Name = "dgv_SearchClient";
            this.dgv_SearchClient.Size = new System.Drawing.Size(454, 197);
            this.dgv_SearchClient.TabIndex = 31;
            this.dgv_SearchClient.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_SearchClient_RowHeaderMouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Същ_клиентToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(194, 26);
            // 
            // Същ_клиентToolStripMenuItem
            // 
            this.Същ_клиентToolStripMenuItem.Name = "Същ_клиентToolStripMenuItem";
            this.Същ_клиентToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.Същ_клиентToolStripMenuItem.Text = "Съществуващ клиент";
            // 
            // frmSearchClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 352);
            this.Controls.Add(this.dgv_SearchClient);
            this.Controls.Add(this.rbtnFL_C);
            this.Controls.Add(this.rbtnJL_C);
            this.Controls.Add(this.btnNewClient);
            this.Controls.Add(this.btnSearching);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.txtBoxPhone);
            this.Controls.Add(this.txtBoxMail);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtBoxEGN);
            this.Controls.Add(this.txt_ID_SCustomer);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblEGN);
            this.Controls.Add(this.lblCLient_id_SurchC);
            this.Controls.Add(this.lblType);
            this.Name = "frmSearchClient";
            this.Text = "Търсене_на_клиент";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSearchClient_FormClosing);
            this.Load += new System.EventHandler(this.frmSearchClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchClient)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCLient_id_SurchC;
        private System.Windows.Forms.Label lblEGN;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txt_ID_SCustomer;
        private System.Windows.Forms.TextBox txtBoxEGN;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtBoxMail;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearching;
        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.RadioButton rbtnJL_C;
        private System.Windows.Forms.RadioButton rbtnFL_C;
        private System.Windows.Forms.DataGridView dgv_SearchClient;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Същ_клиентToolStripMenuItem;
    }
}