using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EL
{
    public partial class Post
    {
        public Post()
        {
            this.Comments = new List<Comment>();
        }
        [Key]
        public int PostId { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual IList<Comment> Comments { get; set; }
    }
}