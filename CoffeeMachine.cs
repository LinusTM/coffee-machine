namespace coffee_machine;

internal abstract class CoffeeMachine : Appliance, IBrew {
    private double water;
    private double brewable;
    private string filterDurability;
    private string filterException;

    internal CoffeeMachine(string brand, int voltage, string[] buttons) : 
        base("Coffee Machine", brand, voltage, buttons) {
            Container coffeeContainer = new Container("coffee", 4.0, 2.4);
            Container waterContainer = new Container("water", 10.5, 5.0);
            Filter coffeeFilter = new Filter(2.0, "coffee");
        }

    public string Brew() {

    }
}
