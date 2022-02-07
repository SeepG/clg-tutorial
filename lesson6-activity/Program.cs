
ConsoleKeyInfo cki;
double num1 = 0; 
double num2 = 0;

Console.WriteLine("Try a simple Console Calculator in C#\n");

do
{     
        Console.WriteLine("Please enter 1st number, then press Enter\n");
        double.TryParse(Console.ReadLine(), out num1);

        Console.WriteLine("Please enter 2nd number, then press Enter\n");
        double.TryParse(Console.ReadLine(), out num2);  

        GiveInstructions();  

        string calculationOption = Console.ReadLine()!.ToLower();
        
        RespondToUserInput(calculationOption, num1, num2);

        Console.WriteLine("Press <ESCAPE> (Esc) key to quit or any key to continue\n");
        cki = Console.ReadKey(true);
} while (cki.Key != ConsoleKey.Escape);

static void GiveInstructions() {
        Console.WriteLine("Pick your calculation options below.");
        Console.WriteLine("\ta - Add");
        Console.WriteLine("\ts - Subtract");
        Console.WriteLine("\tm - Multiply");
        Console.WriteLine("\td - Divide");
        Console.WriteLine("\te - Exponents or Raise to the power\n");
        Console.Write("Your option is :     ");

}

static void RespondToUserInput( string calculationOption, double num1, double num2) {
        switch (calculationOption) 
                {
                        case "a":
                        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                        break;

                        case "s":
                        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                        break;

                        case "m":
                        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                        break;

                        case "d":
                        while (num2 == 0) {
                                Console.WriteLine("Please provide a non-zero divisor.");
                                double.TryParse(Console.ReadLine(), out num2);    
                        }
                        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                        break;

                        case "e":
                        Console.WriteLine($"Your result: {num1} ^ {num2} = " + Math.Pow(num1, num2));
                        break;

                        default:
                        Console.WriteLine("Invalid input");
                        break;
                }
}