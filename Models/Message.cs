using System.ComponentModel.DataAnnotations;

namespace ForumTesting.Models
{
    public class Message
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; } = "";

        [Required, StringLength(1000)]
        public string Content { get; set; } = "";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
