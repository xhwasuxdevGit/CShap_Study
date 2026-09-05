using System;

public class Cookie : MenuItem
{
    //5개이상 구매시 반값
    public Cookie()
    {
        number = 6;
        name = "쿠키";
        cost = 1000;
        category = Category.베이커리;
    
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
        Console.WriteLine($"[{category}] {number}. {name}  가격: {cost}원 (5개 이상 구매시 50%)");
    }

    public override int CalculatePrice(int quantity)
    {
        int totalPrice = 0;
        int discountedPrice = (cost / 2);
        
        if (quantity > 4)
        {
            totalPrice = quantity * discountedPrice;
            return totalPrice;
        }

        else
        {
            totalPrice = quantity * cost;
        }
        return totalPrice;
    }
 
 
}

public class SaltBread : MenuItem
{
 
    public SaltBread()
    {
        number = 7;
        name = "소금빵";
        cost = 2000;
        category = Category.베이커리;
      
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

public class Waffle : MenuItem
{
    public Waffle() : base()
    {
        number = 8;
        name = "와플";
        cost = 1500;
        category = Category.베이커리;
      
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