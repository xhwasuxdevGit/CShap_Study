using System;

public class Sword : Item
{
    public Sword() : base(2, "검")
    {
        
    }

    
    
    public override void Use(Player owner)
    {
        owner.PowerUp(5);
    }


}