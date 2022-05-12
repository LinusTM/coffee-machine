namespace coffee_machine;

interface ILiquidContainer {
    string LiquidType { get; }
    double LiquidCapacity { get; }
    double LiquidAmount { get; }
    
    public void FillTank(double waterCapcity);
    public void EmptyTank(double useWater, double waterAmount);
}
