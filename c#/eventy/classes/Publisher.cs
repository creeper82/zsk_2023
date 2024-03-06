namespace Eventy;

public class Publisher {
    public delegate void MessageHandler(string message);

    public event MessageHandler? MessageEvent = null;

    public void SendMessage(string message) {
        if (MessageEvent is not null) {
            MessageEvent(message);
        }
    }
}