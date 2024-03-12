using StaticEnumHomeTask.Application.Enums;

namespace StaticEnumHomeTask.Application.Interfaces
{
    public interface IAccount
    {
        void Login(string email, string password,Roles role);
        bool CheckRole(Roles role);
    }
}
