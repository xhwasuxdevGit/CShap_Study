public class Americano : MenuItem
{
    private static int count= 0;
    public Americano()
    {
        number = 1;
        name = "아메리카노";
        cost = 2000;
        category = Category.음료;
    }
    
    public string Name
    {
        get { return name; }
    }

    public int Cost
    {
        get { return cost; }
    }

    public override void PrintMenu()
    {
        Console.WriteLine($"[{category}] {number}. {name}  가격: {cost}원 (3잔 이상 구매시 개당 1500원)");
    }
    
    public override int CalculatePrice(int quantity)
    {
        int totalPrice = 0;
        int discountCost = 1500;

        if (quantity > 2)
        {
            totalPrice = quantity * discountCost; 
        }
        else
        {
            totalPrice = quantity * cost; 
        }
       
        return totalPrice;
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

    public string Name
    {
        get { return name; }
    }

    public int Cost
    {
        get { return cost; }
    }
    
    public override int CalculatePrice(int quantity)
    {
        int totalPrice = 0;
        totalPrice = quantity * cost; 
        return totalPrice;
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

    public string Name
    {
        get { return name; }
    }

    public int Cost
    {
        get { return cost; }
    }
    
    public override int CalculatePrice(int quantity)
    {
        int totalPrice = 0;
        totalPrice = quantity * cost; 
        return totalPrice;
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

    public string Name
    {
        get { return name; }
    }

    public int Cost
    {
        get { return cost; }
    }
    
    public override int CalculatePrice(int quantity)
    {
        int totalPrice = 0;
        totalPrice = quantity * cost; 
        return totalPrice;
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
        
        
    }

    public string Name
    {
        get { return name; }
    }

    public int Cost
    {
        get { return cost; }
    }
    
    public override int CalculatePrice(int quantity)
    {
        int totalPrice = 0;
        totalPrice = quantity * cost; 
        return totalPrice;
    }

}