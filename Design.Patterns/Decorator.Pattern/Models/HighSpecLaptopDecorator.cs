namespace Decorator.Pattern.Models
{
    public class HighSpecLaptopDecorator : Computer
    {
        private readonly Computer _computer;

        public HighSpecLaptopDecorator(Computer computer)
        {
            Description = computer.Description + ", High Spec";
            Cost = 800 + _computer.Cost;
        }

        public override string Description { get; set; }
        public override int Cost { get; }
    }
}