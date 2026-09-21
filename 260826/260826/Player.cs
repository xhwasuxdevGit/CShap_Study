using System;

public class Player
{
    public ObservableProperty<int> Health = new();
    public ObservableProperty<float> Exp = new();

    public Player()
    {
        Health.Value = 100;
        Exp.Value = 9f;
    }

    public void TakeDamage(int damage)
    {
        Health.Value -= damage;
    }

    public void AddExp()
    {
        Exp.Value += 10;
    }
}
