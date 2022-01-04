Console.WriteLine("");

Console.WriteLine(" ** This is your own Savings Calculator **\n");

Console.WriteLine("Let's start saving\n");

Console.ForegroundColor = ConsoleColor.Blue;

Console.WriteLine("=====================================");

// Restore the original console colors.
Console.ResetColor();

Console.WriteLine("Please enter your name\n");
var accountName = Console.ReadLine()?.Trim();


Console.WriteLine("$500 is default deposit amount, you can add more if you want");
Console.WriteLine("Enter a deposit amount\n");
var deposit = int.Parse((Console.ReadLine() ?? "500"));



Console.WriteLine("Q. What monthly interest rate you would prefer. Ps.note: 1.0 is default interest rate\n");
Console.WriteLine("1.0");
Console.WriteLine("2.3");
Console.WriteLine("3.5");
var interestRateAsPercentage = double.Parse((Console.ReadLine() ?? "1.0"));

Console.WriteLine("Q. Please enter number of months you would like to save? Ps.note: 6 months is default deposit period\n");
var numberOfMonths = int.Parse((Console.ReadLine() ?? "6"));

var savings = deposit * Math.Pow(1 + (interestRateAsPercentage / 100), numberOfMonths);

Console.WriteLine(savings);

// var result = 500 * Math.Pow(1 + (1.0 / 100), 6);

Console.WriteLine(result);