namespace Zoo;

public class Herbo : Animal
{
    /// <summary>
    /// Kindness from 0 to 10.
    /// </summary>
    public int Kindness { get; set; } = 0;
    public Herbo() {}
    public Herbo(int food, int id, int kindness) : base(food, id)
    {
        if (kindness < 0 || kindness > 10) throw new ArgumentException("Kindness must be between 0 and 10");
        Kindness = kindness;
    }

    public bool IsContact()
    {
        return Kindness > 5;
    }
}