using eUseControl.BusinessLogic.Interfaces;
using eUseControl.Domain;
using eUseControl.Domain.Entities;
using eUseControl.Domain.Entities.Models;
using System.Linq;

namespace eUseControl.BusinessLogic
{

    public class SessionBL : ISession
    {
        public User Login(string email, string password)
        {
            using (var db = new AppDbContext())
            {
                return db.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            }
        }
        public bool RegisterUser(string username, string email, string password)
        {
            using (var db = new AppDbContext())
            {
                if (db.Users.Any(u => u.Email == email))
                    return false;

                var user = new User
                {
                    Username = username,
                    Email = email,
                    Password = password,
                    Role = "User"
                };

                db.Users.Add(user);
                db.SaveChanges();
                return true;
            }
        }

    }

}
