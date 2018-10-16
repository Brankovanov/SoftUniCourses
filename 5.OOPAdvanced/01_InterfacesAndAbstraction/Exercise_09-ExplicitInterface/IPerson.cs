namespace Exercise_09_ExplicitInterface
{
    //IPerson interface. Holds person's age and name.
    public interface IPerson
    {
        int Age { get; }
        string Name { get; }

        string GetName();
    }
}