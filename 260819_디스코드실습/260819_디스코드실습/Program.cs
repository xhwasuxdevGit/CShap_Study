using System;

class Program
{
    static bool isPlaying = true;
    
    static void Main(string[] args)
    {
        int mapSize = 10;
        
        char[,] map = GetInitMap(mapSize);
        
        int playerX = 0;
        int playerY = 0;
        SetPlayerPosition(map, ref playerX, ref playerY);
        
        while (isPlaying)
        {
            // 맵 출력
            PrintMap(map, mapSize);

            // 유저 입력을 받아 방향 설정
            int nextX;
            int nextY;
            SetNextPosFromUserInput(playerX, playerY, out nextX, out nextY);
            
            // 배열 범위 밖 처리
            if (!CanMove(nextX, nextY, mapSize))
            {
                continue;
            }
            
            // 실제 맵에 적용하기
            playerX = nextX;
            playerY = nextY;
            
            SetPlayerPosition(map, ref playerX, ref playerY, nextX, nextY);
            
        }
    }

    static void SetPlayerPosition(char[,] map, ref int playerX, ref int playerY, int nextX = -1, int nextY = -1)
    {
        if (nextX == -1 || nextY == -1)
        {
            map[playerY, playerX] = 'p';
        }
        else
        {
            map[playerY, playerX] = '.';
            map[nextY, nextX] = 'p';
            playerX = nextX;
            playerY = nextY;
        }
    }
    
    static bool CanMove(int nextX, int nextY, int mapSize)
    {
        bool canMove = nextY >= 0 && nextX >= 0 && nextY < mapSize && nextX < mapSize;
        return canMove;
    }

    static void SetNextPosFromUserInput(int playerX, int playerY, out int nextX, out int nextY)
    {
        char userInput = char.ToUpper(Console.ReadKey(true).KeyChar);
            
        nextX = playerX;
        nextY = playerY;

        switch (userInput)
        {
            case 'W':
                nextY--;
                break;
            case 'S':
                nextY++;
                break;
            case 'A':
                nextX--;
                break;
            case 'D':
                nextX++;
                break;
            case 'C':
                isPlaying = false;
                break;
        }
    }


    static char[,] GetInitMap(int mapSize)
    {
        char[,] map = new char[mapSize, mapSize];

        for (int y = 0; y < mapSize; y++)
        {
            for (int x = 0; x < mapSize; x++)
            {
                map[y, x] = '.';
            }
        }

        return map;
    }
   

    static void PrintMap(char[,] map, int mapSize)
    {
        Console.Clear();
        for (int y = 0; y < mapSize; y++)
        {
            for (int x = 0; x < mapSize; x++)
            {
                Console.Write(map[y, x]);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
}