using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposeMethod.Refactoring
{
    public class ListContainer_R<T>
    {
        const int GROUN_COUNT = 10;

        private T[] elements = new T[2];

        public bool ReadOnly { get; set; }

        public int Size { get { return elements.Length + 1; } }

        private int _size = 0;

        public void Add(T obj)
        {
            if (ReadOnly)
                return;

            if (IsCapacity())
                grow();

            elements[_size++] = obj;
        }

        private bool IsCapacity()
        {
            return _size + 1 >= Size;
        }

        private void grow()
        {
            T[] newElements = new T[Size + GROUN_COUNT];
            for (int i = 0; i < _size; i++)
                newElements[i] = elements[i];
            elements = newElements;
        }
    }
}
