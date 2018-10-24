using System;

namespace Lab_03_GenericScale
{
    //Generic class able to compare to objects of given type.
    public class Scale<T> where T : IComparable
    {
        private T left;
        private T right;

        public T Left
        {
            get
            {
                return this.left;
            }
            set
            {
                this.left = value;
            }
        }

        public T Right
        {
            get
            {
                return this.right;
            }
            set
            {
                this.right = value;
            }
        }

        public Scale(T left, T right)
        {
            this.Left = left;
            this.Right = right;
        }

        public T GetHevier()
        {
            if (this.left.CompareTo(right) > 0)
            {
                return this.left;
            }

            if (this.right.CompareTo(left) > 0)
            {
                return this.right;
            }

            return default(T);
        }
    }
}