using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KursovaZadacha
{
    public class CreditProduct
    {

        

        string productCod;
        public string Cod
        {
            get { return productCod; }
            set { productCod = value; }
        }

        string productName;
        public string N
        {
            get { return productName; }
            set { productName = value; }
        }

        string interest;
        public string Interest
        {
            get { return interest; }
            set { interest = value; }
        }

        string srocnosti;
        public string DS
        {
            get { return srocnosti; }
            set {srocnosti= value; }
        }

        string intervalSum;
        public string DS2
        {
            get { return intervalSum; }
            set { intervalSum = value; }
        }

        string sum_from;
        public string Sum_from
        {
            get { return sum_from; }
            set { sum_from = value; }
        }


        string sum_to;
        public string Sum_to
        {
            get { return sum_to; }
            set { sum_to = value; }
        }

        char status;
        public char Status
        {
            get { return  status; }
            set {  status = value; }
        }
    }
}
