using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using eUseControl.Domain.Entities.Models;

namespace eUseControl.Domain.Context
{
    public class UserContext : DbContext
    {
        public UserContext() : base("name=eUseControl") // string de conexiune definit în Web.config
        {
        }

        public virtual DbSet<User> Users { get; set; }
    }
}

