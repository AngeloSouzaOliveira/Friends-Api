using BLL.InterfaceGeneric;
using DAL.DataBase;
using DAL.RepositoryGeneric;
using Microsoft.EntityFrameworkCore;
using Model.Friend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.RepositoryFriend
{
    public class RepositoryFriend : RepositoryGenerics<Friend>, IFriend
    {
        private readonly DbContextOptions<ContextBase> _Context;
        public RepositoryFriend()
        {
            _Context = new DbContextOptions<ContextBase>();
        }
    }
}
