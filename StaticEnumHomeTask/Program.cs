﻿using StaticEnumHomeTask.Application.Enums;
using StaticEnumHomeTask.Application.Services;

namespace StaticEnumHomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Email daxil edin:");
            string email=Console.ReadLine();

            Console.WriteLine("Password daxil edin:");
            string password = Console.ReadLine();



            Account account = new();
            account.Login(email, password, Roles.SuperAdmin);
        }
    }
}