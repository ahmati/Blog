using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string Content { get; set; }
        [Required(ErrorMessage ="Please enter UserName")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter Email")]
        public string Email { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }


    }
}
