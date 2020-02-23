using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace blog.Models
{
    public class Post
    {
        
        [Key]
        public int PostId { get; set; }
        public string Title { get; set; }       
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string Short_description{ get; set; }
        public string Long_description { get; set; }

        public IList<Post_Category> Post_Categories { get; set; }


    }
}
