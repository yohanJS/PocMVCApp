using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PocMVCApp.Entities
{
    public class MediaType
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string? Title { get; set; }
        [Required]
        public string? ThumbnailImagePath { get; set; }
        [ForeignKey("MediaTypeId")]
        public ICollection<CategoryItem>? CategoryItems { get; set; }

    }
}
