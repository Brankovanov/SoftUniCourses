namespace Exercise_02_Ferrari
{
    //Parent interface that that holds ferrarys model and driver. Also the brake and gas functionality.
    public interface ICar
    {
        string Model { get; }
        string Driver { get; }

        string Brake();
        string Gas();
    }
}