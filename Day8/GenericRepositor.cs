using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{   public class Entity
    {
        public int ID;
        public string Name;

        public Entity(int id, string name){
            ID = id;
            Name = name;
            }

    }
    internal class GenericRepositor<T>: IRepositor<T> where T: Entity
    {
        
        public List<T> list = new List<T>();


        public void Add(T item)
        {
            list.Add(item);
        }

        public void Remove(T item)
        {
            foreach ( T t in list)
            {
                if (t == item)
                {
                    list.Remove(t);
                    return;
                }
            }
        }
        public void Save()
        {

            // not sure what this action is for , i just print
            foreach (T t in list)
            { Console.Write("{t.ID} + {t.Name}");
                Console.Write("    ");
            }

            Console.WriteLine();
        }

        public IEnumerable<T> GetAll()
        {
            return list.AsEnumerable();
        }


        public T GetById(int id)
        {   
            foreach (T t in list)
            {
                if (t.ID == id)
                {
                    return t;
                }
            }

            return null;
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
