using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Click_and_Book.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public Client Client { get; set; }
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
        [TimeFromValidated]
        [FromNow]
        [Required(ErrorMessage = "Please enter check-in time")]
        public DateTime TimeFrom { get; set; }
        [FromNow]
        [Required(ErrorMessage = "Please enter check-out time")]
        public DateTime TimeTo { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public bool IsCancel { get; set; }
    }

    #region Validation Atributes
    public class FromNowAttribute : ValidationAttribute
    {
        public FromNowAttribute() { }

        public string GetErrorMessage() => $"Date must be set past {DateTime.Now.ToString("dd-MM-yyyy")}";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var date = (DateTime)value;

            if (DateTime.Compare(date, DateTime.Now) < 0) 
                return new ValidationResult(GetErrorMessage());
            else 
                return ValidationResult.Success;
        }
    }

    public class TimeFromValidated : ValidationAttribute
    {
        protected override ValidationResult
                IsValid(object value, ValidationContext validationContext)
        {
            var model = (Models.Reservation)validationContext.ObjectInstance;
            DateTime EndDate = Convert.ToDateTime(model.TimeTo);
            DateTime StartDate = Convert.ToDateTime(value);

            if (StartDate > EndDate)
                return new ValidationResult("Check in date must lower than check out date");
            else
                return ValidationResult.Success;
        }
    }
    #endregion
}
