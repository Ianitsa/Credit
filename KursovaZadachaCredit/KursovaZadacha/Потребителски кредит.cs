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
    public partial class FrmConsCredit : Form
    {
        public FrmConsCredit()
        {
            InitializeComponent();
        }

        private void FrmConsCredit_Load(object sender, EventArgs e)
        
        {

        }

        private void StripMenuSearchClient_Click(object sender, EventArgs e)
        {
            frmSearchClient frmSearchClient = new frmSearchClient();
            frmSearchClient.MdiParent = this;
            frmSearchClient.Show();
            //frmSearchClient.Dispose();
        }

        private void StripMenuSearchContract_Click(object sender, EventArgs e)
        {
            frmSearchContract frmSearchContract = new frmSearchContract();
            //frmSearchContract.ShowDialog();

            frmSearchContract.MdiParent = this;
            frmSearchContract.Show();
           // frmSearchContract.Dispose();
        }

        private void StripMenuSCreditP_Click(object sender, EventArgs e)
        {
            frmSearchCreditProduct frmSearchCreditProduct = new frmSearchCreditProduct();
            frmSearchCreditProduct.MdiParent = this;
            frmSearchCreditProduct.Show();
            //frmSearchCreditProduct.ShowDialog();
            //frmSearchCreditProduct.Dispose();
        }

        private void StripMenuNewCreditP_Click(object sender, EventArgs e)
        {
            NewCrProd frmCreditProduct = new NewCrProd();
            frmCreditProduct.MdiParent = this;
            frmCreditProduct.Show();
            //to do

            //frmCreditProduct.ShowDialog();
            //frmCreditProduct.Dispose();
        }

        private void StripMenuExit_Click(object sender, EventArgs e)
        {
            

            InnerForm enter = new InnerForm();
            enter.MdiParent = this.MdiParent;
            enter.Show();

            this.Close();
        }
        
        
    }
}
