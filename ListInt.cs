using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_type__Generic_collections
{
    public class ListInt
    {
        private int[] _arr;  

        public ListInt()
        {
            _arr = new int[0];  
        }

        public int this[int index]
        {
            get { return _arr[index]; }  
            set { _arr[index] = value; } 
        }

        public void Add(int num)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = num;
        }

        public void AddRange(params int[] nums)
        {
            int oldLength = _arr.Length;
            Array.Resize(ref _arr, oldLength + nums.Length);
            for (int i = 0; i < nums.Length; i++)
            {
                _arr[oldLength + i] = nums[i];
            }
        }

        public bool Contains(int num)
        {
            foreach (int item in _arr)
            {
                if (item == num) return true;
            }
            return false;
        }

        public int Sum()
        {
            int sum = 0;
            foreach (int item in _arr)
            {
                sum += item;
            }
            return sum;
        }

        public void Remove(int num)
        {
            int index = Array.IndexOf(_arr, num);
            if (index >= 0)
            {
                for (int i = index; i < _arr.Length - 1; i++)
                {
                    _arr[i] = _arr[i + 1];
                }
                Array.Resize(ref _arr, _arr.Length - 1);
            }
        }

        public void RemoveRange(params int[] nums)
        {
            foreach (int num in nums)
            {
                Remove(num);
            }
        }

        public override string ToString()
        {
            return string.Join(", ", _arr);
        }
    }

}
