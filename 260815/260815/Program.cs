using System;

public class Progam
{
    public static void Main()
    {
   

        // 일단 삼각형 출력은 성공!
        /*
        Console.Write("숫자를 입력하시면 같은 크기의 역피라미드를 만들어요 ");
        string input = Console.ReadLine();  // 입력 받기
        int starNum = int.Parse(input);
        int lineNum = starNum + 1;
        
            
            for (int lineCount = 0; lineCount < lineNum ; lineCount++)
            {
                
                for (int starCount = 0; starCount < starNum; starCount++)
                {
                    
                    Console.Write('*');
               
                }
                Console.WriteLine("");
                starNum--;
            }
            */

        string[,] matrix = new string[7, 4];
        
        for (int i = 0; i < 4; ++i)
        {
            for (int j = 0; j < 7; j++)
            {
                matrix[j, i] = "*";
            }
            
        }
        
        for (int i2 = 1; i2 < 4: ++i2)
        {
            for (int j2 = 0; j2 < 7)
            {
            
            }
        }
     
        
        Console.WriteLine($"{matrix[1,1]}");
        
        /*
       
        for (int i = 0; i < 4; ++i)
        {
            for (int j = 0; j < 7; j++)
            {
                Console.Write($"{matrix[i, j]}");
            }
            Console.WriteLine("");
            
        }
        */
        




    }
}