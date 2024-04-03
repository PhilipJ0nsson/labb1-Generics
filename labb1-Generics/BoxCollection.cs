using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb1_Generics
{
    internal class BoxCollection : ICollection<Box>
    {
        private List<Box> innerCollection;
        public BoxCollection()
        {
            innerCollection = new List<Box>();
        }

        public bool IsReadOnly { get { return false; } }
        public Box this[int index]
        {
            get { return (Box)innerCollection[index]; }
            set { innerCollection[index] = value; }
        }

        public int Count
        {
            get
            {
                return innerCollection.Count;
            }
        }

        public void Add(Box item)
        {
            if (!Contains(item))
            {
                innerCollection.Add(item);
            }
            else
            {
                Console.WriteLine("This Box with Height {0}, Length {1} and Width {2} is already existing.",
                    item.Height.ToString(), item.Width.ToString(), item.Length.ToString());
         
            }
        }
        public bool Contains(Box item)
        {
            bool found = false;
            foreach (Box b in innerCollection)
            {
                if (b.Equals(item))
                {
                    found = true;
                }
            }
            return found;
        }

        public void Clear()
        {
            innerCollection.Clear();
        }

        public void CopyTo(Box[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Box> GetEnumerator()
        {
            return new BoxEnumerator(this);
        }

        public bool Remove(Box item)
        {
            bool result = false;
            for (int i = 0; i < innerCollection.Count; i++)
            {
                Box currentBox = innerCollection[i];
                if (new BoxSameProp().Equals(currentBox, item))
                {
                    innerCollection.RemoveAt(i);
                    result = true;
                    Console.WriteLine("This Box with Height {0}, Length {1} and Width {2} has been removed.",
                    item.Height.ToString(), item.Width.ToString(), item.Length.ToString());
                    break;
                }
            }
            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new BoxEnumerator(this);
        }
    }
}
