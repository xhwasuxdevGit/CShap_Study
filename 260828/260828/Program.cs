//https://github.com/xhwasuxdevGit/study
using System;
public class Program
{
  
  public static void Main()
  {
      int selectedKioskMenu;
      Customer c1 = new Customer(10000);
      selectedKioskMenu = PrinKioskMenu();
      switch (selectedKioskMenu)
      {
          case 1:
              c1.InputMenu();
              PrinKioskMenu();
              break;
          case 2:
              c1.CartClear();
              PrinKioskMenu();
              break;
          case 3:
              c1.BuyCart();
              PrinKioskMenu();
              break;
          case 4:
              Console.WriteLine("직원만 사용가능한 메뉴 입니다");
              PrinKioskMenu();
              break;
          default:
              break;
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
