using Microsoft.Extensions.DependencyInjection;

namespace Zoo;

class Program
{
    private static void Main()
    {
        var zooServiceProvider = ZooServiceProviderFactory.CreateServiceProvider();
        
        var zoo = zooServiceProvider.GetRequiredService<Zoo>();

        var rabbitFactory = zooServiceProvider.GetRequiredService<RabbitFactory>();
        var monkeyFactory = zooServiceProvider.GetRequiredService<MonkeyFactory>();
        var tigerFactory = zooServiceProvider.GetRequiredService<TigerFactory>();
        var wolfFactory = zooServiceProvider.GetRequiredService<WolfFactory>();
        var computerFactory = zooServiceProvider.GetRequiredService<ComputerFactory>();
        var tableFactory = zooServiceProvider.GetRequiredService<TableFactory>();
        
        var rabbit = rabbitFactory.Create(4, 8);
        var monkey = monkeyFactory.Create(9, 3);
        var tiger = tigerFactory.Create(15);
        var wolf1 = wolfFactory.Create(10);
        var wolf2 = wolfFactory.Create(12);
        var computer = computerFactory.Create();
        var table = tableFactory.Create();
        
        zoo.AddAnimal(rabbit);
        zoo.AddAnimal(monkey);
        zoo.AddAnimal(tiger);
        zoo.AddAnimal(wolf1);
        zoo.AddAnimal(wolf2);
        zoo.AddItem(computer);
        zoo.AddItem(table);
        
        zoo.PrintAnimalReport();
        zoo.PrintContactZooAnimals();
        zoo.PrintInventoryReport();
    }
}