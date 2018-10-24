using System;

namespace Lab_02_GenericArrayCreator
{
    public class SetUp
    {
        static void Main()
        {
            var strings = ArrayCreator<string>.Create(5, "Pesho");
            var integers = ArrayCreator<int>.Create(10, 33);
        }
    }
}