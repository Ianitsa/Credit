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
    public partial class ReviewContract : Form
    {
        //za da se zaredqt dannite ot newContract
        Customer cu;
        Contract contr;
        CreditProduct crP;

        public ReviewContract()
        {
            InitializeComponent();
        }

        public ReviewContract(Customer arg,Contract conn,CreditProduct credP )
        {
            InitializeComponent();

            this.cu = arg;
            this.contr =conn;
            this.crP = credP;

        }

        private void ReviewContract_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Сигурни ли сте,че искате да затворите?", "Изход?", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnReviewContractExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReviewContract_Load(object sender, EventArgs e)
        {
            //richTxt.Text += txtNum.Text + Environment.NewLine + txtGroup.Text + Environment.NewLine + txtDir.Text;

            //frmNewContract contractReview = new frmNewContract();
            //Customer cu = new Customer();


            //za da se zaredqt dannite ot newContract
            string infoIme = "Име:       ";
            string infoEgn = "ЕГН:       ";
            string infoFirm = "Име на фирма: ";
            string bulstat="BULSTAT:    "  ;
            string address = "Адрес:    ";
            string tel="Телефон:   " ;
            string e_mail="Е_меил:   "  ;
            //тодо
            richTextBoxContract.Text += infoIme + cu.Name + "\n";
            richTextBoxContract.Text += infoEgn +cu.EGN + "\n";
            richTextBoxContract.Text +=infoFirm+ cu.CompanyName + "\n";
            richTextBoxContract.Text += bulstat+ cu.BULSTAT + "\n";
            richTextBoxContract.Text += address + cu.Address + "\n";
            richTextBoxContract.Text += tel+cu.Tel + "\n";
            richTextBoxContract.Text += e_mail+cu.E_mail + "\n";

            string dataContr = "Дата:       ";
            string  vidCr ="Вид кредит:      ";
             string  srocCr ="Срок:      ";
             string beginCr  ="Начало на кредита: ";
             string  endCr ="Край на кредита: ";
             string WanrSum = "Искана сума:    ";
            // string NoVnoska= "";
             string padej = "Падеж:     ";
             string sizeValue = "Размер на вноска: ";
             string total = "Сумарен ред: ";

            richTextBoxContract.Text +=dataContr + contr.DataC + "\n";
            richTextBoxContract.Text +=vidCr+ contr.VidCtedit + "\n";
            richTextBoxContract.Text +=srocCr+ contr.SrocC + "\n";
            richTextBoxContract.Text +=beginCr+ contr.DataBeginC + "\n";
            richTextBoxContract.Text +=endCr+ contr.DataEndC + "\n";
            richTextBoxContract.Text +=WanrSum+ contr.WantValueC + "\n";
            //richTextBoxContract.Text += contr.NoVnoska + "\n";
            richTextBoxContract.Text +=padej+ contr.Padej + "\n";
            richTextBoxContract.Text +=sizeValue + contr.RazmerVnoska + "\n";
            richTextBoxContract.Text +=total + contr.TotalC+ "\n";




        }

        
       
    }
}
