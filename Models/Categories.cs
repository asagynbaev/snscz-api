using System.ComponentModel.DataAnnotations;

namespace snscz_api.Models
{
    public class Categories
    {
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int ParentCategoryId { get; set; }
        public int SortOrder { get; set; }
    }
}