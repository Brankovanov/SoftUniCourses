namespace Exercise_06_MilitaryElite
{
    //IRepair interface. Holds the name of the proken prooza amd 
    public interface IRepair
    {
        string PartName { get; }
        int HoursWork { get; }
    }
}