using System;
public interface IDamageable
{
   void TakeDamage(int damage);
   bool IsDestroyed();
}

public interface IMovable
{
   void Move(int distance);
}
