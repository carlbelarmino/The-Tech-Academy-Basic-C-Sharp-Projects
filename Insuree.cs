using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarInsurance.Models
{
    public class Insuree
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Range(1900, 2100)]
        public int CarYear { get; set; }

        [Required]
        [StringLength (50)]
        public string CarMake { get; set; }

        [Required]
        [StringLength(50)]
        public string CarModel { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int SpeedingTickets { get; set; }

        [Required]
        [StringLength(30)]
        public string CoverageType { get; set; }

        [Column(TypeName = "decimal(918, 2)")]
        public decimal qUOTE { get; set; }
    }
}