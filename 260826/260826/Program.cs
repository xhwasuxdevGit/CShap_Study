
using System.Numerics;

public class Program
{
    public static void Main()
    {
        Player player = new();
        PlayerHealthUI ui = new();
        ExpUI expUI = new();
        PlayerPresenter pre = new(player, ui, expUI);
        
        
        
        
        
        int num1 = Sum<int>(1, 67, 23, 12, 5);
        float num2 = Sum<float>(3.14f, 2.5f, 7.7f);

        Console.WriteLine(num1);
        Console.WriteLine(num2);
        
        /*
        List<int> numbers = new();
        numbers.Add(1);     //데이터 추가
        numbers.Remove(1);  // 삭제
        numbers.RemoveAt(0);    //(인덱스로 접근해서)삭제
        numbers.Clear();    // 싹다비우기
        */
    }
    



    static T Sum<T>(params T[] values) where T : INumber<T>
        {
            T sum = T.Zero;

            foreach (T i in values)
            {
                sum += i;
            }

            return sum;
        }
    
}

