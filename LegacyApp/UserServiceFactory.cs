using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyApp
{
    public static class UserServiceFactory
    {
        public static UserService CreateUserService()
        {
            IClientRepository clientRepository = new ClientRepository();
            IUserCreditService userCreditService = new UserCreditService();
            return new UserService(clientRepository, userCreditService);
        }
    }
}