using System.Linq;

namespace Exercise_02_CustomList
{
    //Orders the elements in the generic collection.
    public class Sorter
    {
        public void Sort(GenericList<string> newGenericList)
        {
            var sortedList = newGenericList.List.OrderBy(e=>e).ToList();
            newGenericList.List = sortedList;
        }
    }
}