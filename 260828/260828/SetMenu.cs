public class AmericanoSetMenu : MenuItem
{
    private string _name = "아메리카노 2+1 세트";

    public string Name
    {
        get { return _name; }
    }
    
    public AmericanoSetMenu(int itemCost) : base(itemCost)
    {
        itemCost = americanoCost;
    }

}