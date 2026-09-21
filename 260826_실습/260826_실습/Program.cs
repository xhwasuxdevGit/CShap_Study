using System;

public class Program
{
    public static void Main()
    {
        Slime slime = new Slime("슬라임", 20);
        WoodenBox box = new WoodenBox();

        IDamageable[] targets = new IDamageable[2];
        targets[0] = slime;
        targets[1] = box;

        foreach (IDamageable target in targets)
        {
            target.TakeDamage(12);

            if (target.IsDestroyed())
            {
                Console.WriteLine("파괴되었습니다.");
            }
        }

        Console.WriteLine();
        slime.Move(5);
        slime.Attack();
        
     }
}