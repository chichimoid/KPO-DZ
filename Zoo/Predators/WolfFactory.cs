namespace Zoo;

public class WolfFactory : PredatorFactory
{
    public override Wolf Create(int food)
    {
        Wolf wolf = new Wolf(food, Last);
        ++Last;
        return wolf;
    }
}