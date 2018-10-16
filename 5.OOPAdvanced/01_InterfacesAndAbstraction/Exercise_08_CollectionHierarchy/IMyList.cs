namespace Exercise_08_CollectionHierarchy
{
    //IMyList interface that is derived by IAddRemoveCollection interface.
    public interface IMyList : IAddRemoveCollection
    {
        int Used { get; }
    }
}