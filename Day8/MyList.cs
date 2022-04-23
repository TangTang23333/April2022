using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class MyList<T>
    {

        public List<T> list = new List<T>();
        public void Add(T item)
        {
           list.Add(item);
        }

        public T Remove(int index)
        {
            T res = list[index];
            list.RemoveAt(index);
            return res;
        }

        public bool Contains(T ele)
        {
            return list.Contains(ele);
        }

        public void Clear()
        {
            list.Clear();
        }

        public void InsertAt(T ele, int index)
        {
            List<T> stack = new List<T>();
            
            for (int i = index; index < list.Count; i++)
            {
                int n = list.Count;
                stack.Add(list[n - 1]);
                list.RemoveAt(n-1);
            }

            list.Add(ele);
            for (int i = 0; i < stack.Count; i++)
            {
                list.Add(stack[stack.Count - i-1]);
            }   
        }

        public void DeleteAt(int index)
        {
            list.RemoveAt(index);
        }

        public T Find(int index)
        {
            return list[index];
        }
    }
}
