using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blog.ViewModels
{
    public class CommentsViewModel
    {
        public int CommentID { get; set; }
        public string Content { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        public int PostId { get; set; }
    }
}
