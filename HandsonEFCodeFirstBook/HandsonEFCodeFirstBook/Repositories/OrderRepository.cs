using HandsonEFCodeFirstBook.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonEFCodeFirstBook.Repositories
{
    internal class OrderRepository
    {
        public MyContextDB db = new MyContextDB();
        public void AddOrder(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
        }
    }
}
