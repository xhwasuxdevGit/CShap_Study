using System;

public class Progrgam
{
    public static void Main()
    {
         PlayerStat a =new PlayerStat("김", 13, 0, false);
        a.PrintInfo();
    }
   

    public struct PlayerStat
    {
        public string Name;
        public int Level;
        public int WinCount;
        public bool IsSkipTutorial;
        
        //생성자
        public PlayerStat(string name, int level, int winCount, bool isSkipTutorial)
        {
            Name = name;
            Level = level;
            WinCount = winCount;
            IsSkipTutorial = isSkipTutorial;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"WinCount: {WinCount}");
            Console.WriteLine($"IsSkipTutorial: {IsSkipTutorial}");
        }

    }
}