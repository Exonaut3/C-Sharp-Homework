﻿namespace BurgerApp.Domain
{
    public class Order : BaseEntity
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public bool IsDelivered { get; set; }
        public List<Burger> Burgers { get; set; }
        public string Location { get; set; }

        public Order(int id,string fullName, string address, bool isDelivered, List<Burger> burgers, string location)
        {
            Id = id;
            FullName = fullName;
            Address = address;
            IsDelivered = isDelivered;
            Burgers = burgers;
            Location = location;
        }
        public Order()
        {

        }
    }
}
