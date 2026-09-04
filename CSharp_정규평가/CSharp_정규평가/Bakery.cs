using System;

public class Cookie : MenuItem
{
    private static int count = 0;
    //5개이상 구매시 반값
    public Cookie()
    {
        number = 6;
        name = "쿠키";
        cost = 1000;
        category = Category.베이커리;
        count++;
        if (count > 4)
        {
            cost = (cost / 2);
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
        Console.WriteLine($"[{category}] {number}. {name}  가격: {cost}원 (5개 이상 구매시 50%)");
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