using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    public class InsuranceBundle : BundleDecorator
    {
        private float insuranceCost;

        public InsuranceBundle(IInvoiceItem invoiceItem, float insuranceCost)
            : base(invoiceItem)
        {
            this.insuranceCost = insuranceCost;
        }

        public override string GetDetails()
        {
            return invoiceItem.GetDetails() + $" + insurance Cost ({insuranceCost})";
        }

        public override float GetPrice()
        {
            return invoiceItem.GetPrice()+ insuranceCost;
        }
    }
}
