using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => 
            new List<Category>
            {
                new Category { CategoryId=1, CategoryName="Fruit Cakes", Description="All cakes with seasonal fruits"},
                new Category { CategoryId=2, CategoryName="Cheese Cakes", Description="All cakes with a cheesy twist"},
                new Category { CategoryId=3, CategoryName="Chocolate Cakes", Description="All cakes with extreme dark sides"},
        
            };
    }
}
