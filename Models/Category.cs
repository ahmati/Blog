using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace blog.Models
{
    public class Category
    {
        

        [Key]
        public int Category_Id { get; set; }
        public string Category_Name { get; set; }

       
        public IList<Post_Category> Post_Categories { get; set; }
        

    }
}
