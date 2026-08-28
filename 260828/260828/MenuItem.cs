// 세부 메뉴 생성을 위한 추상 클래스 생성

public abstract class MenuItem
{
    protected int _cost;
    
   
    public static int totalItemCount = 0;

    public MenuItem(int itemCost)
    {
        _cost = itemCost;
    }
    
    public int Cost
    {
        get { return _cost; }
    }
}
// 음료 대분류 추가
public abstract class Beverage : MenuItem
{
    public static int totalBeverageCount = 0;
    
    public Beverage(int itemCost) : base(itemCost)
    {
        _cost = itemCost;
    }
    
    public int Cost
    {
        get { return _cost; }
    }
    
}
// 베이커리 대분류 추가
public abstract class Bakery : MenuItem
{
    public static int totalBeverageCount = 0;
    
    public Bakery(int itemCost) : base(itemCost)
    {
        _cost = itemCost;
    }
    
    public int Cost
    {
        get { return _cost; }
    }
    
}

