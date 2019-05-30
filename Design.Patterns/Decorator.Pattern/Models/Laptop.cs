namespace Decorator.Pattern.Models
{
    public class Laptop : Computer
    {
        public Laptop()
        {
            Description = "laptop";
            Cost = 300;
        }

        public override string Description { get; set; }
        public override int Cost { get; }
    }
}