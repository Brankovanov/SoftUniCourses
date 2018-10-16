namespace Exercise_07_FoodShortage
{
    //IRebel interface derived from IBuyer interface.
    public interface IRebel : IBuyer
    {
        string Group { get; }
    }
}