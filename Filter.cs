namespace coffee_machine;

internal class Filter : IFilter {
    private double durability;
    private string exception;

    internal Filter(double durability, string exception) {
        this.durability = durability;
        this.exception = exception;
    }

    public double Durability { get => durability; }
    public string Exception { get => Exception; }

    public string FilterContent() {
        return exception;
    }
}
