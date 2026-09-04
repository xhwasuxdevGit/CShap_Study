public class Americano : MenuItem
{
    private static int count= 0;
    public Americano()
    {
        number = 1;
        name = "아메리카노";
        cost = 2000;
        category = Category.음료;
        count++;

        if (count > 2)
        {
            cost = 1500;
        }
    
        
    }
    
    public int Number
    {
        get { return number; }
    }

    public string Name
    {
        get { return name; }
    }

    public int Cost
    {
        get { return cost; }
    }
    
    public Category _Category
    {
        get { return category; }
    }

    public override void PrintMenu()
    {
        Console.WriteLine($"[{category}] {number}. {name}  가격: {cost}원 (3잔 이상 구매시 개당 1500원)");
    }
}

public class CafeLatte : MenuItem
{
   public CafeLatte() : base()
    {
        number = 2;
        name = "카페라떼";
        cost = 3000;
       category = Category.음료;
    
    }
    public int Number
    {
        get { return number; }
    }

    public string Name
    {
        get { return name; }
    }

    public int Cost
    {
        get { return cost; }
    }

    public Category _Category
    {
        get { return category; }
    }

}

public class IceTea : MenuItem
{

    public IceTea()
    {
        number = 3;
        name = "아이스티";
        cost = 3000;
        category = Category.음료;
       
    }
    public int Number
    {
        get { return number; }
    }

    public string Name
    {
        get { return name; }
    }

    public int Cost
    {
        get { return cost; }
    }

    public Category _Category
    {
        get { return category; }
    }
    
    
}

public class GreenTea : MenuItem
{
    private static int count= 0;
    
    public GreenTea()
    {
        number = 4;
        name = "녹차";
        cost = 2500;
        category = Category.음료;
        }
    public int Number
    {
        get { return number; }
    }

    public string Name
    {
        get { return name; }
    }

    public int Cost
    {
        get { return cost; }
    }

    public Category _Category
    {
        get { return category; }
    }

}

public class ChocoLatte : MenuItem
{
    private static int count= 0;
    
    public ChocoLatte()
    {
        number = 5;
        name = "쵸코라떼";
        cost = 3500;
        category = Category.음료;
        count++;
        totalCost  = count * cost;
    }
    public int Number
    {
        get { return number; }
    }

    public string Name
    {
        get { return name; }
    }

    public int Cost
    {
        get { return cost; }
    }
    
   
    public Category _Category
    {
        get { return category; }
    }
    
}