using System;

class Progran
{
    static void Main(string[] args)
    {
        // 체력: 100
        //공격: 10
        
        Player player = new();
        
        player.AddItem(new Potion());
        player.AddItem(new Potion());
        player.AddItem(new Sword());
        player.AddItem(new Potion());
        player.AddItem(new Potion());
        
        // 포션 / 포션 / 검 / 포션 / " "
        player.UseItem(4);
        
        player.PrintInfo("[4]포션 사용");

        // 포션 / 검 / 포션 / " " / " " / " "
        player.UseItem(2);
        player.PrintInfo("[2]검 사용");
        
        // 포션 / 포션 / " " / " " / " "
        player.UseItem(2);
        player.PrintInfo("[2]포션 사용");
    }



}


