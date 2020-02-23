using System.Collections.Generic;

namespace blog.Services
{
    public interface ICategoryService
    {
        List<int> GetCategoryId();
        List<int> GetCategoryIdsByPostId(int id);
        List<string> GetCategoryNameByPostId(int id);
    }
    
}