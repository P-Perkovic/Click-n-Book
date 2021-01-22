using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Click_and_Book.Models
{
    public class Apartment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int NumBeds { get; set; }
        public int NumRooms { get; set; }
        public int MaxPeople { get; set; }
        public int NumStars { get; set; }
        public int BuildYear { get; set; }
        public bool Balconiy { get; set; }
        public bool AirConditioner { get; set; }
        public ApartmentCategory Category { get; set; }
        public Owner Owner { get; set; }
    }
}
