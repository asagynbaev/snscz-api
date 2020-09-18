using System.ComponentModel.DataAnnotations;

namespace snscz_api.Models
{
    public class Manufacturer
    {
        [Key]
        public int Id { get; set; }
        public string ManufacturerName { get; set; }
        public string Description { get; set; }
    }
}