namespace CoffeeMaker.BusinessLogic.Models
{
    public class CoffeeMachineDTO : BaseEntity
    {
        public string SerialNumber { get; set; }
        public int TypeId { get; set; }        
        public string ServiceNumber { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string ResponsibleEmployee { get; set; }
    }
}
