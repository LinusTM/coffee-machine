namespace coffee_machine;

interface IBrew {
    double Water { get; }
    double brewable { get; }
    string FilterDurability { get; }
    string FilterException { get; }

    public string Brew(double water, double brewable, string filterDurability, string filterException);
}
