using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.ViewModels
{
    public class PostCategoryViewModel
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public List<string> Categories { get; set; }
       
        public string Short_description { get; set; }
        
    }
}
