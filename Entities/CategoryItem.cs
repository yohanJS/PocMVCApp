using System.ComponentModel.DataAnnotations;

namespace PocMVCApp.Entities
{
    public class CategoryItem
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength =2)]
        public string? Title { get; set; }
        public int CategoryId { get; set; }
        public int MediaTypeId { get; set; }
        public DateTime DateTimeItemReleased { get; set; }
    }
}
