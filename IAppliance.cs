namespace coffee_machine;

interface IAppliance {
    string Type { get; }
    string Brand { get; }
    int Voltage { get; }
    string[] Buttons { get; }

    public void TurnOn();
    public void TurnOff();
}
