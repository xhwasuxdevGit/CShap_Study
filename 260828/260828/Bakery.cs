public class Cookie : Bakery
{
    private string _name = "쿠키";
    private int _cost = 1000;
    private float packCost;
    const int discounCondition = 2;
    
    public static int _count = 0;
    private int totalPrice;
    public Cookie()
    {
        _count++;
        
        if (_count > discounCondition)
        {
            packCost = ((_count * _cost) / 100) * 75;
            _cost = (int)packCost;
        }
        totalPrice = _cost *  _count;
    }

    public int TotalPrice
    {
        get { return totalPrice; }
    }

    public string Name
    {
        get { return _name; }
    }
    
    public int Cost
    {
        get { return _cost; }
    }
    
}

public class SaltBread : Bakery
{
    private string _name = "소금빵";
    private int _cost = 2000;
    public static int _count = 0;
    private int totalPrice;
    public SaltBread()
    {
        _count++;
        totalPrice = _cost *  _count;
    }

    public int TotalPrice
    {
        get { return totalPrice; }
    }
    
    public string Name
    {
        get { return _name; }
    }
    public int Cost
    {
        get { return _cost; }
    }

}

public class Waffle : Bakery
{
    private string _name = "와플";
    private int _cost = 1500;
    public static int _count = 0;
    private int totalPrice;
    public Waffle()
    {
        _count++;
        totalPrice = _cost *  _count;
    }
    public string Name
    {
        get { return _name; }
    }
    public int Cost
    {
        get { return _cost; }
    }

}