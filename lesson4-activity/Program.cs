
Console.WriteLine(" ");
Console.WriteLine("Time for NumberMagic, wherein you can guess your lucky number.");

Console.WriteLine("🎲 🎲 🎲 🎲");
Console.WriteLine(" ");

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.BackgroundColor = ConsoleColor.White;

var luckyNumber = new Random().Next(1, 11);
Console.WriteLine("Guess a number from 1 to 10:    ");

var guessedNumber = 0;

var allowedGuesses = 3;
var numberOfTries = 0;

while (numberOfTries < allowedGuesses)
{
  int.TryParse(Console.ReadLine(), out guessedNumber);
  numberOfTries++;

  if (guessedNumber == luckyNumber)
  {
    Console.WriteLine($"Bingo! You guessed correctly.");
    break;
  }
  else if (guessedNumber > luckyNumber)
  {
    Console.Write($"Your guessed number is 🆙 High.");
  }

  else if (guessedNumber < luckyNumber)
  {
    Console.WriteLine($"Your guessed number is ⬇️ Low.");
  }

  if (luckyNumber % 2 == 0)
  {
    Console.WriteLine($"The lucky number is Even.");
  }
  else if (luckyNumber % 2 != 0)
  {
    Console.WriteLine($"The lucky number is Odd.");
  }
  Console.WriteLine($"You have {Math.Abs(numberOfTries - allowedGuesses)} tries left");

}
Console.WriteLine($"Thanks for playing. We will see you next time. The luck number was: {luckyNumber}.");

Console.WriteLine(" ");

Console.WriteLine("🎲 🎲 🎲 🎲");
