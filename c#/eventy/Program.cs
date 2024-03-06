using Eventy;

Console.WriteLine("Witamy w YouTube!");
Console.WriteLine("Twoje konto: sushiMapper");

var mandzio = new Publisher();
var kruszwil = new Publisher();

var sushiMapper = new Subscriber();

// suszek subskrybuje dwa kanały
mandzio.MessageEvent += sushiMapper.OnMessageReceived;
kruszwil.MessageEvent += sushiMapper.OnMessageReceived;

// kruszwil wypuszcza film
kruszwil.SendMessage("Nowy film: PRZEŻYŁEM 24H POD ZIEMIĄ!");

// mandzio wypuszcza film
mandzio.SendMessage("Nowy film: MINECRAFT - LET'S PLAY #37");