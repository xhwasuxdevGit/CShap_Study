public class AmericanoSetMenu : Americano
{
    private string _name = "아메리카노 2+1 세트";
    private int _cost;
    public string Name
    {
        get { return _name; }
    }
    
    public AmericanoSetMenu()
    {
        _cost = AmericanoCost * 2;
    }
    public int Cost
    {
       get { return _cost; }
    }
}