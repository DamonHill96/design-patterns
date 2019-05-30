namespace Observer.Pattern.Subjects
{
    public class PropertyChangeEventInformation
    {
        public PropertyChangeEventInformation(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}