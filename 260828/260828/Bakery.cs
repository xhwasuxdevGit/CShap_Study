public class Cookie : Bakery
{
    private int menunumber = 6;
    private string _name = "쿠키";
    private int _cost = 1000;
    private float packCost;
    private const int discounCondition = 2;
    private const int discounRate = 75;
    public static int _count = 0;
    private int totalPrice;
    public Cookie()
    {
        _count++;
        
        if (_count > discounCondition)
        {
            packCost = ((_count * _cost) / 100) * discounRate;
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
    
    void PrintInfo()
    {
        Console.WriteLine($"[할인 품목]");
        Console.WriteLine($"({discounCondition+1}개이상 구매시 {discounRate}% 가격으로 제공) ");
        Console.WriteLine($"{menunumber}, {Name}[{MenuGroup}]  가격:  {Cost}원");
    }
}

public class SaltBread : Bakery
{
    private int menunumber = 7;
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

    void PrintInfo()
    {
       
        Console.WriteLine($"{menunumber}, {Name}[{MenuGroup}]  가격:  {Cost}원");
    }
}

public class Waffle : Bakery
{
    private int menunumber = 8;
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

    void PrintInfo()
    {
        Console.WriteLine($"{menunumber}, {Name}[{MenuGroup}]  가격:  {Cost}원");
    }
}