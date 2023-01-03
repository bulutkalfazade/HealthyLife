using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Person:IEntity
    {
        public int PersonID { get; set; }
        public int Height { get; set; }
        public int Neck { get; set; }
        public int Waist { get; set; }
        public int Hip { get; set; }
        public int Gender { get; set; }
    }
}
