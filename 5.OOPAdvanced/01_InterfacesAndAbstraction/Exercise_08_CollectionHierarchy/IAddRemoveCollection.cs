namespace Exercise_08_CollectionHierarchy
{
    //IAddRemoveCollection interface that is derived by IAddCollection interface.
    public interface IAddRemoveCollection : IAddCollection
    {
        string Remove();
    }
}