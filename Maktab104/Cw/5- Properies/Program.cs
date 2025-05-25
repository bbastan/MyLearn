using _5__Properies;
int counter = 1;
while (counter > 0) 
{
    Console.WriteLine("Enter character b[back] or c[cancel]: ");
    char character = Convert.ToChar(Console.ReadLine());
    if (character == 'b')
    {
        Console.WriteLine(" 1- Enter User: \n 2- View User: \n");
        string input = Console.ReadLine();
        User user = new User();
        Console.Write("Enter a number for Id: ");
        user.Id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a name for User: ");
        user.Name = Console.ReadLine();
        Console.Write("Enter a User name: ");
        string userName = Console.ReadLine();
        user.GetUser(userName);

    }
    else if (character == 'c')
    {
        System.Environment.Exit(0);
    }
}
