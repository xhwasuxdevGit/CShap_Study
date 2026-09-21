using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
      
      /*
        MonsterData goblinData = new MonsterData("Goblin", 100, 20f);;
        MonsterData slimeData = new MonsterData("Slime", 20, 10f);
        MonsterData dragonData = new MonsterData("Dragon", 1, 1f);

        // goblinData = new MonsterData("goblin", 100, 20f);
        
        goblinData.PrintInfo();
        slimeData.PrintInfo();
        */

      // UserData user1 = new UserData("유니티",  GenderType.Male);
      
      // Console.WriteLine((PokemonType)20);


      

    }
    /*
     static void PrintMonsterData(MonsterData monsterData)
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine($"이름 : {monsterData.Name}");
        Console.WriteLine($"체력 : {monsterData.Health}");
        Console.WriteLine($"공격력 : {monsterData.AttackValue}");
        Console.WriteLine("-----------------------------------");
    }
    */
}

/*
struct Quest
{
    public string name;
    public string Description;

    public int RewardGold;
    public Item RewardItem;
}

struct Item
{
    
}
*/

struct UserData
{
    public string Name;
    public GenderType Gender;  // 1: 여자, 2: 남자
    
    public UserData(string name, GenderType gender)
    {
        Name = name;
        Gender = gender;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"이름 : {Name} / 성별 : {Gender}");

        if (Gender == GenderType.Male)
        {
            Console.Write("남자");
        }
        else if (Gender == GenderType.Female)
        {
            Console.Write("여자");
        }
    }
    
    
}

enum GenderType
{
    Male, Female
}


struct MonsterData
{
    public string Name;
    public int Health;
    public float AttackValue;

    public MonsterData(string name, int health, float attackValue)
    {
        Name = name;
        Health = health;
        AttackValue = attackValue;
    }

    public void PrintInfo()
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine($"이름 : {Name}");
        Console.WriteLine($"체력 : {Health}");
        Console.WriteLine($"공격력 : {AttackValue}");
        Console.WriteLine("-----------------------------------");
    }
}



enum PokemonType
{
    Nomarl,
    Fier,
    Water,
    Grass,
    Electirc,
    Ice,
    Fighting,
    Poison,
    Ground,
    Flying,
    Psychic,
    Bug,
    Rock,
    Ghost,
    Dragon,
    Dark,
    Steel,
    Fairy
}


enum PlayerState
{
    Idle,
    Move,
    Attack,
    Dead
}
