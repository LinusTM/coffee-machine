interface IAppliance {
    public string Type { get; }
    public string Brand { get; }
    public int Voltage { get; }
    public string[] Buttons { get; }

    public void TurnOn();
    public void TurnOff();
}
