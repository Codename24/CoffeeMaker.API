using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

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
        ICollection<MachineType> MachineTypes { get; set; }
        ICollection<ServiceDetails> ServiceDetails { get; set; }
    }
}
