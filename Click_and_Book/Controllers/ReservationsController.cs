using Click_and_Book.Data;
using Click_and_Book.Models;
using Click_and_Book.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Click_and_Book.Controllers
{
    public class ReservationsController : Controller
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        public ReservationsController(UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Reserve(Reservation reservation)
        {
            reservation.ClientId = _userManager.GetUserId(User);
            reservation.IsActive = true;
            reservation.IsCancel = false;

            _context.Add(reservation);
            _context.SaveChanges();

            return View();
        }
    }
}
