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
    
    public MenuItem()
    {
        totalItemCount++;
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




