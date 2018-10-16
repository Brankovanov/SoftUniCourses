namespace Exercise_07_FoodShortage
{
    //ICitizen interface derived from the IBuyer interface.
    public interface ICitizen : IBuyer
    {
        string Birthdate { get; }
        string Id { get; }
    }
}