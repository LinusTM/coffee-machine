namespace coffee_machine;

internal class Keurig : CoffeeMachine {
    private static string[] buttons = new string[]{ "power", "brew" };

    internal Keurig() : base("Keurig", 120, buttons) { }
}
