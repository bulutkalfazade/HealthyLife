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
            user.ID = 2;
            user.FirstName = "Baran";
            user.LastName = "Yıldız";
            user.Email = "baranyıldız@icloud.com"; 
            user.Password= "Baran123.";
            userManager.Delete(user);
           
            Console.ReadLine();
        }
    }
}
