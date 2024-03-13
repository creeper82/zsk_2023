using Youtube;

Console.WriteLine("Witamy w YouTube!");
Console.WriteLine("Twoje konto: sushiMapper");

var mandzio = new Channel("Mandzio");
var kruszwil = new Channel("Kruszwil");

var sushiMapper = new Subscriber(priorityTreshold: VideoPriority.Important);

// suszek subskrybuje dwa kanały
mandzio.NewVideoEvent += sushiMapper.OnNewVideo;
kruszwil.NewVideoEvent += sushiMapper.OnNewVideo;

// kruszwil wypuszcza film
kruszwil.PublishVideo("Przeżyłem 24H pod ziemią!", videoPriority: VideoPriority.NotImportant);

// mandzio wypuszcza film
mandzio.PublishVideo("MINECRAFT - LET'S PLAY #37", videoPriority: VideoPriority.Important);

//kruszwil wypuszcza wazny film
kruszwil.PublishVideo("Mega ważne! koniec świata", videoPriority: VideoPriority.ExtremelyImportant);