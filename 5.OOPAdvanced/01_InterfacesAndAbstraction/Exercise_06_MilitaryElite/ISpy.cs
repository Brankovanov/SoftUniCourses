namespace Exercise_06_MilitaryElite
{
    //ISpy interface. Holds the spy code. It is also derived from ISoldier interface.
    public interface ISpy : ISoldier
    {
        int Code { get; }
    }
}