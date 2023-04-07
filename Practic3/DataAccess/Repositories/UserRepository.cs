using DataAccess.Interfaces;
using Internet_Shop__practice_5_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(InternetShopContext context) : base(context) { }
    }
}
