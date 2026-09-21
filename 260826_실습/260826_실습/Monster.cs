public abstract class Monster : IDamageable
{
    protected string name;
    protected int hp;

    public Monster(string monsterName, int monsterHp)
    {
        name = monsterName;
        hp = monsterHp;
    }

    public abstract void Attack();

    public void TakeDamage(int damage)
    {
        hp = hp - damage;

        if (hp < 0)
        {
            hp = 0;
        }
        
        Console.WriteLine(name + " 남은 체력 " + hp);
    }

    public bool IsDestroyed()
    {
        return hp <= 0;
    }
}