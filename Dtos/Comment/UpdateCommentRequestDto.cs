using System.ComponentModel.DataAnnotations;

namespace Latihan.Dtos.Comment
{
    public class UpdateCommentRequestDto
    {

        [Required]
        [MinLength(5, ErrorMessage = "Title mus be 5 character")]
        [MaxLength(280, ErrorMessage = "Title cannot be over 280 character")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MinLength(5, ErrorMessage = "Content mus be 5 character")]
        [MaxLength(280, ErrorMessage = "Content cannot be over 280 character")]
        public string Content { get; set; } = string.Empty;
    }
}
