namespace Decorator.Pattern.Models
{
    public class HighSpecLaptopDecorator : Computer
    {
        public HighSpecLaptopDecorator(Computer computer)
        {
            Description = computer.Description + ", High Spec";
            Cost = 800 + computer.Cost;
        }

        public override string Description { get; set; }
        public override int Cost { get; }
    }
}