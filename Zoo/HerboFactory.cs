namespace Zoo;

public class HerboFactory : InventoryFactory
{
    public virtual Herbo Create(int food, int kindness)
    {
        Herbo herbo = new Herbo(food, Last, kindness);
        Last++;
        return herbo;
    }
}