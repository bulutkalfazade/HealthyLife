using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntitityFramework
{
    public class EfPersonDal : IPersonDal
    {
        public double Hesapla(Person person)
        {
            double FatRate = (495 / (1.0324 - (0.19077 * (Math.Log10(person.Waist - person.Neck))) + (0.15456 * (Math.Log10(person.Height))))) - 450;

            return FatRate;

        }
    }
}
