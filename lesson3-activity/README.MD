# SAVINGS CALCULATOR

### ACTIVITY DESCRIPTION
This activity is to create a savings calculator to calculate how much someone can save when they have a particular initial deposit, interest rate and number of months they save for. The calculator will also tell somebody whether they will hit a particular savings goal.


### INSTRUCTIONS
Set up

- Create a folder for a new application, and call it “Lesson 3 Activity”

- Open this folder in Visual Studio Code

- Create a new console application

### TASK
Write an application that will calculate savings for a user.

Ask the user for

Initial deposit

Monthly interest rate

Number of months the user will save for

Take the values input by the user and convert these to an appropriate numeric type

Write a calculation to calculate savings after the given number of months (if you need help with this calculation, look at the hints section below)


If you get stuck at any point, rewatching the videos can help.

 

You may want to use the methods

Console.WriteLine()

Console.ReadLine()

Math.Pow()

int.Parse() or double.Parse()

 

Extension activity:

If you complete the above task, try introducing factors that might change your calculations for example

Extra monthly deposits

Changing number of months to number of years saved
 

To calculate the total savings in C#


var savings = deposit * Math.Pow(1 + (interestRateAsPercentage/100),monthsSavingFor);
