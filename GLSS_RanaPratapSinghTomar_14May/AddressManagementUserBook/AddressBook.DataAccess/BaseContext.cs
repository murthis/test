using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Threading;

namespace AddressBook.DataAccess
{
    public class BaseContext<TContext> : DbContext where TContext : DbContext
    {



        static BaseContext()
        {
            Database.SetInitializer<TContext>(null);
        }

        protected BaseContext()
            : base("name=UserContext")
        {
            User = Thread.CurrentPrincipal;
        }

        public object User { get; private set; }
    }
}
