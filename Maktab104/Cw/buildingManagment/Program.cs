using BuildingManage;
using Microsoft.VisualBasic.FileIO;




List<Building> buildings = new List<Building>();
bool IsPublic = true;

Counters counters = new Counters();
int id = counters.GetCounters();

while (IsPublic == true)
{
    Console.Write("Please Enter a Area: ");
    double area = double.Parse(Console.ReadLine());
    
    if (area >= 200)
    {
        // ایجاد سالن
        Console.Write("Type Saloon (Footsal=1/Volleyball=2): ");
        FieldType field = (FieldType)Enum.Parse(typeof(FieldType), Console.ReadLine(), true);
        Console.Write("Start hours: ");
        TimeSpan startTime = TimeSpan.Parse(Console.ReadLine());
        
        Saloon saloon = new Saloon
        {
            Id = id,
            Area = area,
            IsPublic = true,
            Filed = (FiledType)field,
            StratTime = startTime
        };
        buildings.Add(saloon);
    }
    else
    {
        // ایجاد آپارتمان
        Console.Write("Count Floor: ");
        int floors = int.Parse(Console.ReadLine());
        Console.Write("Have a Elevator? (true/false): ");
        bool hasElevator = bool.Parse(Console.ReadLine());
        
        Apartment apartment = new Apartment
        {
            Id = id,
            Area = area,
            IsPublic = false,
            CountOfFloor = floors,
            HasElevator = hasElevator
        };
        buildings.Add(apartment);
    }

    Console.WriteLine("Do you insert new building? (y/n)");

    if (Console.ReadLine().ToLower() == "y") IsPublic = true;
    else IsPublic = false;
       // break;
}

Console.WriteLine("1. Apartment List");
Console.WriteLine("2. Salon List");
Console.Write("Select: ");
int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        foreach (Building building in buildings)
        {
            if (building is Apartment apartment)
            {
                Console.WriteLine($"Apartment - Id: {counters.GetCounters()}, Area: {apartment.Area}, Floor: {apartment.CountOfFloor}, Elevator: {apartment.HasElevator}");
            }
        }

        break;
    case 2:
        foreach (Building building in buildings)
        {
            if (building is Saloon saloon)
            {
                Console.WriteLine($"Saloon - Id: {counters.GetCounters()}, Area: {saloon.Area}, Type: {saloon.Filed}, Start hours: {saloon.StratTime}");
            }
        }
        break;
    default:
        Console.WriteLine("Not valid");
        break;
}
