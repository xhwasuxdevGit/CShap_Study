using System;

public class Program  
{  
    public static void Main()
    {
       // 과제1. 상수 선언
        const string GAME_TITLE = "던전 러너";
        const int MAX_LEVEL = 99;
        const int MAX_HP = 100;
        const int MAX_INVENTORY_SLOT = 30;
        
        //과제2. 변수 선언
        string charName = "Unity";
        int currentLevel = 87;
        int currentHp = 65;
        char charGrade = 'A';
        bool isAlive = true;
        int usedSlot = 24;
        float moveSpeed = 6.25f;
        long totalScore = 12000000000L;
        
        // 과제3. 상태 변경
        int altHp = currentHp;
        char altGrade = charGrade;

        currentHp = 20;
        charGrade = 'C';
        
        // 과제1~3. 출력
        Console.WriteLine($"=== {GAME_TITLE} ===\n");
        Console.WriteLine($"이름 {charName}");
        Console.WriteLine($"레벨 {currentLevel} / {MAX_LEVEL} ");
        Console.WriteLine($"체력 {currentHp} / {MAX_HP}");
        Console.WriteLine($"등급 {charGrade}");
        Console.WriteLine($"생존 {isAlive}");
        Console.WriteLine($"가방 {usedSlot} / {MAX_INVENTORY_SLOT}");
        Console.WriteLine($"속도 {moveSpeed}");
        Console.WriteLine($"점수 {totalScore}");
        
        Console.WriteLine("\n--- 피격 전 기록 ---");
        Console.WriteLine($"이전 체력 {altHp}");
        Console.WriteLine($"이전 등급 {altGrade}");
        
        // 과제4. 형 변환
        {
            string a1 = "1250";
            int a2 = int.Parse(a1);
            
            float b1 = 87.6f;
            int b2 = (int)b1;
            int roundedB = Convert.ToInt32(b1);
            
            Console.WriteLine("\n--- 형 변환 확인 ---");
            
            Console.WriteLine($"문자열 정수 {a2}\n버림 {b2}\n반올림 {roundedB}");
            
        }
        
        // 선택과제1
        int c1 = 300;
        int c2 = (byte)c1;   // 결과값 "44"
        // 명시적변환(=캐스트)를 사용함 = 컴파일은 가능하나 '오버플로(값이 넘쳐나 뒤집힘)' 발생
            
        // 선택과제2
        char d1 = 'A';
        int d2 = d1;     // 결과값 "65"
        
        char e1 = '0';
        int e2 = e1;     // 결과값 "48"
        // 아라비아 숫자를 표현한 것이아니라, '0'이라는 모양을 그리기위한 번호 48을 뜻함(C# 아스키코드 값)
        
        // 선택과제3
        double f1 = 2.5;
        
        int f2 = (int)f1;       // 결과값 "2"
        int f3 = Convert.ToInt32(f1);       // 결과값 "2"

        f1 = 3.5;

        int f4 = (int)f1;       // 결과값 "3"
        int f5 = Convert.ToInt32(f1);       // 결과값 "4"
        
        // Console.WriteLine($"{f4}\n{f5}");
        
    }  
}