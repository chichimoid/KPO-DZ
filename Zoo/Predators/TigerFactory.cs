namespace Zoo;

public class TigerFactory : PredatorFactory
{
    public override Tiger Create(int food)
    {
        Tiger tiger = new Tiger(food, Last);
        ++Last;
        return tiger;
    }
}