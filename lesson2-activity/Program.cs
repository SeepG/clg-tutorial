
Console.WriteLine(" ** Welcome to Mad Libs, where you spin your own mythical story **");

Console.WriteLine("Let's customize your unique journey with few answers!");

Console.ForegroundColor = ConsoleColor.Blue;

Console.WriteLine("=====================================");

// Restore the original console colors.
Console.ResetColor();

Console.WriteLine("Q. Please share your name?");

var playerName = Console.ReadLine();

Console.WriteLine("Q. Please provide your your preferred way to travel from options below:");
Console.WriteLine("a. Bus");
Console.WriteLine("b. Train");
Console.WriteLine("c. Plane");

var preferredTransport = Console.ReadLine();

Console.WriteLine("Q. Pick your favorite mythical creature?");

var mythicalCreature = Console.ReadLine();


Console.WriteLine("Q. Pick a superpower?");

var superpower = Console.ReadLine();

Console.WriteLine("Q. Share your dream travel destination ?");

var dreamTravelDestination = Console.ReadLine();

Console.WriteLine("Q. Pick an adverb, e.g. playfully, sadly");

var adverb = Console.ReadLine();

Console.WriteLine("Q. Pick a plural noun");

var pluralNoun = Console.ReadLine();

Console.WriteLine("=====================================");

Console.WriteLine("Here is your story");

Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine($"{playerName?.Trim()} woke up in the night with a dream of a new quest to meet with {mythicalCreature?.Trim()} of { dreamTravelDestination?.Trim()}, {adverb?.Trim()} started looking at tickets for {preferredTransport?.Trim()}.");
Console.WriteLine($"{playerName?.Trim()} was very happy to get a booking for coming weekend, when suddenly {pluralNoun?.Trim()} appeared.");
Console.WriteLine($"{pluralNoun?.Trim()} made a screaching sound and used their {superpower?.Trim()} power.");
Console.WriteLine($"{playerName?.Trim()} was very frightened and immediately got up from the bed, then realized that the sound was from the alarm tone.");