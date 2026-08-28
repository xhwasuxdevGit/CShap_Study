public class Cookie : Bakery
{
    private string _name = "쿠키";
    private int _cost = 1000;
    public static int totalCookieCount = 0;

    public string Name
    {
        get { return _name; }
    }

    
    
    public int Cost
    {
        get { return _cost; }
    }

    public int CookieCost
    {
        get { return _cost; }
    }
   

    public Cookie()
    {
        totalCookieCount++;
    }

    public int CookieCount
    {
        get { return totalCookieCount; }
    }
    
    


}

public class SaltBread : Bakery
{
    private string _name = "소금빵";
    private int _cost = 2000;
 

}

public class Waffle : Bakery
{
    private string _name = "와플";
    private int _cost = 1500;
 

}