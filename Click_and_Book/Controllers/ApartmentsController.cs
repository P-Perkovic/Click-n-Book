using Click_and_Book.Data;
using Click_and_Book.Models;
using Click_and_Book.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Click_and_Book.Controllers
{
    [Authorize]
    public class ApartmentsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public ApartmentsController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var apartmentSearchModel = new ApartmentSearchModel();
            apartmentSearchModel.Categoryes = _context.ApartmentCategories.ToList();
            apartmentSearchModel.CityBlocks = _context.CityBlocks.ToList();
            apartmentSearchModel.FindeApartments = new List<Apartment>();

            return View(apartmentSearchModel);
        }

        public IActionResult Search(ApartmentSearchModel apartmentSearchModel)
        {
            var timeFrom = apartmentSearchModel.Reservation.TimeFrom;
            var timeTo = apartmentSearchModel.Reservation.TimeTo;
            apartmentSearchModel.Categoryes = _context.ApartmentCategories.ToList();
            apartmentSearchModel.CityBlocks = _context.CityBlocks.ToList();
            var reservations = _context.Reservations.Where(r => ((timeFrom > r.TimeFrom && timeFrom < r.TimeTo) ||
                                                                (timeTo > r.TimeFrom && timeTo < r.TimeTo)) &&
                                                                r.IsActive == true).ToList();
            var apartments = _context.Apartments.ToList();
            foreach (var reserv in reservations)
            {
                var apartment = apartments.FirstOrDefault(a => a.Id == reserv.ApartmentId);
                apartments.Remove(apartment);
            }

            var apartmentsSort = apartments.Where(a => a.CityBlockId == apartmentSearchModel.Apartment.CityBlockId &&
                                                      a.MaxPeople == apartmentSearchModel.Apartment.MaxPeople &&
                                                      a.Balcony == apartmentSearchModel.Apartment.Balcony &&
                                                      a.AirConditioner == apartmentSearchModel.Apartment.AirConditioner)
                                          .ToList();

            apartmentsSort.AddRange(apartments.Where(a => a.MaxPeople >= apartmentSearchModel.Apartment.MaxPeople).ToList());

            apartmentSearchModel.FindeApartments = apartmentsSort;
            foreach (var apartment in apartmentSearchModel.FindeApartments)
            {
                apartment.Images = _context.Images.Where(i => i.ApartmentId == apartment.Id).ToList();
                apartment.Owner = _context.Owners.FirstOrDefault(u => u.Id == apartment.OwnerId);
                apartment.Price = (apartmentSearchModel.Reservation.TimeTo.Day - apartmentSearchModel.Reservation.TimeFrom.Day) * apartment.Price;
            }

            return View("Index", apartmentSearchModel);
        }
    }
}
