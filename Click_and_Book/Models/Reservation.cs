using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Click_and_Book.Models
{
    public class Reservation
    {
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
        public DateTime TimeFrom { get; set; }
        public DateTime TimeTo { get; set; }
        public bool IsActive { get; set; }
        public bool IsCancel { get; set; }
    }
}
