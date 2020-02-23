using blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.ViewModels
{
    public class PostCommentViewmModel
    {
        public  Post  Post { get; set; }
        public List<Comment> Comment { get; set; }

        
    }
}
