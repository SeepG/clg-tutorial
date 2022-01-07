Console.WriteLine("");

Console.WriteLine(" ** This is your own Savings Calculator **\n");

Console.WriteLine("Let's start saving\n");

Console.WriteLine("=====================================");

Console.BackgroundColor = ConsoleColor.DarkCyan;

Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("Please enter your name\n");
var accountName = Console.ReadLine()?.Trim();

var initialDeposit = 0.0;

// var result = myMethod(input1, input2, out outParam);
// result(which is return value of myMethod)
// outParam(is an updated value which will be updated in mymethod)

do
{
  Console.WriteLine("Please enter a deposit amount\n");
  var accountDeposit = double.TryParse(Console.ReadLine(), out initialDeposit);
} while (initialDeposit <= 0.0);


Console.WriteLine("Q. What monthly interest rate you would prefer\n");
Console.WriteLine("1.0");
Console.WriteLine("2.3");
Console.WriteLine("3.5");

Console.WriteLine("");

var interestRateAsPercentage = 0.0;
double.TryParse(Console.ReadLine(), out interestRateAsPercentage);

Console.WriteLine("Q. Please enter number of months you would like to save?\n");
var numberOfMonths = 0;
int.TryParse(Console.ReadLine(), out numberOfMonths);

var savings = initialDeposit * Math.Pow(1 + (interestRateAsPercentage / 100), numberOfMonths);

var totalSavings = (Math.Round(savings));

Console.WriteLine($"Here are your $ {totalSavings}");