using System;
public class Program
{
  
  public static void Main()
  {
    const string shopName = "MG컴포잭다방 천호점";
    int customerMoney = 10000;
    int actionSelct;
    List<MenuItem> Cart = new List<MenuItem>();
    
    actionSelct = ActionMenu();
    switch (actionSelct)
    {
        case 1:
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        default:
            break;
    }
    
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
