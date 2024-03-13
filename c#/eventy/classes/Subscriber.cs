namespace Youtube;

public class Subscriber(VideoPriority priorityTreshold) {
    public VideoPriority PriorityTreshold {get; set;} = priorityTreshold;

    public void OnNewVideo(string videoName, string channelName, VideoPriority priority) {
        if (priority >= PriorityTreshold) Console.WriteLine($"Kanał {channelName} wypuszcza film: {videoName}.. Ważność: {priority}");
    }
}