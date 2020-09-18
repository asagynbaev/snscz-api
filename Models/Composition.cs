using System.ComponentModel.DataAnnotations;

namespace snscz_api.Models
{
    public class Composition
    {
        [Key]
        public int Id { get; set; } 
        public float EnergyValue { get; set; } //Energetická hodnota
        public float Fat { get; set; } //Tuk
        public float SaturatedAccids { get; set; } //Z toho nasycené mastné kyseliny
        public float Carbohydrate { get; set; } //Sacharidy
        public float Sugar { get; set; } //Z toho cukry
        public float Fiber { get; set; } //Vláknina
        public float Protein { get; set; } //Bílkoviny
        public float Salt { get; set; } //Sůl
    }
}