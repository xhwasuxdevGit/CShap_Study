using System;
public class PlayerHealthUI : IObserver
{

    public void RefreshUI()
    {
        Console.WriteLine("UI 갱신");
    }
    
    public void OnNotify()
    {
        RefreshUI();
    }
}