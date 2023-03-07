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

        public  IResult Add (User user)
        {
            _userDal.Add(user);
            return new SuccessResult();
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }
    }
}
