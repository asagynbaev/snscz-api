using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace snscz_api.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public float Volume { get; set; }
        public int VolumeTypeId { get; set; }
        public float Price { get; set; }
        public float PricePerFullVolume { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public int CompositionId { get; set; }
        public int ManufacturerId { get; set; }
        public List<Allergens> Allergens { get; set; }
        public string StorageConditions { get; set; }
        public int ImageId { get; set; }
        public float OurPrice { get; set; }

    }
}