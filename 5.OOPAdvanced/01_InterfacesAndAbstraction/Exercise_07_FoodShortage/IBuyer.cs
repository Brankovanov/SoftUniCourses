namespace Exercise_07_FoodShortage
{
    //CIBuyer interface derived from the IEntity interface.
    public interface IBuyer : IEntity
    {
        int Food { get; }
        void BuyFood();
    }
}