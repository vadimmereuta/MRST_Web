using eUseControl.BusinessLogic.Interfaces;
using eUseControl.Domain.Entities.User;

namespace eUseControl.BusinessLogic
{
    public class SessionBL : ISession
    {
        public UDbTable Login(string email, string password)
        {
            // aici va fi logica de verificare în baza de date
            if (email == "admin@test.com" && password == "admin")
            {
                return new UDbTable { Email = email, Role = "Admin" };
            }

            return null;
        }

        public bool Logout(string sessionId)
        {
            // logica de logout (ștergere sesiune din cache/db etc.)
            return true;
        }
    }
}
