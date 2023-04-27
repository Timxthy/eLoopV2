using System.ComponentModel.DataAnnotations;

namespace eLoopV2.Models
{
    public class Location
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string State { get; set; }

        [StringLength(10)]
        public string ZipCode { get; set; }
    }
}
