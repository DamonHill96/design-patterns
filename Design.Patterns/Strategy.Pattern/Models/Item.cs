using System;
using Strategy.Pattern.Checkout;

namespace Strategy.Pattern.Models
{
    public abstract class Item
    {
        public abstract ICheckoutBehaviour CheckoutBehaviour { get; }
        public abstract Guid Id { get; }
        public abstract string Name { get; }

        public string Checkout()
        {
            return CheckoutBehaviour.Checkout();
        }

        public abstract void Return();
    }
}