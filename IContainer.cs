namespace coffee_machine;

interface IContainer {
    string ContainerType { get; }
    double Capacity { get; }
    double Amount { get; }
    
    public double FillContainer(double fill);
    public double EmptyContainer(double use);
}
