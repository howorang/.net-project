using Libretto.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libretto.Model
{
    public class LibrettoContext : DbContext
    {
        public LibrettoContext() : base("name=Libretto.Properties.Settings.libretto2ConnectionString")
        {

        }

        public DbSet<Auction> Auctions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
