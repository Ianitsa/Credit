namespace KursovaZadacha
{
    partial class ReviewContract
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
            this.btnReviewContractExit = new System.Windows.Forms.Button();
            this.richTextBoxContract = new System.Windows.Forms.RichTextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Договор";
            // 
            // btnReviewContractExit
            // 
            this.btnReviewContractExit.Location = new System.Drawing.Point(67, 440);
            this.btnReviewContractExit.Name = "btnReviewContractExit";
            this.btnReviewContractExit.Size = new System.Drawing.Size(75, 23);
            this.btnReviewContractExit.TabIndex = 2;
            this.btnReviewContractExit.Text = "Изход";
            this.btnReviewContractExit.UseVisualStyleBackColor = true;
            this.btnReviewContractExit.Click += new System.EventHandler(this.btnReviewContractExit_Click);
            // 
            // richTextBoxContract
            // 
            this.richTextBoxContract.Location = new System.Drawing.Point(91, 93);
            this.richTextBoxContract.Name = "richTextBoxContract";
            this.richTextBoxContract.Size = new System.Drawing.Size(482, 278);
            this.richTextBoxContract.TabIndex = 3;
            this.richTextBoxContract.Text = "";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(519, 440);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Принтирай";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // ReviewContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 525);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.richTextBoxContract);
            this.Controls.Add(this.btnReviewContractExit);
            this.Controls.Add(this.label1);
            this.Name = "ReviewContract";
            this.Text = "Преглед на договора";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReviewContract_FormClosing);
            this.Load += new System.EventHandler(this.ReviewContract_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReviewContractExit;
        private System.Windows.Forms.RichTextBox richTextBoxContract;
        private System.Windows.Forms.Button btnPrint;
    }
}