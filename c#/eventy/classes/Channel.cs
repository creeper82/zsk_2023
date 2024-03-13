namespace Eventy;

public class Channel(string Name) {
    public delegate void NewVideoHandler(string message, string channelName);

    public event NewVideoHandler? NewVideoEvent = null;

    public void PublishVideo(string videoName) {
        if (NewVideoEvent is not null) {
            NewVideoEvent(videoName, Name);
        }
    }
}