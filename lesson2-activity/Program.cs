
Console.WriteLine("");

Console.WriteLine(" ** Welcome to Mad Libs, where you spin your own mythical story **\n");

Console.WriteLine("Let's customize your unique journey with few answers!\n");

Console.ForegroundColor = ConsoleColor.Blue;

Console.WriteLine("=====================================");

// Restore the original console colors.
Console.ResetColor();

Console.WriteLine("Q. Please share your name?\n");
var playerName = Console.ReadLine()?.Trim();

Console.WriteLine("");

Console.WriteLine("Q. Please provide your your preferred way to travel from options below:\n");
Console.WriteLine("a. Bus");
Console.WriteLine("b. Train");
Console.WriteLine("c. Plane");
var preferredTransport = Console.ReadLine()?.Trim();

Console.WriteLine("Q. Pick your favorite mythical creature?\n");
var mythicalCreature = Console.ReadLine()?.Trim();

Console.WriteLine("Q. Pick a superpower?\n");
var superpower = Console.ReadLine()?.Trim();
Console.WriteLine("");

Console.WriteLine("Q. Share your dream travel destination ?\n");
var dreamTravelDestination = Console.ReadLine()?.Trim();
Console.WriteLine("");

Console.WriteLine("Q. Pick an adverb, e.g. playfully, sadly\n");
var adverb = Console.ReadLine()?.Trim();
Console.WriteLine("");

Console.WriteLine("Q. Pick a plural noun\n");
var pluralNoun = Console.ReadLine()?.Trim();
Console.WriteLine("");

Console.WriteLine("=====================================");

Console.WriteLine("Here is your story");

Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine($"{playerName} woke up in the night with a dream of a new quest to meet with {mythicalCreature} of { dreamTravelDestination}, {adverb} started looking at tickets for {preferredTransport}.");
Console.WriteLine($"{playerName} was very happy to get a booking for coming weekend, when suddenly {pluralNoun} appeared.");
Console.WriteLine($"{pluralNoun} made a screaching sound and used their {superpower} power.");
Console.WriteLine($"{playerName} was very frightened and immediately got up from the bed, then realized that the sound was from the alarm tone.");