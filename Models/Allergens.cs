using System.ComponentModel.DataAnnotations;

namespace snscz_api.Models
{
    public class Allergens
    {
        [Key]
        public int Id { get; set; }
        public string AllergenName { get; set; }
    }
}