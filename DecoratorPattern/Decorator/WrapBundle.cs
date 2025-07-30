using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    public class WrapBundle : BundleDecorator
    {
        private float wrapCost;

        public WrapBundle(IInvoiceItem invoiceItem, float wrapCost)
            : base(invoiceItem)
        {
            this.wrapCost = wrapCost;
        }

        public override string GetDetails()
        {
            return invoiceItem.GetDetails() + $" + Wrap Cost ({wrapCost})";
        }

        public override float GetPrice()
        {
            return invoiceItem.GetPrice() + wrapCost;
        }
    }
}
