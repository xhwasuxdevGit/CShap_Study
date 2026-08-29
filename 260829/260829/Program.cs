using System;

public class Program
{
    public static async Task Main()
    {
        Console.WriteLine("Main 시작");

        // bool isRunning = await Timer();
        Task<bool> isRunning = Timer();

        while (!isRunning.IsCompleted)
        {
            Console.Write('.');
        }
        
        Console.WriteLine("Main 종료 프로그램 끝");
    }

    public static  async Task<bool> Timer()
    
    {
        Console.WriteLine("타이머 시작");
        
        // 여기서 3초를 대기하게 만들자
        //Thread.Sleep(3000);
        
        await Task.Delay(3000);
        
        Console.WriteLine("타이머 끝");
        return true;

    }
}