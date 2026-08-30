using System;

public class Cookie : Bakery
{
    static Cookie()
    {
        number = 6;
        name = "쿠키";
        cost = 1000;
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
    
    public static void PrintMenu()
    {
        Console.WriteLine($"[{category}] {number}. {name}  가격: {cost}원 ");
    }
    
}