Console.WriteLine("");

Console.WriteLine(" ** This is your own Savings Calculator.Let's start saving **\n");

Console.WriteLine("=====================================");

Console.BackgroundColor = ConsoleColor.DarkCyan;

Console.ForegroundColor = ConsoleColor.White;

var accountName = " ";

do
{
  Console.WriteLine("Please enter your name.");
  accountName = Console.ReadLine()?.ToLower().Trim();
  if (string.IsNullOrEmpty(accountName))
  {
    Console.WriteLine("Account name can not be empty.");
  }
} while (string.IsNullOrEmpty(accountName));

Console.WriteLine($"Hello {accountName}!");

var initialDeposit = 0.0;

do
{
  Console.WriteLine("Please enter a deposit amount. Note $100 is minimum default deposit.");
  double.TryParse(Console.ReadLine(), out initialDeposit);
} while (initialDeposit < 100);

var interestRateAsPercentage = 0.0;

do
{
  Console.WriteLine("Q. Pick monthly interest rate in percentage.Enter 1 for 1.0, 2 for 2.3 or 3 for 3.5 Or X for Exit");
  var interestOption = Console.ReadLine();

  if (interestOption == "X")
  {
    break;
  }

  switch (interestOption)
  {
    case "1":
      interestRateAsPercentage = 1.0;
      break;
    case "2":
      interestRateAsPercentage = 2.3;
      break;
    case "3":
      interestRateAsPercentage = 3.5;
      break;
    default:
      Console.WriteLine("Invalid input, please enter one of the options: 1 for 1.0, 2 for 2.3 or 3 for 3.5. ");
      break;
  }
} while (interestRateAsPercentage == 0.0);

Console.WriteLine("Q. Please enter number of months you would like to save?");
var numberOfMonths = 0;
int.TryParse(Console.ReadLine(), out numberOfMonths);

var savings = initialDeposit * Math.Pow(1 + (interestRateAsPercentage / 100), numberOfMonths);

Console.WriteLine("==*********************==");

Console.WriteLine($"Here are your rounded savings $ {Math.Round(savings, 2)}");