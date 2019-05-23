using System;
using Strategy.Pattern.Checkout;

namespace Strategy.Pattern.Models
{
    public class Journal : Item
    {
        public Journal(Guid id, string name)
        {
            Id = id;
            Name = name;
            CheckoutBehaviour = new CheckoutItem();
        }

        public override Guid Id { get; }
        public override string Name { get; }
        public override ICheckoutBehaviour CheckoutBehaviour { get; }

        public override void Return()
        {
            throw new NotImplementedException();
        }
    }
}