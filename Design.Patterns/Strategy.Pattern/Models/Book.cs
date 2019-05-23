using System;
using Strategy.Pattern.Checkout;

namespace Strategy.Pattern.Models
{
    public class Book : Item
    {
        public Book(Guid id, string name)
        {
            Id = id;
            Name = name;
            CheckoutBehaviour = new CheckoutItemWithLateFees();
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