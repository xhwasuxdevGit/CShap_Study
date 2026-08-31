//https://github.com/xhwasuxdevGit/study
using System;
public class Program
{
  
  public static void Main()
  {
    const string shopName = "[MG컴포잭다방 천호점]";
    
    Customer c1 = new Customer(10000);
    
    Console.WriteLine($"========   {shopName} 주문 키오스크   ========");
    Console.WriteLine("");
    
    
    c1.InputMenu();
    
    
    /*switch (PrintKiosk())
    {
        case 1:
            PrintAllMenu();
            customers[0].InputMenu();
            break;
        case 2:
            Console.Clear();
            customers[0].CartClear();
            break;
        case 3:
            Console.Clear();
            customers[0].BuyCart();
            break;
        case 4:
            Console.Clear();
            Console.WriteLine("일반 고객은 선택할 수 없는 메뉴 입니다");
            break;
        default:
            break;
    }
    */
    
    
   
    
  }

  public static void PrintAllMenu()
  {
      
      Console.WriteLine("-----------------------------------");
      Console.WriteLine("<메뉴 일람>");
      Americano.PrintMenu();
      CafeLatte.PrintMenu();
      IceTea.PrintMenu();
      GreenTea.PrintMenu();
      ChocoLatte.PrintMenu();
      Cookie.PrintMenu();
      SaltBread.PrintMenu();
      Waffle.PrintMenu();
      Console.WriteLine("-----------------------------------");
  }

  public static int PrintKiosk()
  {
      Console.WriteLine("------------- 키오스크 메뉴를 선택해주세요 -------------");
      Console.WriteLine("1.물건 담기  2.장바구니 비우기  3.결제하기  4. 영업마감");
      int kioskMenuNumber = ConsoleInput.ReadIntInRange("메뉴 번호를 입력해 주세요 ", 1, 4);
      return kioskMenuNumber;
  }
      
  public static void PrintMenuSheet()
  {
      
  }

  public static void PrintCart()
  {
      
  }

  public static void MenuSelect()
  {
      
  }
  
  


  
  
}
