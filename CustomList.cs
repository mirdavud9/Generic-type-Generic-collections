using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_type__Generic_collections
{
    public class CustomList<T>
    {
        private T[] _arr;
        public int Count { get; private set; }  
        public int Capacity { get; private set; } 

        public CustomList()
        {
            _arr = new T[4];  
            Capacity = 4;
        }

        public T this[int index]
        {
            get { return _arr[index]; }
            set { _arr[index] = value; }
        }

        public void Add(T num)
        {
            if (Count == Capacity)
            {
                Capacity *= 2;
                Array.Resize(ref _arr, Capacity);  
            }
            _arr[Count++] = num;  
        }

        public void AddRange(params T[] nums)
        {
            foreach (var num in nums)
            {
                Add(num);  
            }
        }

        public bool Contains(T num)
        {
            foreach (var item in _arr)
            {
                if (item.Equals(num)) return true;
            }
            return false;
        }

        public int Sum()
        {
            if (typeof(T) == typeof(int))
            {
                int sum = 0;
                foreach (var item in _arr)
                {
                    sum += Convert.ToInt32(item);
                }
                return sum;
            }
            throw new InvalidOperationException("Sum methodu yalnız int tipləri üçün işləyir.");
        }

        public void Remove(T num)
        {
            int index = Array.IndexOf(_arr, num);
            if (index >= 0)
            {
                for (int i = index; i < Count - 1; i++)
                {
                    _arr[i] = _arr[i + 1];
                }
                Count--;
            }
        }

        public void RemoveRange(params T[] nums)
        {
            foreach (var num in nums)
            {
                Remove(num);
            }
        }

        public override string ToString()
        {
            return string.Join(", ", _arr.Take(Count));  
        }
    }

}
