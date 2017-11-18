using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DI_BL_Model
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime DateOfJoining { get; set; }
        [Required]
        public string Grade { get; set; }
        [Required]
        public double Salary { get; set; }
        public string Contact { get; set; }
    }
}
