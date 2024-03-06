namespace Eventy;

public class Subscriber {
    public void OnMessageReceived(string message) {
        Console.WriteLine("Otrzymano: " + message);
    }
}