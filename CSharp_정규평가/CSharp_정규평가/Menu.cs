public enum Category
{
    None,
    음료,
    베이커리
        
}

public abstract class MenuItem
{
    protected int number;
    protected string name;
    protected int cost;
    protected Category category;
    
    public MenuItem()
    {
        number = 0;
        name = "";
        cost = 0;
        category = Category.None;

    }

    public string Name
    {
        get { return name; }
    }

    public int Cost
    {
        get { return cost; }
    }
    
    public virtual void PrintMenu()
    {
        Console.WriteLine($"[{category}] {number}. {name}  가격: {cost}원 ");
    }
    
    public abstract int CalculatePrice(int quantity);

}

public class MenuSheet
{
    private List<MenuItem> menuSheet = new List<MenuItem>();
    
    public void PrintMenuSheet()
    {
        menuSheet.Add(new Americano());
        menuSheet.Add(new CafeLatte());
        menuSheet.Add(new IceTea());
        menuSheet.Add(new GreenTea());
        menuSheet.Add(new ChocoLatte());
        menuSheet.Add(new Cookie());
        menuSheet.Add(new SaltBread());
        menuSheet.Add(new Waffle());
        Console.Clear();
        for (int i = 0; i < menuSheet.Count; i++)
        {
            menuSheet[i].PrintMenu();
        }
        Console.WriteLine($"---------------------------------------------------------------------------");
        menuSheet.Clear();
    }
    
    
    
    
}