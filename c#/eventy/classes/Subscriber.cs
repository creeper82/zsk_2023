namespace Eventy;

public class Subscriber(int priorityTreshold) {
    public int PriorityTreshold {get; set;} = priorityTreshold;

    public void OnNewVideo(string videoName, string channelName, int priority) {
        if (priority >= PriorityTreshold) Console.WriteLine($"Kanał {channelName} wypuszcza film: {videoName}.. Ważność: {priority}");
    }
}