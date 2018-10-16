using System.Collections.Generic;

namespace Exercise_06_MilitaryElite
{
    //ICommando interface. It holds a list of missions.
    public interface ICommando : ISpecialisedSoldier
    {
        List<Mission> Missions { get; }
    }
}