using BuildingManage.Entity;
using BuildingManage.Enum;
using System.Diagnostics.Metrics;

List<Building> buildings = new List<Building>();
bool isPublic = true;

Counter counter = new Counter();


while (isPublic)
{
    
    Console.Write("Enter a area: ");
    double area = Convert.ToInt32(Console.ReadLine());
    if (area >= 200)
    {
        Console.Write("Select saloon (1:Footsal/2:Valibal): ");
        FiledType filed = (FiledType)Enum.Parse(typeof(FiledType), Console.ReadLine(), true);
        Console.Write($"Enter a start time to {filed}: ");
        TimeSpan stratTime = TimeSpan.Parse(Console.ReadLine());
        int id = counter.GetCounter();
        Saloon saloon = new Saloon()
        {
            Id = id,
            Area = area,
            Filed = filed,
            StartTime = stratTime
        };
        buildings.Add(saloon);
    }
    else
    {
        Console.Write("Enter count of floor in apartment: ");
        int countOfFloor = int.Parse(Console.ReadLine());
        Console.Write("Has apartment elevetor (true/false): ");
        bool hasElevetor = bool.Parse(Console.ReadLine());
        int id = counter.GetCounter();
        Apartment apartment = new Apartment()
        {
            Id = id,
            Area = area,
            CountOfFloor = countOfFloor,
            HasElevetor = hasElevetor
        };
        buildings.Add(apartment);
    }
    Console.Write("Do you insert new building? (y/n): ");
    if (Console.ReadLine().ToLower() == "y") isPublic = true;
    else isPublic = false;
}
while (isPublic == false)
{
    Console.Write("1.List apartmnet\n2.List Saloon\nSelect: ");
    int choise = int.Parse(Console.ReadLine());
    switch (choise)
    {
        case 1:
            foreach (Building building in buildings)
            {
                if (building is Apartment apartment)
                {
                    Console.WriteLine($"Apartmnet - Id:{apartment.Id}, Area:{apartment.Area}, Count of Floor:{apartment.CountOfFloor}, Has Elevetor:{apartment.HasElevetor}");
                }
            }
            break;
        case 2:
            foreach (Building building in buildings)
            {
                if (building is Saloon saloon)
                {
                    Console.WriteLine($"Saloon - Id:{saloon.Id}, Area:{saloon.Area}, Filed:{saloon.Filed}, Start Time:{saloon.StartTime}");
                }
            }
            break;
        default:
            Console.WriteLine("Not valid");
            break;

    }
    Console.Write("Do you see result again? (y/n): ");
    if (Console.ReadLine().ToLower() == "y") isPublic = false;
    else isPublic = true;
}
