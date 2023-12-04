using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krisdale_Grocery.Model
{
    public class ProductModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public byte[] image { get; set; }


    }
}
