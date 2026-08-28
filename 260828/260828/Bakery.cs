public class Cookie : Bakery
{
    private string _name = "쿠키";

    public string Name
    {
        get { return _name; }
    }

    private int _cost = 1000;
    
    public int Cost
    {
        get { return _cost; }
    }


}

public class SaltBread : Bakery
{
    private string _name = "소금빵";
    private int _cost = 2000;
    public string Name
    {
        get { return _name; }
    }
    public int Cost
    {
        get { return _cost; }
    }

}

public class Waffle : Bakery
{
    private string _name = "와플";
    private int _cost = 1500;
    public string Name
    {
        get { return _name; }
    }
    public int Cost
    {
        get { return _cost; }
    }

}