using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    public class DiscountBundle : BundleDecorator
    {
        private float discountRate;

        public DiscountBundle( IInvoiceItem invoiceItem , float discountRate)
            :base(invoiceItem)
        {
            this.discountRate = discountRate;
        }

        public override string GetDetails()
        {
            return invoiceItem.GetDetails() + $" + Discount Rate ({discountRate})";
        }

        public override float GetPrice()
        {
            return invoiceItem.GetPrice() * (1 - discountRate);
        }
    }
}
