using System;
using System.ComponentModel.DataAnnotations;

namespace CoffeeMaker.DataAccess.Models
{
    public class ServiceDetails : BaseModel
    {
        [Required]
        public int CoffeeMachineId { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ServiceDate { get; set; }
        [Required]
        public string ServiceEmployeeId { get; set; }
        public CoffeeMachine CoffeeMachine { get; set; }
    }
}
