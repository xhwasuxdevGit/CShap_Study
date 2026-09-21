using System;
using System.Net.Mail;

class Program
{
    static void Main(string[] args)
    {


        // 함수: '기능'에 별명을 지어준다
        string text = "1124";
        int num;
        int.TryParse(text, out num);


        int a = 5;
        int b = 8;

        Swap(ref a, ref b);

        Console.WriteLine($"a = {a} / b = {b}");


        int a = 10;
        int b = 20;
        int c = 30;

        Console.WriteLine(Sum(a,b));
        Console.WriteLine(Sum(a,b,c));

        Foo(3);
        
    }
    
    
    static void Swap(int first, int second)
    {
        Console.WriteLine("Int Swap");
        int temp = first;
        first = second;
        second = temp;
        
        Console.WriteLine($"(Swap) = {first} / b = {second}");
    }
    
    static void Swap(float first,float second)
    {
        Console.WriteLine("Float Swap");
        float temp = first;
        first = second;
        second = temp;
        
        Console.WriteLine($"(Swap) = {first} / b = {second}");
    }

    
    // 함수 선언
    // 문법형식: [반환형] [이름]() { }
    static int GerRandomNumber()
    {
        Random rand = new Random();
        int a = rand.Next(1, 100);
        return a;
    }
    
    
    // 오버로딩 안됨
    
    static float GerRandomNumber()
    {
        return 3.14f;
    }
    
   
    
    // 반환형이 없는 함수
    static void PrintTitle()
    {
        Console.WriteLine("=================");
        Console.WriteLine("  파이널 판타지  ");
        Console.WriteLine("=================");
    }
    
    // 매개변수가 있는 함수
    static int Sum(int a, int b)
    {
        int sum = a + b;
        return sum;
    }

    static int Sum(int a, int b, int c)
    {
        int sum = a + b + c;
        return sum;
    }

    static void Foo(int count)
    {
        Console.WriteLine($"Foo 호출 count: {count}");
        
        // 기저조건 설정
        if (count == 0)
        {
            Console.WriteLine("재귀 끝");
            return;
        }
        
        Foo(count:count - 1);
        Console.WriteLine($"Foo 종료 count: {count}");
    }
    
    
}


