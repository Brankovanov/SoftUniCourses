namespace Exercise_06_MilitaryElite
{
    //IPrivate interface. Holds the privates salary.
    public interface IPrivate : ISoldier
    {
        double Salary { get; }
    }
}