using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krisdale_Grocery.Model
{
    public class ProductInformation
    {
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        // You can add other properties if needed

        public ProductInformation(string productId, int quantity)
        {
            ProductId = productId;
            Quantity = quantity;
        }
    }
}
