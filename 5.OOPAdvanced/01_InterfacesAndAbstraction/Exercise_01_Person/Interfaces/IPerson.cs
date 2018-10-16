namespace Exercise_01_Person.Interface
{
    //Parent interface that holds the citizen's name and age.
    public interface IPerson
    {
        string Name { get; }
        int Age { get; }
    }
}