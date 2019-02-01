using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class InvoiceWithHeader : IInvoice
    {
        public void print()
        {
            Console.WriteLine("InvoiceWithHeader.......");
        }
    }
}
