public partial class DatabaseComponent
{
    public CurrencyDatabase Currency { get; private set; }

    private void Start()
    {
        Currency = AddDatabase<CurrencyDatabase>();
    }
}
