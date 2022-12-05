using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitExplicitGenerics
{
    class ListInt
    {
        int[] _arr;
        public int Length { get => _arr.Length; }
        public ListInt()
        {
            _arr = new int[0];
        }
        public ListInt(int length)
        {
            _arr = new int[length];
        }
        public ListInt(int[] _arr)
        {
            this._arr = _arr;
        }
        public int this[int index]
        {
            get
            {
                if (index < _arr.Length)
                {
                    return _arr[index];
                }
                throw new Exception();
            }
            set
            {
                if (index < _arr.Length)
                {
                    _arr[index] = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }
        public int this[string key]
        {
            get
            {
                return key.Length;
            }
        }
        public void Add(int num)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = num;
        }
        //public void Add(params int[] num)
        //{
        //    Array.Resize(ref _arr, _arr.Length + num.Length);
        //    for (int i = _arr.Length - num.Length; i < _arr.Length; i++)
        //    {
        //        _arr[i] = num[i - num.Length - 1];
        //    }
        //}
        public void Add(params int[] num)
        {
            Array.Resize(ref _arr, _arr.Length + num.Length);
            for (int i = _arr.Length - num.Length; i < _arr.Length; i++)
            {
                _arr[i] = num[i - num.Length - 1];
            }
        }
        public void Print()
        {
            foreach (var item in _arr)
            {
                Console.WriteLine(item);
            }
        }
    }
    class ListString{
        string[] _arr;
        public int Length { get => _arr.Length; }
        public ListString()
        {
            _arr = new string[0];
        }
        public ListString(int length)
        {
            _arr = new string[length];
        }
        public ListString(string[] _arr)
        {
            this._arr = _arr;
        }
        public string this[int index]
        {
            get
            {
                if (index < _arr.Length)
                {
                    return _arr[index];
                }
                throw new Exception();
            }
            set
            {
                if (index < _arr.Length)
                {
                    _arr[index] = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }
        public void Add(string num)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = num;
        }
        //public void Add(params string[] num)
        //{
        //    Array.Resize(ref _arr, _arr.Length + num.Length);
        //    for (string i = _arr.Length - num.Length; i < _arr.Length; i++)
        //    {
        //        _arr[i] = num[i - num.Length - 1];
        //    }
        //}
        public void Add(params string[] num)
        {
            Array.Resize(ref _arr, _arr.Length + num.Length);
            for (int i = _arr.Length - num.Length; i < _arr.Length; i++)
            {
                _arr[i] = num[i - num.Length - 1];
            }
        }
        public void Prstring()
        {
            foreach (var item in _arr)
            {
                Console.WriteLine(item);
            }
        }
    }
    class ListObject
    {
        object[] _arr;
        public int Length { get => _arr.Length; }
        public ListObject()
        {
            _arr = new object[0];
        }
        public object this[int index]
        {
            get
            {
                if (index < _arr.Length)
                {
                    return _arr[index];
                }
                throw new Exception();
            }
            set
            {
                if (index < _arr.Length)
                {
                    _arr[index] = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }
        public void Add(object num)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = num;
        }
    }
}
