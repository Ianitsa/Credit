using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaZadacha
{
  public  class Customer
    {
      char mytype;
      public char MyType
      { 
          get {return mytype ;} 
          set {mytype=value ;}
      }
      string cust_Id;
      public string Cust_Id
      {
          get { return cust_Id; }
          set { cust_Id = value; }
      }

      string name;
      public string Name
      {
          get { return name; }
          set { name = value; }
      }

      string egn;
      public string EGN
      {
          get { return egn; }
          set { egn = value; }
      }

      string sex;
      public string Sex
      {
          get { return sex; }
          set { sex = value; }
      }


      string e_mail;
      public string E_mail
      {
          get { return e_mail; }
          set { e_mail = value; }
      }

      string companyName;
      public string CompanyName
      {
          get { return companyName; }
          set { companyName = value; }
      }


      string tel;
      public string Tel
      {
          get { return tel; }
          set { tel = value; }
      }

      string bulstat;
      public string BULSTAT
      {
          get { return bulstat; }
          set { bulstat = value; }
      }

      string address;
      public string Address
      {
          get { return address; }
          set { address = value; }
      }

    }

}
