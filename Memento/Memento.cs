namespace DesignPatterns.Behavioral.Snapshot
{
    /// <summary>
    /// The 'Memento' class
    /// </summary>
    public class Memento
    {
        public string Name { get; }
        public string Phone { get; }
        public double Budget { get; }
        // Constructor
        public Memento(string name, string phone, double budget)
        {
            Name = name;
            Phone = phone;
            Budget = budget;
        }
    }
}