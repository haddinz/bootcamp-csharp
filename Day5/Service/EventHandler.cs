public delegate void MyEventHandler(object sender, string value);
public delegate void ClickEventHandler(); 

class EventHandler {
    public event ClickEventHandler OnClick;   

    public void Click() {
        Console.WriteLine("Button clicked!");
        OnClick?.Invoke(); 
    }
}