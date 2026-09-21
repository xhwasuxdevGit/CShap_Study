using System;

public class Program
{
    public static void Main(string[] args)
    {
        int arrSize = 3;
        
        // 배열의 선언: DataType[] Name;
        // int[] numbers = { 1, 5, 7, 3, 9 };
        //int[] numbers = new int[arrSize / 2];


        //  배열의 범위를 벗어난 인덱스 접근 = 에러
        // Console.WriteLine(numbers[5]);
        // Console.WriteLine(numbers[-1]);
        
        // 배열의 길이 알아보기
        // Console.WriteLine(numbers.Length);
        
        // 2차원 배열
        // int[,] matrix = new int[arrSize, arrSize];
        int[,] matrix =
        {
            { 1,2,3,4,5,6,7,8,9, 10},
            {11, 12, 13, 14, 15, 16, 17, 18, 19, 20 },
            {21, 22, 23, 24, 25, 26, 27, 28, 29, 30 },
            {31, 32, 33, 34, 35, 36, 37, 38, 39, 40 },
            {41, 42, 43, 44, 45, 46, 47, 48, 49, 50 }
        };
        
        // Console.WriteLine(matrix[3,7]);
        
        // 3차원 배열
        int[,,] wtf =
        {
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            },
            {
                { 7, 8, 9 },
                { 10, 11, 12 }
            }
        };
      
        /* 유저 입력을 받아서 처리하기
        string userInput = Console.ReadLine();
        string[] inputs = userInput.Split(' ');

        int[] numbers = new int[3];
        numbers[0] = int.Parse(inputs[0]);
        numbers[1] = int.Parse(inputs[1]);
        numbers[2] = int.Parse(inputs[2]);

        int result = numbers[0] + numbers[1] + numbers[2];


        Console.WriteLine(result);
        */
        
        /* 유저의 잘못된 입력 방지하기
        string userInput = Console.ReadLine();

        int number;
        bool isSuccess = int.TryParse(userInput, out number);

        if (isSuccess)
        {
            Console.WriteLine($"변환 완료");
        }
        else
        {
            Console.WriteLine("엉뚱한 값이 입력됨");
        }
        */
        
        // 1.while

        /*
        int count = 0;
        
        while (count <= 100)
        {
            count++;
            
            // count가 짝수일때 만 만복
            if (count % 2 == 0)
            {
                Console.WriteLine($"현재 숫자: {count}");
            }
            // continue: 구문 아래의 로직을 스킵하고 다음 루프로 이동

            if (count == 48)
            {
                break;
            }
            
        }
        */
        
        // 2. for
        // for(초기식; 조건식; 증감식)
        // 동작순서: 초기식 > 조건식 > 증감식 > 조건식 > 증감식...
       
        /*
        for (int i = 0; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"현재 숫자 : {i}");
            }
        }
        */

        /*
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write('□');
            }
            Console.WriteLine();
        }
        */

        // 줄만큼 별표갯수 출력하기
        Console.WriteLine("짜릿해 ^^");
        for (int i = 0; i < 3 ; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write('*');    
            }
            Console.WriteLine();
        }
        
        
        // 배열을 반복문으로 순회하기
        
        
        /*
        // 대문자라면 소문자로 바꾸기
        
        string text = "aAbsdxzxcseqwSSSeFGGHFGddde";
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] < 97)
            {
                Console.Write((char)(text[i] + 32));
            }
            // 소문자라면 바로 한 글자 출력
            else
            {
                Console.Write(text[i]);
            }
        }
        */
    

    }
}