using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class MyStack<T>
    {
        private List<T> Stack = new List<T> ();
      
        public int Count()
        {
            return Stack.Count;
        }

        internal void Push(T item)
        {
            Stack.Add(item);
        }

        public T Pop()
        {   
            T last = Stack[Stack.Count - 1];
            Stack.RemoveAt(Stack.Count - 1);
            return last;
        }

      


    }
}
