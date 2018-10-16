namespace Exercise_04_BorderControl_
{
    //IEntity interface parent to the Citizen and Robot classes.
    public interface IEntity
    {
        string Designation { get; }
        string Id { get; }
    }
}