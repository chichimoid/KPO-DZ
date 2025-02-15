namespace Zoo;

public class MonkeyFactory : HerboFactory
{
    public override Monkey Create(int food, int kindness)
    {
        Monkey monkey = new Monkey(food, Last, kindness);
        Last++;
        return monkey;
    }
}