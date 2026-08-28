// 세부 음료 클래스

public class Americano : Beverage
{
    private int _menunumber = 1;
    private string _name = "아메리카노";
    private int _cost = 2000;
    public static int _count = 0;
    private int totalPrice;
    private const int discounCondition = 2;
    private const int discounMount = 1;
    
    public Americano()
    {
        _count++;

        if ((_count % discounCondition) == 0)
        {
            totalPrice = (_cost * _count) - discounMount;
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
    
    public int MenuNumber
    {
        get { return _menunumber; }
    }
    
    void PrintInfo()
    {
        Console.WriteLine($"[할인 품목]");
        Console.WriteLine($"({discounCondition}개를 구매하시면 {discounMount}개가 무료)");
        Console.WriteLine($"{MenuNumber}, {Name}[{MenuGroup}]  가격:  {Cost}원");
        Console.WriteLine("을 선택하셨습니다.");
    }
  
}

public class Cafflatte : Beverage
{
    private int _menunumber = 2;
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
    public int MenuNumber
    {
        get { return _menunumber; }
    }
    
    void PrintInfo()
    {
        Console.WriteLine($"{MenuNumber}, {Name}[{MenuGroup}]  가격:  {Cost}원");
        Console.WriteLine("을 선택하셨습니다.");
    }
 
}

public class IceTea : Beverage
{
    private int _menunumber = 3;
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
    public int MenuNumber
    {
        get { return _menunumber; }
    }
    
    void PrintInfo()
    {
        Console.WriteLine($"{MenuNumber}, {Name}[{MenuGroup}]  가격:  {Cost}원");
        Console.WriteLine("을 선택하셨습니다.");
    }
    
}

public class GreenTea : Beverage
{
    private int _menunumber = 4;
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
    public int MenuNumber
    {
        get { return _menunumber; }
    }
    void PrintInfo()
    {
        Console.WriteLine($"{MenuNumber}, {Name}[{MenuGroup}]  가격:  {Cost}원");
        Console.WriteLine("을 선택하셨습니다.");
    }
    
}

public class ChocoLatte : Beverage
{
    private int _menunumber = 5;
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
    public int MenuNumber
    {
        get { return _menunumber; }
    }
    void PrintInfo()
    {
        Console.WriteLine($"{MenuNumber}, {Name}[{MenuGroup}]  가격:  {Cost}원");
        Console.WriteLine("을 선택하셨습니다.");
    }
}