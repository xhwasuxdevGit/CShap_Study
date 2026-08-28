public class Cookie : Bakery
{
    private string _name = "쿠키";

    public string Name
    {
        get { return _name; }
    }
    
    public Cookie(int itemCost = 1000) : base(itemCost)
    {
        _cost = itemCost;
    }

}

public class SaltBread : Bakery
{
    private string _name = "소금빵";

    public string Name
    {
        get { return _name; }
    }
    
    public SaltBread(int itemCost = 2000) : base(itemCost)
    {
        _cost = itemCost;
    }

}

public class Waffle : Bakery
{
    private string _name = "와플";

    public string Name
    {
        get { return _name; }
    }

    public Waffle(int itemCost = 1500) : base(itemCost)
    {
        _cost = itemCost;
    }

}