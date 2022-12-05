using System;
using System.Collections.Generic;
namespace ImplicitExplicitGenerics
{
    class GenericList<T> where T:class
    {
        T[] _arr;
        int _index;
        private int _count;
        public int Count { get => _count; }
        public int Capacity { get; set; } = 2;
        public GenericList()
        {
            _count = 0;
            _arr = new T[16];
        }
        public void Add(T item)
        {
            //Resize();
            if (Count == _arr.Length)
            {
                Resize();
            }
            //Array.Resize(ref _arr,_arr.Length+1);
            _arr[Count] = item;
            _count++;
        }
        void Resize()
        {
            _index++;
            Array.Resize(ref _arr, _arr.Length * Capacity);
            Console.WriteLine(_index + ". Array Created");
        }
        public T this[int index]
        {
            get 
            {
                if (index < Count)
                {
                    return _arr[index]; 
                }
                throw new IndexOutOfRangeException();
            }
        }
    }
}
