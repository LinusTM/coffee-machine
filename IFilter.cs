namespace coffee_machine;

interface IFilter {
    double Durability { get; }
    string Exception { get; }

    public string FilterContent();
}
