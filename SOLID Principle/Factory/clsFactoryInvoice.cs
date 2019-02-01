using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class clsFactoryInvoice
    {
        public static IInvoice getInvoice(int invoiceType)
        {
            IInvoice invoice = null;
            if (invoiceType == 1)
            {
                invoice= new InvoiceWithHeader();
            }
            else if (invoiceType == 2)
            { invoice = new InvoiceWithoutHeader(); }
            return invoice;
        }       
    }
}
