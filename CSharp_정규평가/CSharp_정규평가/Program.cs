using System;
public class Program
{

    public static void Main()
    {
        
        List<Customer> customers = new List<Customer>();
        int totalSales = 0;
        customers.Add(new Customer(10000));
        customers.Add(new Customer(5000));
        
        EnterCustomer(customers[0]);
      
        Console.WriteLine("[두번째 손님 입장]");
        EnterCustomer(customers[1]);
        
        // 마감 절차
        Console.WriteLine("[마감정산 시작]");
        int closeShop = PrinKioskMenu();
        
        for (int i = 0; i < customers.Count; i++)
        {
            totalSales += customers[i].CalculateCart();
        }

        while (closeShop != 4)
        {
            Console.Clear();
            Console.WriteLine("[접근제한: 직원은 마감정산 메뉴만 선택할 수 있습니다.]");
            ConsoleInput.Pause();
            closeShop = PrinKioskMenu();
        }
        if (closeShop == 4)
            {
                Console.Clear();
                Console.WriteLine("[정산 내역]");
                Console.WriteLine($"총 주문 건수: {customers.Count}개  /  총 판매 금액: {totalSales}원 입니다.");
            }
           
    }

  public static void EnterCustomer(Customer customer)
  {
     int selectedKiosk =  PrinKioskMenu();
      
      while (selectedKiosk != 3)
      {
            
          if (selectedKiosk == 1)
          {
              customer.InputCart();
              customer.PrintCartInfo();
          }
          else if (selectedKiosk == 2)
          {
              customer.CartClear();
          }
          else if (selectedKiosk == 4)
          {
              Console.WriteLine("[접근 제한: 마감 정산은 직원만 선택 가능합니다.]");
              Console.WriteLine("");
          }

          selectedKiosk = PrinKioskMenu();
          
      }

      if (selectedKiosk == 3)
      {
          customer.BuyCart();
      }
  }

  public static void CloseShop()
  {
      int selectedKiosk =  PrinKioskMenu();
      
      while (selectedKiosk != 4)
      {
          Console.WriteLine("[접근 제한: 직원 마감정산 메뉴만 선택할 수 있습니다.]");
         
          selectedKiosk = PrinKioskMenu();
      }

      if (selectedKiosk == 4)
      {
          
      }
  }
  
  public static int PrinKioskMenu()
  {
      const string SHOP_NAME = "MG컴포잭다방 천호점";
      Console.WriteLine("------------------------------");
      Console.WriteLine($"<{SHOP_NAME}> 키오스크 ");
      Console.WriteLine("------------------------------");
      Console.WriteLine("[1. 메뉴 선택하기]  [2.장바구니 비우기]  [3.결제하기]  [4.마감정산(직원전용)]");
      Console.WriteLine();
      int kioskNumber = ConsoleInput.ReadIntInRange("하시고 싶은 일을 선택해주세요 ", 1, 4);
      ConsoleInput.Pause();
      return kioskNumber;
      
  }
  
  
}
