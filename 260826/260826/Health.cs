using System.Collections.Generic;
public class ObservableProperty<T>
{
    private T _value;

    public T Value
    {
        get { return _value; }
        set
        {
            _value = value;
            Notify();
        }
    }
//  공간이 없을떄 배열의 크기를 늘려주는 배열의 선언 방법
    private List<IObserver> _observers = new();

    public void Subscribe(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Unsubscribe(IObserver observer)
    {
        _observers.Remove(observer);
    }
    public void UnsubscribeAll()
    {
        _observers.Clear();
    }

    public void Notify()
    {
        foreach (IObserver obs in _observers)
        {
            obs.OnNotify();
        }
    }
}