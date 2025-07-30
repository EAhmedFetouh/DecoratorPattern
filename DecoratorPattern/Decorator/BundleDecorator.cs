using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    public abstract class BundleDecorator : IInvoiceItem
    {

        protected IInvoiceItem invoiceItem;

        public BundleDecorator(IInvoiceItem invoiceItem)
        {
            this.invoiceItem = invoiceItem;
        }
        public abstract string GetDetails();

        public abstract float GetPrice();
    }
}
