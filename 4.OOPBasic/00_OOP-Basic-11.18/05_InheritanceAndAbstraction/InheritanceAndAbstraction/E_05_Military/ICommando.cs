

using System.Collections.Generic;

namespace E_05_Military
{
    interface ICommando
    {
        Dictionary<string,string> Missions { get; set; }

        void CompleteMission();
    }
}
