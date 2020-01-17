namespace Lab_02_Cars
{
    public interface ICar
    {
        string Model { get; set; }
        string Color { get; set; }

        void Start();
        void Stop();
    }
}
