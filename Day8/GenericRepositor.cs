using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{   public class Test
    {
        public int ID;
        public string Name;

        public Test(int id, string name){
            ID = id;
            Name = name;
            }

    }
    internal class GenericRepositor<T>: IRepositor<T> where T: Test
    {
        
        public Dictionary<int, T> dict = new Dictionary<int, T> { };


        public void Add(T item)
        {
            dict[item.ID] = item;
        }

        public void Remove(T item)
        {
            foreach (KeyValuePair <int , T> pair in dict)
            {
                if (pair.Value == item)
                {
                    dict.Remove(pair.Key);
                    return;
                }
            }
        }
        public void Save()
        {
            foreach (KeyValuePair<int, T> pair in dict)
            { Console.Write(pair.Value.Name);
                Console.Write("    ");
            }

            Console.WriteLine();
        }

        public IEnumerable<T> GetAll()
        {
            return dict.Values;
        }


        public T GetById(int id)
        {
            return dict[id];
        }

    }

    interface IRepositor<T> where T : class
    {
        public void Add(T item);


        public void Remove(T item);

        public void Save();


        public IEnumerable<T> GetAll();


        public T GetById(int id);
       
    }
}
