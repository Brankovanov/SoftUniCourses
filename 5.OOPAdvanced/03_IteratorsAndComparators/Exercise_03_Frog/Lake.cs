using System.Collections;
using System.Collections.Generic;

namespace Exercise_03_Frog
{
    //Lake class that holds the lakes characteristics and traverse logic.
    public class Lake : IEnumerable<int>
    {
        private List<int> stones = new List<int>();
        private List<int> path = new List<int>();
        private List<int> returnPath = new List<int>();

        public List<int> Path
        {
            get
            {
                return this.path;
            }
        }

        public List<int> ReturnPath
        {
            get
            {
                return this.returnPath;
            }
        }

        public List<int> Stones
        {
            get
            {
                return this.stones;
            }
        }

        public string JumpingFrog()
        {
            return GetEnumerator().ToString();
        }

        public Lake(int[] path)
        {
            this.stones.AddRange(path);
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new Jump(this.stones, this.Path, this.ReturnPath);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Jump : IEnumerator<int>
    {
        private List<int> localPath;
        private List<int> path;
        private List<int> returnPath;

        public int Current => throw new System.NotImplementedException();

        object IEnumerator.Current => throw new System.NotImplementedException();

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public bool MoveNext()
        {
            var index = 0;

            while (index < this.localPath.Count)
            {
                if (index == 0 || index % 2 == 0)
                {
                    this.returnPath.Add(this.localPath[index]);
                }
                else if (index % 2 != 0)
                {
                    this.path.Add(this.localPath[index]);
                }

                index += 1;
            }

            return false;
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }

        public Jump(List<int> path, List<int> forward, List<int> back)
        {
            this.localPath = path;
            this.path = forward;
            this.returnPath = back;
        }

        public override string ToString()
        {
            MoveNext();
            var list = this.path;
            list.Reverse();
            this.returnPath.AddRange(list);
            return string.Join(" ", this.returnPath);
        }
    }
}