namespace coffee_machine;

interface IFilter {
    string FilterType { get; }
    string LifeSpan { get; }

    public void FilterContent(string contentException);
}
