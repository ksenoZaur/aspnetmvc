using System;

namespace ControllersBasics.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public int BookId { get; set; }
        public DateTime DateBuy { get; set; }
    }
}