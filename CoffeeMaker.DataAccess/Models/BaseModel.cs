using System.ComponentModel.DataAnnotations;

namespace CoffeeMaker.DataAccess.Models
{
    public class BaseModel
    {
        [Required]
        public int Id { get; set; }
    }
}
