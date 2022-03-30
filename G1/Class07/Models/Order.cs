using System;

namespace Models
{
    public class Order
    {
        public int OrderNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public OrderStatuses Status { get; set; }

        public Order(int orderNumber, string firstName, string lastName)
        {
            OrderNumber = orderNumber;
            FirstName = firstName;
            LastName = lastName;
            Status = OrderStatuses.Draft;
        }
    }
}
