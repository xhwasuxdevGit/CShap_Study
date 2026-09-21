using System;
public class Potion : Item
{
    public Potion() : base(1, "포션")
    {
        
    }

    
    
    public override void Use(Player owner)
    {
        owner.Heal(20);
    }


}
