namespace Zoo;

public class PredatorFactory : InventoryFactory
{
    public virtual Predator Create(int food)
    {
        Predator predator = new Predator(food, Last);
        ++Last;
        return predator;
    }
}