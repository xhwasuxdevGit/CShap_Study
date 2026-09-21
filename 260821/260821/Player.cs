namespace _260821;

public class Player
{
    public string Name { get; private set; }
    public int AttackValue { get; private set; }
    public int Health { get; private set; }

    public Player(string name, int health, int attackValue)
    {
        Name = name;
        Health = health;
        AttackValue = attackValue;
    }

    public void Attack(Monster monster)
    {
        monster.TakeDamage(AttackValue);
    }

    public void TakeDamage(int dagame)
    {
        Health -= dagame;
        Console.WriteLine(($"{Name} : 대미지 입었다. 현재 체력{Health}"));
    }

    public void Skill(Monster[] monsters)
    {
        foreach (Monster mon in monsters)
        {
            Attack(mon);
        }
    }
}