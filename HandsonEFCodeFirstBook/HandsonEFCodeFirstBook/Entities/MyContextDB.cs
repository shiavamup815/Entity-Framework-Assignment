using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonEFCodeFirstBook.Entities
{
    internal class MyContextDB:DbContext
    {
        public MyContextDB():base("name=BookDBConn")
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
