using Answer1_c;

Console.WriteLine("Enter a number for loop");
Calculator calculator = new Calculator();
double result = calculator.Mycalculator(int.Parse(Console.ReadLine()));
Console.WriteLine($"Result is: {result}");
