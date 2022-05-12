namespace coffee_machine;

internal abstract class Appliance : IAppliance {
    private string type;
    private string brand;
    private int voltage;
    private string[] buttons;

    internal Appliance(string type, string brand, int voltage, string[] buttons) {
        this.type = type;
        this.brand = brand;
        this.voltage = voltage;
        this.buttons = buttons;
    }

    public string Type { get => type; }
    public string Brand { get => brand; }
    public int Voltage { get => voltage; }
    public string[] Buttons { get => buttons; }

    public void TurnOff() { } 
    public void TurnOn() { } 
}
