using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EL.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public IEnumerable<CommentModel> Comments { get; set; }
    }
}
