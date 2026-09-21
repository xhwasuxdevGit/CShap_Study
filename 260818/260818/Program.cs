using System;

public class Program
{
    public static void Main()
    {
        /*
        // 1.while
        while (true)
        {
            // break : 반복문 끝내기
            break;

            // continue : 이후의 로직을 무시하고 다음 루프 진행
            continue;
        }

        // 2.for
        for (int i=0; i <= 10; i++) // for (초기식; 조건식; 증감식)
        {
            // break;
            // continue;
        }

        // 3. do-while

        while (false)
        {
            // 아예 실핼됭지 안음
            // 조건식 -> 로직 순서로 진행
        }

        do
        {
            // 최초 1회 수행
            // 로직 수행 -> 조건식 검사 순서로 진행
        } while (false);

        // foreach

        int[] arr = { 1, 2, 56, 26, 21, 98 };

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = 0;
            Console.WriteLine(arr[i]);
        }

        foreach (int i in arr)
        {
            // 1) 첫번쨰 실행: i = arr[0]
            // 2) 두번쨰 실행: i = arr[1]
            // 3) 세번째 실행: i = arr[2]
            // ...
            // i = 0; 에러: 데이터를 바꿀 수 없다
            Console.WriteLine(i);
        }
        */

        Random rand = new Random();

        // 랜덤 수 생성: rand.Next(최소값, 최대값);
        // ex) int randNum = rand.Next(-50, 50);

        // 1. 크기가 10인 배열 생성
        int[] arr = new int[10];

        // 2. 배열 내부를 전부 랜덤 숫자로 채우기
        /*
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(1, 100);
            Console.Write(arr[i]);

        }
        */

        /*
        // 3. 배열 내부의 '최대값'과 몇번 인덱스에 위치해있는지 출력(for 사용)
        // ex) 최대값: n / index: n


        // 배열에 랜덤 숫자 채우기
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(1, 100);
            Console.Write($"{arr[i]} / ");
        }
        // 값 & 인덱스 비교를 위한 기준점 설정하기

        int maxValue = arr[0];
        int maxIndex = 0;

        // 다음값과 비교하는 연산
        for (int j = 1; j < arr.Length; j++)
        {
               //
               if (maxValue < arr[j])
               {
                   maxValue = arr[j];
                   maxIndex = j;
               }

        }

        Console.WriteLine("");
        Console.WriteLine($"최대값 : {maxValue} / index : {maxIndex}");


        // 4. 배열 내부의 '최소값'이 몇인지 출력하기(foreach 사용)


        int minvalue = int.MaxValue;

        foreach (int n in arr)
        {
            if (minvalue > n)
            {
                minvalue = n;
            }
        }

        Console.WriteLine(($"최소값 : {minvalue}"));
         */



        // 7의 갯수
        int[] array = { 1, 7, 20, 27, 77 };
        int counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            string intTochar = (string)array[i];
            char[] charToStr = intTochar.ToCharArray();


            for (int j = 0; j < charToStr.Length; j++)
            {
                
            }
            {
                counter++;
            }
        }
        int answer = counter;
        Console.WriteLine(answer);


    }
}