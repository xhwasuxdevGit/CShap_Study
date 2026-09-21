using System;

class Progran
{
    static void Main(string[] args)
    {
   
        Item potion = new Potion("포션", "체력회복");

       // 업 캐스팅------------
        Item sword = new Sword("검", "낡은 검");

        // Sword sword = new Sword("검", "낡은 검");
        // Item swordItem = (Item)sword;

        potion.Use();
        potion.Drop();

        //potion.UseTo(); [Item]형인 경우, [Potion}이 가진 UseTo()를 알지 못함


        Sword s;
        // 다운 캐스팅----------------------
        if (sword is Sword)       // 변환이 가능 하다면
        {                         // 'is'는 참/거짓으로 반환
            s = (Sword)sword;
            s.Upgrade();
        }

        // 반환이 가능하다면 변환 객체를, 아니라면 null
        (sword as Sword).Upgrade();
        

    }
}

public class Sword : Item
{
    public Sword(string name, string description) : base(name, description)
    {
        
    }

    public void Upgrade()
    {
        Console.WriteLine("검 강화");
    }

    public override void Use()
    {
        Console.WriteLine("검 장착함");
    }
}

public class Potion : Item
{
    public string Name;
    public Potion(string name, string description) : base(name, description)
    {
        this.Name = name;
        base.Name = name;
    }

    public void UseTo()
    {
        Console.WriteLine("다른 대상에게 포션 사용");
    }

    public override void Use()
    {
        Console.WriteLine("포션 섭취함");
    }

}

public class Item
{
    // 접근제한자 protected: 이클래스를 상속받은 클래스에서 사용 가능
    public string Name { get; protected set; }
    public string Description { get; private set; }

    public Item(String name, string description)
    {
        Name = name;
        Description = description;
        
    }

    public virtual void Use()
    {
        Console.WriteLine($"{Name}을 사용했습니다.");
    }

    public void Drop()
    {
        Console.WriteLine($"{Name}을 버렸습니다.");
    }

}

