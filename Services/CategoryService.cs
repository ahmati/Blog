using blog.Data;
using blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace blog.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<int> GetCategoryIdsByPostId(int id)
        {

            try
            {
                return _context.Post_Categories
                    .Where(x => x.PostId == id)
                    .Select(x => x.Category_Id)
                    .ToList();

            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<string> GetCategoryNameByPostId(int id)
        {
           List<int> categoryIds= GetCategoryIdsByPostId(id);

            List<string> categoryNames = new List<string>();


            foreach (var i in categoryIds)          
            {
                var name = _context.Categories.Where(m => m.Category_Id == i).Select(n => n.Category_Name).FirstOrDefault();
                categoryNames.Add(name);
            }
            return categoryNames; 

        }

        public List<int>  GetCategoryId()
        {
            try
            {
                return _context.Categories
                    .Select(x => x.Category_Id)
                    .ToList();
                    

            }
            catch (Exception )
            {

                throw;
            }
        }

       
    }
}
