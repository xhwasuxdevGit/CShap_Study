//https://github.com/xhwasuxdevGit/study
using System;
public class Program
{
  
  public static void Main()
  {
      int firstselectedKiosk;
      Customer c1 = new Customer(10000);
      firstselectedKiosk = PrinKioskMenu();
      
      while (firstselectedKiosk != 3)
      {
          PrinKioskMenu();
          int loopKiosk = PrinKioskMenu();
          if (loopKiosk == 1)
          {
              c1.InputMenu();
          }
          else if (loopKiosk == 2)
          {
              c1.CartClear();
          }
          else if (loopKiosk == 4)
          {
              Console.WriteLine("마감 정산은 직원만 선택 가능합니다.");
              Console.WriteLine("");
          }
          
          
          /*
          switch (selectedKioskMenu)
          {
              case 1:
                  c1.InputMenu();
                  break;
              case 2:
                  c1.CartClear();
                  break;
              case 4:
                  Console.WriteLine("마감 정산은 직원만 선택 가능합니다.");
                  Console.WriteLine("");
                  break;
              default:
                  break;
          }
          */

         

      }

      if (selectedKioskMenu == 3)
      {
          c1.BuyCart();
      }
    
      







  }
    
  // 함수 호출하면 뒤따르는 손님의 메뉴담기가 제대로 안이루어짐
  // 뭘입력하더라도 와플이 담기는것으로보아 스태틱으로 선언한게 문제인거 같은데...
  public static void PrintAllMenu()
  {
      Console.WriteLine("------------------------------");
      Americano.PrintMenu();
      CafeLatte.PrintMenu();
      IceTea.PrintMenu();
      GreenTea.PrintMenu();
      ChocoLatte.PrintMenu();
      Cookie.PrintMenu();
      SaltBread.PrintMenu();
      Waffle.PrintMenu();
      Console.WriteLine("------------------------------");
  }
  

  public static int PrinKioskMenu()
  {
      const string SHOP_NAME = "MG컴포잭다방 천호점";
      Console.WriteLine("------------------------------");
      Console.WriteLine($"<{SHOP_NAME}> 키오스크 ");
      Console.WriteLine("------------------------------");
      Console.WriteLine("[1. 메뉴 선택하기]  [2.장바구니 비우기]  [3.결제하기]  [4.마감정산(직원전용)]");
      int kioskNumber = ConsoleInput.ReadIntInRange("하시고 싶은 일을 선택해주세요 ", 1, 4);
      Console.WriteLine();
   
      return kioskNumber;
      
      
  }


  
  


  
  
}
