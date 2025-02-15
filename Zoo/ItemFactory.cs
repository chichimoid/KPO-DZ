namespace Zoo;

public class ItemFactory : InventoryFactory
{
    public virtual Item Create()
    {
        Item item = new(Last);
        ++Last;
        return item;
    }
}