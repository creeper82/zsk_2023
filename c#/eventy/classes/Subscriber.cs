namespace Eventy;

public class Subscriber {
    public void OnNewVideo(string videoName, string channelName) {
        Console.WriteLine($"Kanał {channelName} wypuszcza film: {videoName}");
    }
}