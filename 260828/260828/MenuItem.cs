using System.Diagnostics;

public enum MenuGroup
{
    None,
    음료,
    베이커리
}

public abstract class MenuItem
{
    private int _cost;
    private string _name;
    MenuGroup _menuGroup;
    private int _menunumber = 0;
    public static int totalItemCount = 0;

    public int Cost
    {
        get { return _cost; }
    }

    public string Name
    {
        get { return _name; }
        
    }

    public MenuGroup MenuGroup
    {
        get { return _menuGroup; }
        
    }
    public int MenuNumber
    {
        get { return _menunumber; }
    }
    public MenuItem()
    {
        totalItemCount++;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{MenuNumber}, {Name}[{MenuGroup}]  가격:  {Cost}원");
        Console.WriteLine("을 선택하셨습니다.");
    }
    
}



public abstract class Beverage : MenuItem
{
    private MenuGroup _menuGroup;
 
    public Beverage()
    {
        _menuGroup = MenuGroup.음료;
    }

    public MenuGroup MenuGroup
    {
        get { return _menuGroup; }
        
    }
    

}
// 베이커리 대분류 추가
public abstract class Bakery : MenuItem
{
    private MenuGroup _menuGroup;
    public Bakery()
    {
        _menuGroup = MenuGroup.베이커리;
    }

    public MenuGroup MenuGroup
    {
        get { return _menuGroup; }
        
    }
}




