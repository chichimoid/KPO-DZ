using System.Runtime.InteropServices.JavaScript;

namespace Zoo;

public class Animal : IAlive, IInventory
{
    public int Food {get; set;} = 0;
    public int Id {get; set;} = 0;

    public Animal() {}

    public Animal(int food, int id)
    {
        Food = food;
        Id = id;
    }
}