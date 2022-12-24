﻿using Business.Concrete;
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
            user.FirstName = "Kaan";
            user.LastName = "özdopan";
            user.Email = "kaan9942@gmail.com"; 
            user.Password= "12345";
            userManager.Delete(user);
           
            Console.ReadLine();
        }
    }
}
