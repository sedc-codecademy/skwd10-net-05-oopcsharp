using System;
using Models;

namespace EnumExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order o1 = new Order(1, "Risto", "Panchevski");
            Order o2 = new Order(2, "Petko", "Petkovski");
            o2.Status = OrderStatuses.Payed;
            Order o3 = new Order(3, "Bob", "Bobsky");

            Order[] orders = new[] { o1, o2, o3 };

            foreach(Order o in orders)
            {
                if(o.Status == OrderStatuses.Payed)
                {
                    o.Status = OrderStatuses.InProgress;
                }
            }
        }
    }
}
