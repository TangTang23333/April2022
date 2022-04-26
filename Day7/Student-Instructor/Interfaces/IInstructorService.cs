using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Class.Interfaces
{
    internal interface IInstructorService : IPersonService
    {
       new decimal  GetSalary();



    }

}
