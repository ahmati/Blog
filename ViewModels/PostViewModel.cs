using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace blog.ViewModels
{
    public class PostViewModel
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public List<int> Categories { get; set; }
       
        public MultiSelectList Categories_Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string Short_description { get; set; }
        public string Long_description { get; set; }
    }
}
