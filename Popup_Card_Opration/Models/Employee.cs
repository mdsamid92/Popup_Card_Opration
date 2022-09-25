using System.ComponentModel.DataAnnotations;

namespace Popup_Card_Opration.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? City { get; set; }
    }
}
