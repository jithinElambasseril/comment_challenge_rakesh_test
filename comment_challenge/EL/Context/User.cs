using System;
using System.ComponentModel.DataAnnotations;

namespace EL
{
    public partial class User
    {
        public User()
        {
        }

        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}