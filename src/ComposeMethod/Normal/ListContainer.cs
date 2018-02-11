using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposeMethod.Normal
{
    public class ListContainer_N<T>
    {
        private T[] elements = new T[2];

        public bool ReadOnly { get; set; }

        public int Size { get { return elements.Length + 1; } }

        private int _size =  0;

        public void Add(T obj)
        {
            if (!ReadOnly)
            {
                
                int newSize = _size + 1;
                if (newSize >= Size)
                {
                    T[] newElements = new T[Size + 10];
                    for (int i = 0; i < _size; i++)
                        newElements[i] = elements[i];

                    elements = newElements;
                }
                elements[_size++] = obj;
            }
        }
    }
}
