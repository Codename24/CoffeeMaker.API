using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoffeeMaker.DataAccess.Models
{
    public class CoffeeMachine : BaseModel
    {
        [Required]
        [StringLength(30)]
        public string SerialNumber { get; set; }
        [Required]
        public int TypeId { get; set; }
        [Required]
        [StringLength(30)]
        public string ServiceNumber { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string ResponsibleEmployee { get; set; }
        ICollection<MachineType> MachineTypes { get; set; }
        ICollection<ServiceDetails> ServiceDetails { get; set; }
    }
}
