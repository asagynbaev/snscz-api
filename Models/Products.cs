using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace snscz_api.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        public Categories Category { get; set; }
        public string ProductName { get; set; }
        public float Volume { get; set; }
        public VolumeType VolumeType { get; set; }
        public float Price { get; set; }
        public float PricePerFullVolume { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public Composition Composition { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public List<Allergens> Allergens { get; set; }
        public string StorageConditions { get; set; }
        public Images Image { get; set; }
        public float OurPrice { get; set; }

    }
}