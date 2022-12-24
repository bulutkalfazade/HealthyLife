using Business.Concrete;
using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }


        public void Add(User user)
        {
            

            if(user.FirstName.Length < 2)
            {
                Console.WriteLine("Hatayi bulduk");
            }

            else
            {
                _userDal.Add(user);
                Console.WriteLine(user.FirstName+" added");
            }

        }


        public void Delete(User user)
        {
            _userDal.Delete(user); 
        }
    }
}
