namespace coffee_machine;

internal class Container : IContainer {
    private string containerType;
    private double capacity;
    private double amount;

    internal Container(string containerType, double capacity, double amount) {
        this.containerType = containerType;
        this.capacity = capacity;
        this.amount = amount;
    }

    public string ContainerType { get => containerType; }
    public double Capacity { get => capacity; }
    public double Amount { get => amount; }

    public double FillContainer(double fill) {
        if(amount == capacity) {
            return amount;
        } else {
            return amount += fill;
        }
    }

    public double EmptyContainer(double use) {
        double newAmount; 
        newAmount = amount - use;

        if(amount <= 0) {
            return 0;
        } else {
            return amount -= use;
        }
    }
}
