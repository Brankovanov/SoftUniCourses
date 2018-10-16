namespace Exercise_06_MilitaryElite
{
    //ISoldier interface. Holds its id, first name, last names.
    public interface ISoldier
    {
        string Id { get; }
        string FirstName { get; }
        string LastName { get; }
    }
}