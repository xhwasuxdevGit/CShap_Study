using System;

public class Cookie : Bakery
{
    private static int count = 0;
    //5개이상 구매시 반값
    static Cookie()
    {
        number = 6;
        name = "쿠키";
        cost = 1000;
        count++;
        if (count > 4)
        {
            cost = cost / 2;
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

public class SaltBread : Bakery
{
    static SaltBread()
    {
        number = 7;
        name = "소금빵";
        cost = 2000;
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

public class Waffle : Bakery
{
    static Waffle()
    {
        number = 8;
        name = "와플";
        cost = 1500;
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