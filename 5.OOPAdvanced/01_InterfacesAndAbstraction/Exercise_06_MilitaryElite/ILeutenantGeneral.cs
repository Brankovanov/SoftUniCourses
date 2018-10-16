using System.Collections.Generic;

namespace Exercise_06_MilitaryElite
{
    //ILeutenant interface. Holds a list with the privates the leutenanat commadn.
    public interface ILeutenantGeneral : IPrivate
    {
        List<ISoldier> Privates { get; }
    }
}