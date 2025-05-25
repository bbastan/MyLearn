using _4_Interface;

PrimeNumber primeNumber = new PrimeNumber();
Console.WriteLine("Enter a number for calculator Prime number: ");
int input = Convert.ToInt32(Console.ReadLine());
int result = primeNumber.CheckPrime(input);