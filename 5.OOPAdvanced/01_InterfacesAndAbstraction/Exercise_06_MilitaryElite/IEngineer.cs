using System.Collections.Generic;

namespace Exercise_06_MilitaryElite
{
    //IEngineer interface. holds the engineers' list with repairs.
    public interface IEngineer : ISpecialisedSoldier
    {
        List<Repair> Repairs { get; }
    }
}