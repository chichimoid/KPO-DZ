namespace Zoo;

public class Item : IInventory
{
    public int Id { get; set; }

    public Item(int id)
    {
        Id = id;
    }
}