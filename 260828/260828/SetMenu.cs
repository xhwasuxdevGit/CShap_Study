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

public class CookiePackSet : Cookie
{
    private string _name = "쿠키 가성비 세트";
    private int _cost;
    private float packCost;
    
    public CookiePackSet()
    {
        if (CookieCount > 2)
        {
            packCost = ((CookieCost * CookieCost) / 100) * 75;
            _cost = (int)packCost;
        }
    }
    
    public int Cost
    {
        get { return _cost; }
    }
    
}