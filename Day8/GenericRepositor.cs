using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class GenericRepositor<T> where T: class
    {
        


    }

    interface IRepositor<T>
    {
        void Add(T item)
        {

        }

        void Remove(T item)
        {

        }
        void Save()
        {

        }

        IEnumerable<T> GetAll()
            {

            }

        T GetById(int id)
        {

        }
    }
}
