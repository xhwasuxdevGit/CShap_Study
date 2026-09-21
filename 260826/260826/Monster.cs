namespace _260826;

public abstract class Monster
{
    public int Health { get; protected set; } = 100;

}

public class NPC : IDamageable
{
    public int Health { get; set; } = 100;
    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"이러시면 곤란합니다");
    }
}

public class Slime : Monster, IDamageable
{
    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"슬라임 데미지 입음. Health : {Health}");
        
    }
}

public class Guardian : Monster
{
    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"가디언 데미지 입음 : Health : {Health}");
    }
}

public interface IDamageable
{
    public void TakeDamage(int damage);
}