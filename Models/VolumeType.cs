using System.ComponentModel.DataAnnotations;

namespace snscz_api.Models
{
    public class VolumeType
    {
        [Key]
        public int Id { get; set; }
        public string VolumeName { get; set; }
        public string VolumeCode { get; set; }
    }
}