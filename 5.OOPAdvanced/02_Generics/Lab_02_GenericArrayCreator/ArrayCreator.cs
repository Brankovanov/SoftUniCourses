namespace Lab_02_GenericArrayCreator
{
    //Generic class able to create an array with given lenght and type.
    public class ArrayCreator<T>
    {
        public static T[] Create(int lenght, T item)
        {
            var genericArray = new T[lenght];

            for (var index = 0; index < lenght; index++)
            {
                genericArray[index] = item;
            }

            return genericArray;
        }
    }
}