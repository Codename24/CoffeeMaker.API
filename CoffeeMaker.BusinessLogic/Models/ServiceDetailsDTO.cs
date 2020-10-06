using System;

namespace CoffeeMaker.BusinessLogic.Models
{
    public class ServiceDetailsDTO
    {
        public int CoffeeMachineId { get; set; }
        public DateTime ServiceDate { get; set; }
        public string ServiceEmployeeId { get; set; }
        public string CoffeeMachineName { get; set; }
    }
}
