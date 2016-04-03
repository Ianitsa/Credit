using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KursovaZadacha
{
    public partial class frmNewContract : Form
    {
        public frmNewContract()
        {
            InitializeComponent();
        }
        public frmNewContract(Customer custm)
        {
            InitializeComponent();
            this.c = custm;
        }
        //Contract cont;
        //public frmNewContract(Customer custm,Contract con)
        //{
        //    InitializeComponent();
        //    this.c = custm;
        //    this.cont = con;
        //}


        private void frmNewContract_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Сигурни ли сте,че искате да затворите?", "Изход?", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnReviewContract_Click(object sender, EventArgs e)
        {
            this.Hide();

            Customer newC = new Customer();
            Contract contr = new Contract();
            CreditProduct crP = new CreditProduct();

            newC.Cust_Id = txtClientID.Text;
            newC.Name = txtFullName.Text;
            newC.EGN = txtEGN_contr.Text;
            newC.CompanyName = txtFirmName.Text;
            newC.BULSTAT = txtBULSTAT_Contr.Text;
            newC.Address = txtAddressContract.Text;
            newC.Tel = txtTel_contr.Text;
            newC.E_mail = txtE_mail_contr.Text;

            contr.DataC = dateTimePicker1.Value;
            contr.SrocC = cbLimit.Text;
            contr.VidCtedit = cb_credit_contr.Text;
            contr.DataEndC =Convert.ToDateTime( txtEndContract_contr.Text);
           // cont.DataBeginC = Convert.ToDateTime(txtBeginContract_contr.Text);          
            contr.WantValueC = txtWantValue.Text;

            contr.TotalC = txtTel_contr.Text;
            contr.RazmerVnoska = txtSizePayment.Text;
            contr.Padej = dtpMaturity.Text;
            contr.NoVnoska = txtNumPayment.Text;
            

            //to do 


          


            ReviewContract frm1 = new ReviewContract(newC, contr, crP);
            frm1.MdiParent = this.MdiParent;
            frm1.Show();


        }

       


        DateTime beginContract, endContract;
        string purposeOfCredit;
        double sum, interest;
        double payment, total;
        int period;

        //da se zatedqt dannite za klienta
        private Customer c;


        private void frmNewContract_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ianiDataSet.CREDIT_PRODUCT' table. You can move, or remove it, as needed.
            this.cREDIT_PRODUCTTableAdapter.Fill(this.ianiDataSet.CREDIT_PRODUCT);
            //ТОДО da spra dostapa v poletata v  osnovni danni , bez № na dog!!!!!!
            txtFullName.ReadOnly = true;
            txtFullName.ReadOnly = true;
            txtEGN_contr.ReadOnly = true;
            txtBULSTAT_Contr.ReadOnly = true;
            txtE_mail_contr.ReadOnly = true;
            txtTel_contr.ReadOnly = true;
            txtAddressContract.ReadOnly = true;


            //DateTime dat = DateTime.Now;
            //txtDate.Text = dat.ToString();

            //da se zatedqt dannite za klienta
            txtClientID.Text = c.Cust_Id;
            txtFullName.Text = c.Name;
            txtEGN_contr.Text = c.EGN;
            txtFirmName.Text = c.CompanyName;
            txtAddressContract.Text = c.Address;
            txtBULSTAT_Contr.Text = c.BULSTAT;
            txtTel_contr.Text = c.Tel;
            txtE_mail_contr.Text = c.E_mail;
            if (c.MyType == '0')
            { rbtnJL.Checked = true; }
            else { rbtnFL.Checked = true; }

            if (c.MyType == 'm')
            { rbtnMan.Checked = true; }
            else { rbtnWaman.Checked = true; }


            // int meseci;
            // for (int i = 4; i < 24; i++)
            // {
            //     meseci = i;
            //     i++;
            // }


            //string[] srok = meseci.ToString().Split();
            // cbLimit.DataSource = srok;
            // cbLimit.SelectedIndex = -1;

//


            string[] Articuls = { "stocov_Kredit", "Parchen_Kredit" };
            cb_credit_contr.DataSource = Articuls;
            cb_credit_contr.SelectedIndex = -1;

            //beginContract = dateTimePicker1.Value;
            //txtBeginContract_contr.Text = beginContract.ToString();

            txtBeginContract_contr.ReadOnly = true;
            dateTimePicker1.Enabled = false;

            txtNumPayment.ReadOnly = true;
            //txtNumPayment - da se zarejda ot DB

            txtTotal.ReadOnly = true;
            txtSizePayment.ReadOnly = true;

            //beginContract = dat;
            beginContract = dateTimePicker1.Value;
            txtBeginContract_contr.Text = beginContract.ToString();


            //iscana sum- da se validira sprqmo ogranicheniqta na vida credit






        }

        private void cbLimit_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEndContract_contr.ReadOnly = true;
            //кр=нач+срока
            DateTime dat = this.dateTimePicker1.Value;
            txtEndContract_contr.Text = dat.AddMonths(Convert.ToInt32(this.cbLimit.Text)).ToString();
            //txtEndContract_contr.Text = dat.ToString();
        }

        private void txtWantValue_Validating(object sender, CancelEventArgs e)
        {
            if (txtWantValue.Text == "")
            {
                errorProvider1.SetError(txtWantValue, "Моля, попълнете стойност");
                e.Cancel = true;
            }


                //???
            //else if (Convert.ToInt32(txtWantValue)<400||Convert.ToInt32(txtWantValue)>4000)
            //{
            //    errorProvider1.SetError(txtWantValue, "Моля, въведете стойност м/у 400 и 4000");
            //    e.Cancel = true;
            //}
        }


        private void txtWantValue_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtWantValue, "");
        }

        private void btnSaveContract_Click(object sender, EventArgs e)
        {
            SqlConnection connection = NewCustomer.CreateConection();
            using (connection)
            {
                SqlCommand mycommand = new SqlCommand("sp_isertCredit", connection);
                mycommand.CommandType = CommandType.StoredProcedure;
                mycommand.CommandText = "sp_isertCredit";

    //  @Credit_NO nvarchar(50),
    //@Cr_date datetime,
    //@Cr_period int,
    //@Cr_end_date datetime,
    //@Cr_begin_date datetime,
    //@Cr_client_id int,
    //@prod_code int,
    //@Cr_sum numeric(10,2),
    //@Cr_note nvarchar(400)

                SqlParameter Cl_id = new SqlParameter("@Cr_client_id", SqlDbType.Int);
                Cl_id.Value = Convert.ToInt32(txtClientID.Text);
                mycommand.Parameters.Add(Cl_id);

                SqlParameter Cr_No = new SqlParameter("@Credit_NO", SqlDbType.NVarChar);
                Cr_No.Value = txtNoContract.Text;
                mycommand.Parameters.Add(Cr_No);

                SqlParameter Cr_srock = new SqlParameter("@Cr_period", SqlDbType.Int);
                Cr_srock.Value = Convert.ToInt32(cbLimit.Text);
                mycommand.Parameters.Add(Cr_srock);


                //***????????????Datetime



                SqlParameter Cr_end = new SqlParameter("@Cr_end_date", SqlDbType.DateTime);
                //Cr_end.Value = Convert.ToDateTime(txtEndContract_contr.Text);
                Cr_end.Value = txtEndContract_contr.Text;
                mycommand.Parameters.Add(Cr_end);

                //DateTime current = DateTime.Now;
                // current = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy hh:mm"));


                // cmd.Parameters.Add("@DateofBirth",SqlDbType.DateTime).Value=dateTimePicker.Value;

                SqlParameter Cr_date = new SqlParameter("@Cr_date", SqlDbType.DateTime);
                //Cr_date.Value = txtDate.Text;
                Cr_date.Value = dateTimePicker1.Value;

                // Cr_date.Value = Convert.ToString(dateTimePicker1.Value);
                //Cr_date.Value = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
                //Cr_date.Value = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy hh:mm"));
                mycommand.Parameters.Add(Cr_date);

                SqlParameter Cr_begin = new SqlParameter("@Cr_begin_date", SqlDbType.DateTime);
                Cr_begin.Value = txtBeginContract_contr.Text;
                //Cr_begin.Value = Convert.ToDateTime(txtBeginContract_contr.Text);
                mycommand.Parameters.Add(Cr_begin);

               


                SqlParameter Product_id = new SqlParameter("@prod_code", SqlDbType.Int);

                Product_id.Value = 3;// cb_credit_contr.ValueMember;

                //if (cb_credit_contr.SelectedValue == "stocov_Kredit")
                //{
                //    // double tEuroTotalLv = tEuroTotal * 1.95;
                //    //txtTTotalLv.Text = tEuroTotalLv.ToString();
                //    //FL.Value = Convert.ToChar("1");
                //    Product_id.Value = 3;
                //   // Product_id.Value = Convert.ToInt32(3);
                //}
                //else
                //{
                //    Product_id.Value = 4;
                //    //Product_id.Value = Convert.ToInt32(4);
                //}              
                mycommand.Parameters.Add(Product_id);

                SqlParameter Cr_sum = new SqlParameter("@Cr_sum", SqlDbType.Int);
                Cr_sum.Value = txtWantValue.Text;
               // Cr_sum.Value = txtTotal.Text;
                mycommand.Parameters.Add(Cr_sum);

                SqlParameter Cr_note = new SqlParameter("@Cr_note", SqlDbType.NVarChar);

                Cr_note.Value = txtPurposeCredit_contr.Text;
                mycommand.Parameters.Add(Cr_note);

                try
                {
                    connection.Open();
                    mycommand.ExecuteNonQuery();
                   
                    MessageBox.Show("Договора беше добавен успешно!");
                }
                catch (SqlException ol)
                {

                    MessageBox.Show(ol.Message.ToString());
                }
         

            }

            
        }

       

        private void btnIzchisli_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (txtWantValue.Text == "")
            //    {
            //        throw new MyExeption("Моля, попълнете стойност в поле Искана сума!");
            //    }
            //    else if (Convert.ToInt32(txtWantValue)> 400 && Convert.ToInt32(txtWantValue) <4000)
            //    {
            //        MessageBox.Show("Моля, въведете стойност м/у 400 и 4000");
            //        return;
            //    }

            //}
            //catch (MyExeption ee)
            //{
            //    MessageBox.Show(ee.ToString());
            //    return;
            //}

            //if (cb_credit_contr.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Моля,  изберете кредит!");
            //    return;
            //}

            //if (cbLimit.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Моля,  изберете срок!");
            //    return;
            //}



           

           // frmCreditProduct credProduct = new frmCreditProduct();
           // credProduct.Show();

            sum = Convert.ToDouble(txtWantValue.Text);
            period = Convert.ToInt32(cbLimit.Text);
           
           // interest = credProduct.Interest; 
            //0,75=интерест

            payment = (sum * 0.0075) / (1 - (1 / Math.Pow((1 + 0.0075), period)));

           string s=string.Format("{0:F2}", payment);
            txtSizePayment.Text = s.ToString();




            total = payment * period;
            string totalt = string.Format("{0:F2}", total);
            txtTotal.Text = totalt.ToString();


        }

        private void cb_credit_contr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

       
    }
}