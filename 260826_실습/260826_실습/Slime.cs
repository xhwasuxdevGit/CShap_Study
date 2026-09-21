
public class Slime : Monster, IMovable
{
    private int position = 0;

    public Slime(string monsterName, int monsterHp) : base(monsterName, monsterHp)
    {
        
    }

    public override void Attack()
    {
        Console.WriteLine(name + "이(가) 몸을 부딪칩니다.");
    }

    public void Move(int distance)
    {
        position = position + distance;
        Console.WriteLine(name + " 위치 " + position);
    }
    
}