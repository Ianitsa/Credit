using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovaZadacha
{
    public partial class InnerForm : Form
    {
        public InnerForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           
           
        }

        private void PassTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            string user = "a";
            int pass = 1;

            if (UserTxtBox.Text == "a" && PassTxtBox.Text == "1")
            {
                FrmConsCredit frmConsCredit = new FrmConsCredit();
                frmConsCredit.ShowDialog();
                frmConsCredit.Dispose();
               
            }
            else
            {
                string mess = "Моля въведете коректни потребител и парола!";
                DialogResult result;
                result = MessageBox.Show(mess);
                InnerForm form = new InnerForm();
                form.ShowDialog();

            }
        }

        private void InnerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
