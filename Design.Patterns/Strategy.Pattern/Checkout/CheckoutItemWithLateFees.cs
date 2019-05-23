using System;

namespace Strategy.Pattern.Checkout
{
    public class CheckoutItemWithLateFees : ICheckoutBehaviour
    {
        public string Checkout()
        {
            return "Checked out. Beware of late fees!";
        }
    }
}