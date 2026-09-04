using System;
using System.Collections.Generic;


public class Customer
{
    private int money;
    private int menuNumber;
    private int totalPrice;
    private int change;
    private List<MenuItem> cart = new List<MenuItem>();

    public Customer(int mount)
    {
        money = mount;
    }


    public void InputMenu()
    {
        int menuNumber = ConsoleInput.ReadIntInRange("메뉴 번호를 입력해 주세요 ", 1, 8);
        int menuMount = ConsoleInput.ReadIntInRange("갯수를 입력해주세요 ", 1, 5);

        for (int i = 0; i < menuMount; i++)
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

        Console.WriteLine($"[선택한 메뉴 목록]");
        for (int i = 0; i < cart.Count; i++)
        {
            Console.Write($"{cart[i].Name} / ");
            totalPrice += cart[i].Cost;

        }

        Console.WriteLine($"장바구니에 담긴 메뉴: {cart.Count}개 - 총 {totalPrice}원");
        Console.WriteLine();
    }

    public int TotalPrice
    {
        get { return totalPrice; }
    }
    
    

    public void CartClear()
    {
        Console.WriteLine("담은 메뉴를 모두 삭제했습니다.");
        Console.WriteLine();
        cart.Clear();
        

    }

    public void BuyCart()
    {
        if (money >= totalPrice)
        {
            change = money - totalPrice;
            Console.WriteLine($"결제금액은 {totalPrice}원 입니다. 거스름돈은 {change}원 입니다");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("소지금이 부족합니다.");
            Console.WriteLine();
        }

    }
}