using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class InvoiceWithoutHeader : IInvoice
    {
        public void print()
        {
            Console.WriteLine("InvoiceWithoutHeader.......");
        }
    }
}
