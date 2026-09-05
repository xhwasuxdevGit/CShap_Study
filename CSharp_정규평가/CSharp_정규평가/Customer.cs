using System;
public class Customer
{
    private int money;
    private int change;
    private List<MenuItem> cart = new List<MenuItem>();
    private List<int> cartPrice = new List<int>();

    public Customer(int _money)
    {
        money = _money;
    }

    public void InputCart()
    {
        int eachPrice = 0;
        MenuSheet menusheet = new MenuSheet();
        menusheet.PrintMenuSheet();
        
        int menuNumber = ConsoleInput.ReadIntInRange("메뉴 번호를 입력해 주세요 ", 1, 8);
        int mount = ConsoleInput.ReadIntAtLeast("갯수를 입력해주세요 ", 1);
        ConsoleInput.Pause();
       
        for (int i = 0; i < mount; i++)
        {
            switch (menuNumber)
            {
                case 1:
                    cart.Add(new Americano());
                    break;
                case 2:
                    cart.Add(new CafeLatte());
                    break;
                case 3:
                    cart.Add(new IceTea());
                    break;
                case 4:
                    cart.Add(new GreenTea());
                    break;
                case 5:
                    cart.Add(new ChocoLatte());
                    break;
                case 6:
                    cart.Add(new Cookie());
                    break;
                case 7:
                    cart.Add(new SaltBread());
                    break;
                case 8:
                    cart.Add(new Waffle());
                    break;
                default:
                    break;
            }
            
        }

        eachPrice = cart[cart.Count - 1].CalculatePrice(mount);
        cartPrice.Add(eachPrice);
       
    }

    public int CalculateCart()
    {
        int totalPrice = 0;
        for (int i = 0; i < cartPrice.Count; i++)
        {
            totalPrice += cartPrice[i];
        }
        
        return totalPrice;
    }

    public void PrintCartInfo()
    {
        Console.Clear();
        Console.WriteLine($"[선택한 메뉴 목록]");
        Console.WriteLine();
        for (int i = 0; i < cart.Count; i++)
        { 
            Console.Write($"{cart[i].Name} / ");
        }
        Console.WriteLine();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine($"장바구니에 담긴 메뉴: {cart.Count}개 - 총 {CalculateCart()}원");
        Console.WriteLine("------------------------------------------");
        ConsoleInput.Pause();
    }
   
    public void CartClear()
    {
        cart.Clear();
        Console.Clear();
        Console.WriteLine("[담은 메뉴를 모두 삭제했습니다.]");
        ConsoleInput.Pause();
    }
   

    public void BuyCart()
    {
        if (money >= CalculateCart())
        {
            change = money - CalculateCart();
            Console.Clear();
            Console.WriteLine($"결제금액은 {CalculateCart()}원 입니다. 거스름돈은 {change}원 입니다");
            ConsoleInput.Pause();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("[소지금이 부족합니다.]");
            ConsoleInput.Pause();
        }
    }
        
         
    
}