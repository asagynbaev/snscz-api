using System.ComponentModel.DataAnnotations;

namespace snscz_api.Models
{
    public class Images
    {
        [Key]
        public int Id { get; set; }
        public string ImageTitle { get; set; }
        public byte[] ImageData { get; set; }
    }
}