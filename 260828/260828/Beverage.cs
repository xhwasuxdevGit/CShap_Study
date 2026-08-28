// 세부 음료 클래스

public class Americano : Beverage
{
    private string _name = "아메리카노";

    public string Name
    {
        get { return _name; }
    }
    
    public Americano(int itemCost = 2000) : base(itemCost)
    {
        _cost = itemCost;
    }
    
    public int Cost
    {
        get { return _cost; }
    }
}

public class Cafflatte : Beverage
{
    private string _name = "카페라떼";

    public string Name
    {
        get { return _name; }
    }
    
    public Cafflatte(int itemCost = 3000) : base(itemCost)
    {
        _cost = itemCost;
    }
    
    public int Cost
    {
        get { return _cost; }
    }
}