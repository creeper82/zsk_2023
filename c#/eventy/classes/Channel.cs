namespace Youtube;

public class Channel(string Name) {
    public delegate void NewVideoHandler(string message, string channelName, VideoPriority priority);

    public event NewVideoHandler? NewVideoEvent = null;

    public void PublishVideo(string videoName, VideoPriority videoPriority) {
        if (NewVideoEvent is not null) {
            NewVideoEvent(videoName, Name, videoPriority);
        }
    }
}