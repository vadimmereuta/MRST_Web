using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.Domain.Entities.Models;

namespace eUseControl.BusinessLogic.Interfaces
{
    public interface ISession
    {
        User Login(string email, string password);
        bool RegisterUser(string username, string email, string password);
    }
}

