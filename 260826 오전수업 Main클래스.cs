 Guardian g = new();
        Slime s = new();
        
        Monster[] monsters = new Monster[]
        {
            g, 
            s
        };
        
        Guardian guardian1 = new Guardian();
        
        foreach (Monster monster in monsters)
        {
            if (monster is IDamageable)
            {
                IDamageable damagable = monster as IDamageable;
                damagable.TakeDamage(10);
                
            }
        
        }

        Console.WriteLine(g.Health);
        Console.WriteLine(s.Health);

