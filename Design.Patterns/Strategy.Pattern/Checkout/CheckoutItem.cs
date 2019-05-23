using System;
using Strategy.Pattern.Models;

namespace Strategy.Pattern.Checkout
{
    public class CheckoutItem : ICheckoutBehaviour
    {
        public string Checkout()
        {
            return "Checked out!";
        }
    }
}