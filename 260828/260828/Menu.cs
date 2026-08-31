using System;
public enum Category
{
    None,
    음료,
    베이커리
        
}

public abstract class MenuItem
{
    protected static int number = 0;
    protected static string name = "없음";
    protected static int cost = 0;

    public string Name
    {
        get { return name; }
    }

    public int Cost
    {
        get { return cost; }
    }
}

public abstract class Beverage : MenuItem
{
    protected static Category category =  Category.음료;
    public string Name
    {
        get { return name; }
    }

    public int Cost
    {
        get { return cost; }
    }
}

public abstract class Bakery : MenuItem
{
    protected static Category category =  Category.베이커리;
    public string Name
    {
        get { return name; }
    }

    public int Cost
    {
        get { return cost; }
    }

    public Category MenuType
    {
       get { return category; }
    }
}


