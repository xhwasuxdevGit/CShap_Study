// 세부 메뉴 생성을 위한 추상 클래스 생성

public abstract class MenuItem
{
    public static int totalItemCount = 0;
    
    public MenuItem()
    {
        totalItemCount++;
    }
}


// 음료 대분류 추가
public abstract class Beverage : MenuItem
{
    public static int totalBeverageCount = 0;

    public Beverage()
    {
        totalBeverageCount++;
    }
    
}
// 베이커리 대분류 추가
public abstract class Bakery : MenuItem
{
 
}

public abstract class SetMenu : MenuItem
{
 
}