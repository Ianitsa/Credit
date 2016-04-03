using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KursovaZadacha
{
    class MyExeption : Exception
    {
        private string p;

        public MyExeption(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }
    }
}
