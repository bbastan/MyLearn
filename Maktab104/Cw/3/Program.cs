

using _3;

Area area = new Area();
Console.Write("Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
area.CalculateArea(number1);
Triangle triangle = new Triangle();
Console.Write("Enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
triangle.CalculateArea(number1, number2);
