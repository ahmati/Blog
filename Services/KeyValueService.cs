using blog.Data;
using blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.Services
{
    public class KeyValueService : IKeyValueService
    {

        private readonly ApplicationDbContext _context;
        public KeyValueService(ApplicationDbContext context)
        {
            _context = context;
        }


        public IEnumerable<KeyValue> GetCategoriesKeyValue()
        {
            var categories = _context.Categories;

            var values = categories.Select(x => new KeyValue
            {
                Key = x.Category_Id,
                Value = x.Category_Name
            });

            return values;
        }
    }
}
