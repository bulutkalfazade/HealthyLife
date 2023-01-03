using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class IPersonManager : IPersonService
    {
        IPersonDal _personDal;
        public IPersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public double Hesapla(Person person)
        {
            return _personDal.Hesapla(person);
        }
    }
}
