using StaticEnumHomeTask.Application.Constants;
using StaticEnumHomeTask.Application.Enums;
using StaticEnumHomeTask.Application.Interfaces;

namespace StaticEnumHomeTask.Application.Services
{
    public class Account : IAccount
    {
        public bool CheckRole(Roles role)
        {
            if (role == Roles.SuperAdmin)return true;
            return false;

        }

        public void Login(string email, string password, Roles role)
        {
            if (email== AccountConst.Email && password==AccountConst.Password)
            {
                if (CheckRole(role))
                {
                    Console.WriteLine(AccountConst.SuccesMessage);
                }
                else
                {
                    Console.WriteLine(AccountConst.NoPermission);
                }

            }
            else
            {
                Console.WriteLine(AccountConst.FailMessage);
            }
        }
    }
}
