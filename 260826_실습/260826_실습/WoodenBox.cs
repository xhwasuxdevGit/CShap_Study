public class WoodenBox : IDamageable
{
    private int hp = 10;

    public void TakeDamage(int damage)
    {
        hp = hp - damage;

        if (hp < 0)
        {
            hp = 0;
        }
        
        Console.WriteLine("나무 상자 내구도 " + hp);
    }

    public bool IsDestroyed()
    {
        return hp <= 0;
    }
}