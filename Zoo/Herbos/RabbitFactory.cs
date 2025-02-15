namespace Zoo;

public class RabbitFactory : HerboFactory
{
    public override Rabbit Create(int food, int kindness)
    {
        Rabbit rabbit = new Rabbit(food, Last, kindness);
        Last++;
        return rabbit;
    }
}