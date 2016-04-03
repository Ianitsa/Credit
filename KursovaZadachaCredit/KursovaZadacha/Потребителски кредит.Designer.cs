namespace KursovaZadacha
{
    partial class FrmConsCredit
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuClient = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuSearchClient = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuContract = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuSearchContract = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuCreditP = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuSCreditP = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuNewCreditP = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuFile,
            this.StripMenuClient,
            this.StripMenuContract,
            this.StripMenuCreditP});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(950, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StripMenuFile
            // 
            this.StripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuExit});
            this.StripMenuFile.Name = "StripMenuFile";
            this.StripMenuFile.Size = new System.Drawing.Size(48, 20);
            this.StripMenuFile.Text = "Файл";
            // 
            // StripMenuExit
            // 
            this.StripMenuExit.Name = "StripMenuExit";
            this.StripMenuExit.Size = new System.Drawing.Size(180, 22);
            this.StripMenuExit.Text = "Изход от системата";
            this.StripMenuExit.Click += new System.EventHandler(this.StripMenuExit_Click);
            // 
            // StripMenuClient
            // 
            this.StripMenuClient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuSearchClient});
            this.StripMenuClient.Name = "StripMenuClient";
            this.StripMenuClient.Size = new System.Drawing.Size(58, 20);
            this.StripMenuClient.Text = "Клиент";
            // 
            // StripMenuSearchClient
            // 
            this.StripMenuSearchClient.Name = "StripMenuSearchClient";
            this.StripMenuSearchClient.Size = new System.Drawing.Size(177, 22);
            this.StripMenuSearchClient.Text = "Търсене на клиент";
            this.StripMenuSearchClient.Click += new System.EventHandler(this.StripMenuSearchClient_Click);
            // 
            // StripMenuContract
            // 
            this.StripMenuContract.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuSearchContract});
            this.StripMenuContract.Name = "StripMenuContract";
            this.StripMenuContract.Size = new System.Drawing.Size(66, 20);
            this.StripMenuContract.Text = "Договор";
            // 
            // StripMenuSearchContract
            // 
            this.StripMenuSearchContract.Name = "StripMenuSearchContract";
            this.StripMenuSearchContract.Size = new System.Drawing.Size(184, 22);
            this.StripMenuSearchContract.Text = "Търсене на договор";
            this.StripMenuSearchContract.Click += new System.EventHandler(this.StripMenuSearchContract_Click);
            // 
            // StripMenuCreditP
            // 
            this.StripMenuCreditP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuSCreditP,
            this.StripMenuNewCreditP});
            this.StripMenuCreditP.Name = "StripMenuCreditP";
            this.StripMenuCreditP.Size = new System.Drawing.Size(117, 20);
            this.StripMenuCreditP.Text = "Кредитен продукт";
            // 
            // StripMenuSCreditP
            // 
            this.StripMenuSCreditP.Name = "StripMenuSCreditP";
            this.StripMenuSCreditP.Size = new System.Drawing.Size(236, 22);
            this.StripMenuSCreditP.Text = "Търсене на кредитен продукт";
            this.StripMenuSCreditP.Click += new System.EventHandler(this.StripMenuSCreditP_Click);
            // 
            // StripMenuNewCreditP
            // 
            this.StripMenuNewCreditP.Name = "StripMenuNewCreditP";
            this.StripMenuNewCreditP.Size = new System.Drawing.Size(236, 22);
            this.StripMenuNewCreditP.Text = "Въведи нов кредит продукт";
            this.StripMenuNewCreditP.Click += new System.EventHandler(this.StripMenuNewCreditP_Click);
            // 
            // FrmConsCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 536);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmConsCredit";
            this.Text = "Потребителски_кредит";
            this.Load += new System.EventHandler(this.FrmConsCredit_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StripMenuFile;
        private System.Windows.Forms.ToolStripMenuItem StripMenuExit;
        private System.Windows.Forms.ToolStripMenuItem StripMenuClient;
        private System.Windows.Forms.ToolStripMenuItem StripMenuSearchClient;
        private System.Windows.Forms.ToolStripMenuItem StripMenuContract;
        private System.Windows.Forms.ToolStripMenuItem StripMenuSearchContract;
        private System.Windows.Forms.ToolStripMenuItem StripMenuCreditP;
        private System.Windows.Forms.ToolStripMenuItem StripMenuSCreditP;
        private System.Windows.Forms.ToolStripMenuItem StripMenuNewCreditP;
    }
}