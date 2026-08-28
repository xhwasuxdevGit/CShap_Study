public enum MenuGroup
{
    None,
    Beverage,
    Bakery
}

public abstract class MenuItem
{
    
    public static int totalItemCount = 0;
    
    public MenuItem()
    {
        totalItemCount++;
     }
}



public abstract class Beverage : MenuItem
{
    private MenuGroup _menuGroup;
    /*
    public static int beverageCount = 0;
    public Beverage()
    {
        beverageCount++;
    }
    public int WaffleComboCount
    {
        get { return beverageCount; }
    }
    */
    public Beverage()
    {
        _menuGroup = MenuGroup.Beverage;
    }

    public MenuGroup GroupName
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
        _menuGroup = MenuGroup.Bakery;
    }

    public MenuGroup GroupName
    {
        get { return _menuGroup; }
    }
}


