namespace Lab_02_Cars
{
    //Parent interface to Seat and Tesla classes.
    public interface ICar
    {
        string Model { get; }
        string Color { get; }
        string Start();
        string Stop();
    }
}