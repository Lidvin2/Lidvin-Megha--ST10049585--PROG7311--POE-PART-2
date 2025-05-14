using System.ComponentModel.DataAnnotations;

namespace PROG7311_POEPART2.Models
{
    public class Farmer
    {
        [Key]
        public int FarmerID { get; set; }
        [Required]
        public string FarmerName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int Number {  get; set; }
        [Required]
        public string Location { get; set; }
    }
}
