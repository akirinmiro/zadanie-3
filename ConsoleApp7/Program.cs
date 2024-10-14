using ConsoleApp7;



    var humans = new List<Human>
{
    new Human("Джон", 25),
    new Human("Алиса", 30),
    new Human("Ольга", 20),
    new Human("Ева", 35),
    new Human("Катя", 28)
};

    var filteredHumans = humans.Where(h => h.Age > 25);
    Console.WriteLine("Люди старше 25 лет:");
    foreach (var human in filteredHumans)
    {
        Console.WriteLine($"Имя: {human.Name}, Возраст: {human.Age}");
    }


    var sortedHumans = humans.OrderBy(h => h.Name.Length);
    Console.WriteLine("\nЛюди, отсортированные по длине имени:");
    foreach (var human in sortedHumans)
    {
        Console.WriteLine($"Имя: {human.Name}, Возраст: {human.Age}");
    }


