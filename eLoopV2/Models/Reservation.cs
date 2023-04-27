using System;
using System.ComponentModel.DataAnnotations;

namespace eLoopV2.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public int CarId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public bool IsApproved { get; set; }

        public bool IsCheckedOut { get; set; }

        public bool IsCheckedIn { get; set; }

        public ElectricCar? Car { get; set; }

        public string? CustomerName { get; set; }

        public string? CustomerEmail { get; set; }

        public ElectricCar? ElectricCar { get; set; }
        public List<Reservation> Reservations { get; set; }

    }




}
