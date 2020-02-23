using System.Collections.Generic;
using blog.Models;

namespace blog.Services
{
    public interface IKeyValueService
    {
        IEnumerable<KeyValue> GetCategoriesKeyValue();
    }
}