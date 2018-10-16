namespace Exercise_09_ExplicitInterface
{
    //IResident interface. Hold the residents country of origin and name.
    public interface IResident
    {
        string Country { get; }
        string Name { get; }

        string GetName();
    }
}