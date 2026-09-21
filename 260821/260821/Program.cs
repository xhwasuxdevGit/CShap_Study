using _260821;

class Program
{
    static void Main(string[] args)
    {
        Player player = new("유니티", 200, 10);

        Monster goblin = new("고블린", 50, 5);
        Monster slime = new("슬라임", 20, 3);

        Monster[] monsters = new Monster[3];
        monsters[0] = goblin;
        monsters[1] = slime;
        monsters[2] = new Monster("드래곤", 9999, 9999);

        while (true)
        {
            Console.WriteLine("행동을 선택하세요");
            Console.WriteLine(" 1 -> 첫번째 몬스터 공격");
            Console.WriteLine(" 2 -> 두번째 몬스터 공격");
            Console.WriteLine(" 3 -> 세번째 몬스터 공격");
            Console.WriteLine(" 4 -> 모든 몬스터 공격");
            
            string userInput = Console.ReadLine();
            int select = int.Parse(userInput);

            switch (select)
            {
                case 1:
                    player.Attack(monsters[0]);
                    break;
                case 2:
                    player.Attack(monsters[1]);
                    break;
                case 3:
                    player.Attack(monsters[2]);
                    break;
                case 4:
                    player.Skill(monsters);
                    break;
            }

            
        }



        /*
        Monster mon1 = new Monster();
        Monster mon2 = new Monster();
        Console.WriteLine(Monster.Count);
        */


        /*
        mon1.spawn();
        mon2.spawn();

        Console.WriteLine(Monster.Count);
        mon1.PrintInfo();
        mon2.PrintInfo();
        */


        /*
        Monster mon = new Monster();
        mon.MoveSpeed = 5f;
        Console.WriteLine(mon.MoveSpeed);

        mon.Level = 1;
        Console.WriteLine(mon.Level);
        */

        //Console.WriteLine(mon.GetMoveSpeed());



        /*
        Monster slime =  new Monster();
        // Monster slime = new();  축약 표기

        slime.Name = "슬라임";

        slime.PrintInfo();
        */

        /*
        // new Monster();      객체(인스터스)가 만들어지고 메모리에 할당은 됨

        Monster slime = new Monster();      // Monster를 구조체로 바꿔서 비교해보자

        slime.Name = "슬라임";
        slime.Health = 100;

        Monster goblin = slime;
        goblin.Name = "고블린";
        goblin.Health = 200;

        slime.PrintInfo();
        goblin.PrintInfo();
        */

    }
    
}

