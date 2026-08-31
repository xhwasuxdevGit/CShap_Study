//https://github.com/xhwasuxdevGit/study
using System;
public class Program
{
  
  public static void Main()
  {
    const string shopName = "MG컴포잭다방 천호점";
   int actionSelct;
    
     Customer c1 = new Customer(10000);
     c1.InputMenu();
     c1.BuyCart();
    
   
    
  }

  public static void PrintAllMenu()
  {
      Americano.PrintMenu();
      CafeLatte.PrintMenu();
      IceTea.PrintMenu();
      GreenTea.PrintMenu();
      ChocoLatte.PrintMenu();
      Cookie.PrintMenu();
      SaltBread.PrintMenu();
      Waffle.PrintMenu();
  }
      

  public static int ActionMenu()
  {
      Console.WriteLine("진행하고 싶은 메뉴를 선택해 입력해주세요.");
      int actionNumber = ConsoleInput.ReadIntInRange("메뉴 번호를 입력해 주세요 ", 1, 5);
      return actionNumber;
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
