using Car_Rental_Application.User_Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Rental_Application.Models
{
    public class Agreement
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Car Id is a required field.")]
        public int CarId { get; set; }

        [Required(ErrorMessage = "Booking Date is a required field.")]
        public DateTime BookingDate { get; set; }

        [Required(ErrorMessage = "Rental Duration is a required field.")]
        public int RentalDuration { get; set; }

        [Required(ErrorMessage = "Total Cost is a required field.")]
        public decimal TotalCost { get; set; }

        [Required(ErrorMessage = "User Id is a required field.")]
        public string UserId { get; set; }

        public AgreementStatus Status { get; set; }

        //[Required]
        //[ForeignKey("CarId")]
        //public Car Car { get; set; }
    }

    public enum AgreementStatus
    {
        Pending,
        Accepted,
        Completed
    }
}
