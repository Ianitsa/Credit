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
    public partial class ReCustomer : Form
    {
        public ReCustomer()
        {
            InitializeComponent();

        }

        public ReCustomer(Customer cust)
        {
            InitializeComponent();
            this.c = cust;
        }

        private Customer c;

        private void btnNewContract_Click(object sender, EventArgs e)
        {
            this.Hide();

            Customer customer = new Customer();
            
            customer.Name = this.txtFNameLName_ReC.Text;

            if (this.rbtnJL_ReCustomer.Checked) { customer.MyType = Convert.ToChar("0"); }
            else { customer.MyType = Convert.ToChar("1"); }

            if (this.rbtnMan_ReCustomer.Checked) { customer.Sex = ("m"); }
            else { customer.Sex = ("w"); }

            this.txtClientID.Text = customer.Cust_Id;
            this.txtEGN_ReC.Text=customer.EGN;
            this.txtMail_ReC.Text=customer.E_mail;
            this.txtphone_ReC.Text=customer.Tel;
             this.txtCompanyName.Text=customer.CompanyName ;
             this.txtAddress_ReC.Text=customer.Address;
             this.txtBULSTAT.Text=customer.BULSTAT; 

         
           



            frmNewContract frm1 = new frmNewContract(c);
            frm1.MdiParent = this.MdiParent;
            frm1.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ReCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Сигурни ли сте,че искате да затворите?", "Изход?", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void ReCustomer_Load(object sender, EventArgs e)
        {
            //TODO   ......... zarejdane na danni za klienta

            //rbtnFL_ReCustomer.Enabled = false;
            //rbtnJL_ReCustomer.Enabled = false;
            
            txtFNameLName_ReC.ReadOnly = true;
            txtEGN_ReC.ReadOnly = true;
            rbtnMan_ReCustomer.Enabled = false;
            rbtnWaman_ReCustomer.Enabled = false;
            txtMail_ReC.ReadOnly = true;
            txtphone_ReC.ReadOnly = true;
            txtCompanyName.ReadOnly = true;
            txtBULSTAT.ReadOnly = true;
            txtAddress_ReC.ReadOnly = true;

            btnSave.Enabled = false;

//****---
            txtClientID.Text = c.Cust_Id;
            txtFNameLName_ReC.Text = c.Name;
            txtEGN_ReC.Text = c.EGN;
            txtCompanyName.Text = c.CompanyName;
            txtAddress_ReC.Text = c.Address;
            txtBULSTAT.Text = c.BULSTAT;
            txtphone_ReC.Text = c.Tel;
            txtMail_ReC.Text = c.E_mail;
            if (c.MyType == 'J')
            { rbtnJL_ReCustomer.Checked = true; }
            else { rbtnFL_ReCustomer.Checked = true; }

            if (c.MyType == 'm')
            { rbtnMan_ReCustomer.Checked = true; }
            else { rbtnWaman_ReCustomer.Checked = true; }

        }

        private void btnRedaction_Click(object sender, EventArgs e)
        {
            txtMail_ReC.ReadOnly = false;
            txtphone_ReC.ReadOnly = false;
            txtAddress_ReC.ReadOnly = false;

            btnSave.Enabled = true;
            btnNewContract.Enabled = false;

            btnRedaction.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnNewContract.Enabled = true;

            //todo  sp_udate
            SqlConnection connection = NewCustomer.CreateConection();

            using (connection)
            {
                SqlCommand mycommand = new SqlCommand("sp_UpdateClient", connection);
                mycommand.CommandType = CommandType.StoredProcedure;
                mycommand.CommandText = "sp_UpdateClient";

                SqlParameter clientid = new SqlParameter("@Customer_id", SqlDbType.Int);     
       
                if (txtClientID.Text != "")
                {
                    clientid.Value = Convert.ToInt32(txtClientID.Text);
                }
                else { clientid.Value = null; }
                mycommand.Parameters.Add(clientid);
                
    //@Customer_id int,
    //@Customer_type char(1),
    //@Customer_EGN_BULSTAT nvarchar(13),
    //@Customer_fullname nvarchar(400),
    //@Customer_EMAIL nvarchar(400),
    //@Customer_Phone nvarchar(400),
    //@Customer_address nvarchar(400),

//NE MOJE DA UPDATE ZARADI:
                //DA go iztriq!
    //@Customer_clientNote nvarchar(400)

                

                SqlParameter CL_EGN = new SqlParameter("@Customer_EGN_BULSTAT", SqlDbType.NVarChar);
                SqlParameter Fullname_nameCompany = new SqlParameter("@Customer_fullname", SqlDbType.NVarChar);
                SqlParameter FL = new SqlParameter("@Customer_type", SqlDbType.Char);

                if (this.rbtnJL_ReCustomer.Checked)
                {
                    FL.Value = Convert.ToChar("0");
                    CL_EGN.Value = txtBULSTAT.Text;
                    Fullname_nameCompany.Value = txtCompanyName.Text;
                }
                else
                {
                    FL.Value = Convert.ToChar("1");
                    CL_EGN.Value = txtEGN_ReC.Text;
                    Fullname_nameCompany.Value = txtFNameLName_ReC.Text;
                }
                mycommand.Parameters.Add(FL);
                mycommand.Parameters.Add(CL_EGN);
                mycommand.Parameters.Add(Fullname_nameCompany);


                SqlParameter CL_address = new SqlParameter("@Customer_address", SqlDbType.NVarChar);
                CL_address.Value = txtAddress_ReC.Text;
                mycommand.Parameters.Add(CL_address);

               // SqlParameter Fullname = new SqlParameter("@CLIENT_FULLNAME", SqlDbType.NVarChar);
               // Fullname.Value = txtFNameLName_ReC.Text;
               // mycommand.Parameters.Add(Fullname);
               //SqlParameter FullnameCompany = new SqlParameter("@CLIENT_FULLNAME", SqlDbType.NVarChar);
               // FullnameCompany.Value = txtCompanyName.Text;
               // mycommand.Parameters.Add(FullnameCompany);
               ////***???
               // SqlParameter FL = new SqlParameter("@CLIENT_TYPE", SqlDbType.Char);
               // FL.Value = rbtnFL_ReCustomer.Checked;
               // mycommand.Parameters.Add(FL);
               // SqlParameter JL = new SqlParameter("@CLIENT_TYPE", SqlDbType.Char);
               // JL.Value = rbtnJL_ReCustomer.Checked;
               // mycommand.Parameters.Add(JL);
               // SqlParameter CL_EGN = new SqlParameter("@CLIENT_EGN_BULSTAT", SqlDbType.NVarChar);
               // CL_EGN.Value = txtEGN_ReC.Text;
               // mycommand.Parameters.Add(CL_EGN);
               // SqlParameter Cl_BULSTAT = new SqlParameter("@CLIENT_EGN_BULSTAT", SqlDbType.NVarChar);
               // Cl_BULSTAT.Value = txtBULSTAT.Text;
               // mycommand.Parameters.Add(Cl_BULSTAT);

                SqlParameter Cl_EMAIL = new SqlParameter("@Customer_EMAIL", SqlDbType.NVarChar);
                Cl_EMAIL.Value = txtMail_ReC.Text;
                mycommand.Parameters.Add(Cl_EMAIL);

                SqlParameter Cl_TEL = new SqlParameter("@Customer_Phone", SqlDbType.NVarChar);
                Cl_TEL.Value = txtphone_ReC.Text;
                mycommand.Parameters.Add(Cl_TEL);

                try
                {
                    connection.Open();
                    mycommand.ExecuteNonQuery();
                    MessageBox.Show("Kлиента беше променен успешно!");
                }
                catch (SqlException ol)
                {

                    MessageBox.Show(ol.Message.ToString());
                }

                this.Refresh();
            }
        }
    }
}
