using System;
public enum Category
{
    None,
    음료,
    베이커리
        
}

public abstract class MenuItem
{
    protected int number = 0;
    protected string name = "없음";
    protected static int cost = 0;

   

}

public abstract class Beverage : MenuItem
{
    protected static Category category =  Category.음료;
  
}

public abstract class Bakery : MenuItem
{
    protected static Category category =  Category.베이커리;

}


