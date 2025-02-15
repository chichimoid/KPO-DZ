namespace Zoo;

public class ComputerFactory : ItemFactory
{
    public override Computer Create()
    {
        Computer computer = new(Last);
        ++Last;
        return computer;
    }
}