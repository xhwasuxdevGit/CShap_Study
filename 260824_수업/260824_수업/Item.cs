using System;
public abstract class Item
{
    public int Id { get; private set; }
    public string Name { get; protected set; }

    public Item(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public abstract void Use(Player owner);


}
  