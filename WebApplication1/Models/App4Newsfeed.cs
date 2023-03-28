using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class App4Newsfeed
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string AuthorName { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
