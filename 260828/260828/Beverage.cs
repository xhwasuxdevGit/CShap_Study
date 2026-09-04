public class Americano : Beverage
{
    private static int count;
    static Americano()
    {
        number = 1;
        name = "아메리카노";
        cost = 2000;
        count++;
        // 2+1 구현
        if (count % 2 == 0)
        {
            cost = cost - (2000 * ((count / 2) -1));
        }
    }
    
    public string Name
    {
        get { return name; }
    }

    public int Cost
    {
        get { return cost; }
    }
    
    public static void PrintMenu()
    {
        Console.WriteLine($"[{category}] {number}. {name}  가격: {cost}원 ");
    }
    
}

public class CafeLatte : Beverage
{
    static CafeLatte()
    {
        number = 2;
        name = "카페라떼";
        cost = 3000;
    }
    
    public string Name
    {
        get { return name; }
    }

    public int Cost
    {
        get { return cost; }
    }
    
    public static void PrintMenu()
    {
        Console.WriteLine($"[{category}] {number}. {name}  가격: {cost}원 ");
    }
    
}

public class IceTea : Beverage
{
    static IceTea()
    {
        number = 3;
        name = "아이스티";
        cost = 3000;
    }
    public string Name
    {
        get { return name; }
    }

    public int Cost
    {
        get { return cost; }
    }
    public static void PrintMenu()
    {
        Console.WriteLine($"[{category}] {number}. {name}  가격: {cost}원 ");
    }
    
}

public class GreenTea : Beverage
{
    static GreenTea()
    {
        number = 4;
        name = "녹차";
        cost = 2500;
    }
    public string Name
    {
        get { return name; }
    }

    public int Cost
    {
        get { return cost; }
    }
    
    public static void PrintMenu()
    {
        Console.WriteLine($"[{category}] {number}. {name}  가격: {cost}원 ");
    }
    
}

public class ChocoLatte : Beverage
{
    static ChocoLatte()
    {
        number = 5;
        name = "쵸코라떼";
        cost = 3500;
    }
    
    public string Name
    {
        get { return name; }
    }

    public int Cost
    {
        get { return cost; }
    }
    public static void PrintMenu()
    {
        Console.WriteLine($"[{category}] {number}. {name}  가격: {cost}원 ");
    }
    
}