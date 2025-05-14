using System.ComponentModel.DataAnnotations;

namespace PROG7311_POEPART2.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Product { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int Price { get; set; }
    }
}
