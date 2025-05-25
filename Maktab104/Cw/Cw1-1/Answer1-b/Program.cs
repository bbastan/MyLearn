using Answer1_b;

Calculator calculator = new Calculator();
Console.WriteLine($"Enter the first number:");
double result = calculator.MyCalculator(double.Parse(Console.ReadLine()));
Console.WriteLine($"Reslut is {result}");
