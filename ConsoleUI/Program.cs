using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitityFramework;
using Entities.Abstract;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IUserDal userDal = new EfUserDal();
            UserManager userManager = new UserManager(userDal);
            User user = new User();
            user.ID=1;
            user.FirstName = "Bulut";
            user.LastName = "Kalfazade";
            user.Email = "bulutkalfazade@icloud.com"; 
            user.Password= "12345";
            userManager.Delete(user);
           
            Console.ReadLine();//Burda kaldım.
        }
    }
}
