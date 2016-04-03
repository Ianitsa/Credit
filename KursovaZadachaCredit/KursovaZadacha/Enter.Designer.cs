namespace KursovaZadacha
{
    partial class InnerForm
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
            this.UserLbl = new System.Windows.Forms.Label();
            this.PassLbl = new System.Windows.Forms.Label();
            this.InBtn = new System.Windows.Forms.Button();
            this.UserTxtBox = new System.Windows.Forms.TextBox();
            this.PassTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.Location = new System.Drawing.Point(47, 33);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(108, 13);
            this.UserLbl.TabIndex = 0;
            this.UserLbl.Text = "Потребителско име";
            // 
            // PassLbl
            // 
            this.PassLbl.AutoSize = true;
            this.PassLbl.Location = new System.Drawing.Point(47, 83);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.Size = new System.Drawing.Size(45, 13);
            this.PassLbl.TabIndex = 1;
            this.PassLbl.Text = "Парола";
            // 
            // InBtn
            // 
            this.InBtn.Location = new System.Drawing.Point(176, 172);
            this.InBtn.Name = "InBtn";
            this.InBtn.Size = new System.Drawing.Size(75, 23);
            this.InBtn.TabIndex = 2;
            this.InBtn.Text = "Вход";
            this.InBtn.UseVisualStyleBackColor = true;
            this.InBtn.Click += new System.EventHandler(this.InBtn_Click);
            // 
            // UserTxtBox
            // 
            this.UserTxtBox.Location = new System.Drawing.Point(251, 33);
            this.UserTxtBox.Name = "UserTxtBox";
            this.UserTxtBox.Size = new System.Drawing.Size(100, 20);
            this.UserTxtBox.TabIndex = 3;
            this.UserTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PassTxtBox
            // 
            this.PassTxtBox.Location = new System.Drawing.Point(251, 80);
            this.PassTxtBox.Name = "PassTxtBox";
            this.PassTxtBox.PasswordChar = '*';
            this.PassTxtBox.Size = new System.Drawing.Size(100, 20);
            this.PassTxtBox.TabIndex = 4;
            this.PassTxtBox.TextChanged += new System.EventHandler(this.PassTxtBox_TextChanged);
            // 
            // InnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 316);
            this.Controls.Add(this.PassTxtBox);
            this.Controls.Add(this.UserTxtBox);
            this.Controls.Add(this.InBtn);
            this.Controls.Add(this.PassLbl);
            this.Controls.Add(this.UserLbl);
            this.Name = "InnerForm";
            this.Text = "Вход в системата";
            this.Load += new System.EventHandler(this.InnerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserLbl;
        private System.Windows.Forms.Label PassLbl;
        private System.Windows.Forms.Button InBtn;
        private System.Windows.Forms.TextBox UserTxtBox;
        private System.Windows.Forms.TextBox PassTxtBox;
    }
}

