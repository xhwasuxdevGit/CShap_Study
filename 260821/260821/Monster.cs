namespace _260821;

public class Monster
{

    public string Name { get; private set; }
    public int AttackValue { get; private set; }
    public int Health { get; private set; }
    public Monster(string name, int health, int attackValue)
    {
        Name = name;
        Health = health;
        AttackValue = attackValue;
    }

    public void Attack(Player player)
    {
        player.TakeDamage(AttackValue);
    }

    public void TakeDamage(int dagame)
    {
        Health -= dagame;
        Console.WriteLine(($"{Name} : 대미지 입었다. 현재 체력{Health}"));
    }
    /*
    public static int Count = 0;
    private static int _monsterKillCount;
    
    public string Name; // 적지 않는다면 private 
    public int Health;

    static Monster()
    {
        Console.WriteLine(("static 생성자"));
        
    }

    public Monster()
    {
        Console.WriteLine("일반 생성자");
    }

    public void PrintInfo()
    {
        Console.WriteLine(Count);
    }
    

    public void spawn()
    {
        Count++;
    }

    public void Dispawn()
    {
        Count++;
    }

    public static void PrintMonsterKillCount()
    {
        Console.WriteLine(_monsterKillCount);
    }

    public static void AddMonsterKillCount()
    {
        _monsterKillCount++;
    }
    */









    /*
   //private float _moveSpeed;
   public float MoveSpeed { get; private set; } // 자동구현 프로퍼티

   private int _level;

   public int Level
   {
       get
       {
           return _level;
       }
       private set
       {
           _level = value;
       }
   }
   */
    
    /*
    public float GetMoveSpeed()
    {
        return _moveSpeed;
    }

    public void SetMoveSpeed(float moveSpeed)
    {
        Console.WriteLine();
        _moveSpeed = moveSpeed;
    }
    */














    /*
    public Monster(string name, int health)
    {
        Console.WriteLine("Hello, Monster! / SetValue");
        Name = name;
        Health = health;
    }

    public Monster()
    {
        Console.WriteLine("Hello, Monster!");

    }


    public void PrintInfo()
    {
        Console.WriteLine($"{Name} 체력 : {Health}");
    }
    */

}