using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Click_and_Book.Models
{
    public class Owner : IdentityUser
    {
        public List<Apartment> Apartments { get; set; }
    }
}
