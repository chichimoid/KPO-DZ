namespace Zoo;

public class Zoo
{
    public Clinic Clinic { get; private set; }
    public List<Animal> Animals { get; private set; } = [];
    public List<Item> Things { get; private set; } = [];
    public Zoo(Clinic clinic)
    {
        Clinic = clinic;
    }

    public void AddAnimal<T>(T animal) where T : Animal
    {
        if (Clinic.IsHealthy(animal))
        {
            Animals.Add(animal);
            Console.WriteLine($"Added {animal.GetType().Name}.");
        }
        else
        {
            Console.WriteLine($"{animal.GetType().Name} did not pass the health check.");
        }
        Console.WriteLine();
    }

    public void AddItem<T>(T item) where T : Item
    {
        Things.Add(item);
        Console.WriteLine($"Added {item.GetType().Name}.");
        Console.WriteLine();
    }

    public void PrintAnimalReport()
    {
        Console.WriteLine("Animal report:");
        foreach (var animal in Animals)
        {
            Console.WriteLine($"{animal.GetType().Name} Id: {animal.Id}; Food: {animal.Food} kg/day");
        }
        Console.WriteLine();
    }

    public void PrintContactZooAnimals()
    {
        Console.WriteLine("Animals suitable for contact:");
        foreach (var animal in Animals)
        {
            if (animal is Herbo { Kindness: > 5 } herbo)
            {
                Console.WriteLine($"{herbo.GetType().Name} Id: {herbo.Id}; Kindness: {herbo.Kindness}");
            }
        }
        Console.WriteLine();
    }

    public void PrintInventoryReport()
    {
        Console.WriteLine("Inventory report:");
        Console.WriteLine("Animals:");
        foreach (var animal in Animals)
        {
            Console.WriteLine($"{animal.GetType().Name} Id: {animal.Id}");
        }
        Console.WriteLine();
        Console.WriteLine("Items:");
        foreach (var thing in Things)
        {
            Console.WriteLine($"{thing.GetType().Name} Id: {thing.Id}");
        }
        Console.WriteLine();
    }
}