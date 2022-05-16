namespace coffee_machine;

internal class DeLonghi : CoffeeMachine {
    private static string[] buttons = new string[]{ "power", "brew", "hot-plate" };

    internal DeLonghi() : base("De'Longhi", 120, buttons) { }
}
