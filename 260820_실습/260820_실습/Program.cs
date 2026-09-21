using System;

public struct PartyMember
{
    public string Name;
    public int Hp;
    public int Level;

    public PartyMember(string name, int hp, int level)
    {
        Name = name;
        Hp = hp;
        Level = level;
    }

    public PartyMember(string name)
    {
        Name = name;
        Hp = 100;
        Level = 1;
    }
}

public class Program
{
    public static void Main()
    {
        PartyMember[] party =
        {
            new PartyMember("전사", 120, 30),
            new PartyMember("궁수", 95, 20),
            new PartyMember("신입")
        };

        foreach (PartyMember member in party)
        {
            Console.WriteLine($"{member.Name} LV.{member.Level} HP {member.Hp}");
        }

        PartyMember empty = new PartyMember();
        Console.WriteLine($"이름 없음 - HP {empty.Hp}, Lv.{empty.Level}");

    }

    
}