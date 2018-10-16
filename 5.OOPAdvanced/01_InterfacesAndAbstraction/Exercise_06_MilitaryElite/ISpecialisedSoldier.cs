namespace Exercise_06_MilitaryElite
{
    //ISpecializedSoldier interface. Holds the soldie. Derived from the IPrivate interface.
    public interface ISpecialisedSoldier : IPrivate
    {
        string Corps { get; }
    }
}