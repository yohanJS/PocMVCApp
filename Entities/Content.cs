using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PocMVCApp.Entities
{
    public class Content
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string? Title { get; set; }
        public string? HTMLContent { get; set; }
        public string? VideoLink { get; set; }
        public CategoryItem? CategoryItem { get; set; }
    }
}
