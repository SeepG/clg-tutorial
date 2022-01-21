
Console.WriteLine(" ");
Console.WriteLine("Time for NumberMagic, wherein you can guess your lucky number.");

Console.WriteLine("🎲 🎲 🎲 🎲");
Console.WriteLine(" ");

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.BackgroundColor = ConsoleColor.White;

var luckyNumber = new Random().Next(1, 11);
Console.WriteLine("Guess a number from 1 to 10\n");

var guessedNumber = 0;

var allowedGuesses = 3;

var numberOfTries = 0;

while (numberOfTries < allowedGuesses)
{
  int.TryParse(Console.ReadLine(), out guessedNumber);
  numberOfTries++;

  if (guessedNumber == luckyNumber)
  {
    Console.WriteLine($"Bingo! You guessed correctly.\n");
    break;
  }
  else if (guessedNumber > luckyNumber)
  {
    Console.WriteLine($"Your guessed number is 🆙 High.\n");
  }
  else if (guessedNumber < luckyNumber)
  {
    Console.WriteLine($"Your guessed number is ⬇️ Low.\n");
  }
  if (luckyNumber % 2 == 0)
  {
    Console.WriteLine($"The lucky number is Even.\n");
  }
  else if (luckyNumber % 2 != 0)
  {
    Console.WriteLine($"The lucky number is Odd.\n");
  }
  if (numberOfTries == 2)
  {
    Console.WriteLine($"Try again. You have {Math.Abs(numberOfTries - allowedGuesses)} tries left\n");
  }
}

Console.WriteLine($"Thanks for playing. We will see you next time. The luck number was: {luckyNumber}.\n");

Console.WriteLine("🎲 🎲 🎲 🎲");
