namespace Exercise_06_MilitaryElite
{
    //IMission interface. Holds missions codename and state.
    public interface IMission
    {
        string CodeName { get; }
        string State { get; }

        void CompleteMission();
    }
}