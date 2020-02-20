using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockCatogeryRepository : ICatogeryRepository
    {
        public IEnumerable<Catogery> AllCatogeries =>
            new List<Catogery>
            {
                new Catogery{CatogeryId = 1, CatogeryName = "Fruit Pies", Description = "All fruity pies"},
                new Catogery{CatogeryId = 2, CatogeryName = "Cheese cakes", Description = "Cheesy All the way"},
                new Catogery{CatogeryId = 3, CatogeryName = "Seasonal Pies", Description = "Seasonal Pie"}
            };
    }
}
