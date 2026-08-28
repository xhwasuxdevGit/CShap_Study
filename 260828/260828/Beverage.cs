// 세부 음료 클래스

public class Americano : Beverage
{
    private string _name = "아메리카노";
    private int _cost = 2000;
    public static int _count = 0;
    private int totalPrice;
    const int discounCondition = 2;

    public Americano()
    {
        _count++;

        if ((_count % discounCondition) == 0)
        {
            totalPrice = (_cost * _count) - _cost;
        }
        else
        {
            totalPrice = (_cost * _count);
        }
        
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
    
    public int AmericanoCost
    {
        get { return _cost; }
    }
}

public class Cafflatte : Beverage
{
    private string _name = "카페라떼";
    private int _cost = 2000;
    public static int _count = 0;
    private int totalPrice;
    
    public Cafflatte()
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

public class IceTea : Beverage
{
    private string _name = "아이스티";
    private int _cost = 3000;
    public static int _count = 0;
    private int totalPrice;
    public IceTea()
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

public class GreenTea : Beverage
{
    private string _name = "녹차";
    private int _cost = 2500;
    public static int _count = 0;
    private int totalPrice;
    public GreenTea()
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

public class ChocoLatte : Beverage
{
    private string _name = "쵸코라떼";
    private int _cost = 3500;
    public static int _count = 0;
    private int totalPrice;
    public ChocoLatte()
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