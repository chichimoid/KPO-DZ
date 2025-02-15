namespace Zoo;

public class TableFactory : ItemFactory
{
    public override Table Create()
    {
        Table table = new(Last);
        ++Last;
        return table;
    }
}