namespace Reflection
{
    public interface IJob
    {
        string Position { get; set; }
        double Salary { get; set; }

        string GoToWork();
    }
}
