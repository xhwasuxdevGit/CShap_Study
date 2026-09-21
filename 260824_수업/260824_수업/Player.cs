using System;

public class Player
{
    private Item[] _inventory = new Item[5];
    private int _inventoryCount;
    
    private int _health;
    private int _attack;

    public Player()
    {
        _health = 100;
        _attack = 10;
        _inventoryCount = 0;

    }

    public void PrintInfo(string state)
    {
        Console.WriteLine($"{state}----------");
        Console.WriteLine($"체력: {_health}");
        Console.WriteLine($"공격력: {_attack}");
    }

    public void Heal(int amount)
    {
        _health += amount;
    }

    public void PowerUp(int value)
    {
        _attack += value;
        
    }
    
    
    
    //아이템 추가
    public void AddItem(Item item)
    {
        if (_inventoryCount == _inventory.Length)
        {
            return;
        }
        _inventory[_inventoryCount] = item;
        _inventoryCount++;
    }
    
    // 사용
    public void UseItem(int index)
    {
        // 1. 아이템이 아무것도 없는데 사용하려는 경우 _inventoryCOunt == 0
        // 2. 빈 자리의 아이템을 사용하려고 할 경우
        //

        if (_inventoryCount == 0 || index < 0 || _inventoryCount <= index)
        {
            return;
        }
        
        if (index == _inventoryCount - 1) // 인덱스는 맨 끝의 아이템을 가리킴
        {
            // 맨 마지막 아이템 사용
            _inventory[index].Use(this);
            
            // 해당 칸 비워주고
            _inventory[index] = null;
            
        }
        else
        {
            // 해당 아이템 사용
            _inventory[index].Use(this);
            // 빈자리로 바꿈
            _inventory[index] = null;

            for (int i = index; i < _inventoryCount; i++)
            {
                if (index == _inventoryCount -1)
                {
                    _inventory[i] = null;
                    
                }
                else
                {
                    _inventory[i] = _inventory[i + 1];
                }
            }
            
        }
        
        _inventoryCount--;
    }

}