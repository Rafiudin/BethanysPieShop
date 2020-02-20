using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class Catogery
    {
        public int CatogeryId { get; set; }
        public string CatogeryName { get; set; }
        public string Description { get; set; }
        public List<Pie> Pies { get; set; }
    }
}
