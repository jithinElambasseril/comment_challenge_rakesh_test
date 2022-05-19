using System;
using System.ComponentModel.DataAnnotations;

namespace EL
{
    public partial class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual User User { get; set; }
        public virtual Post Post { get; set; }
    }
}