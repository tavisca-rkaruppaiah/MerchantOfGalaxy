using System.Collections.Generic;

namespace MerchantOfGalaxy
{
    public class ProductDetails
    {
        private Dictionary<string, double> _products = new Dictionary<string, double>()
        {
            { "Silver", 17},
            {"Gold", 14450 },
            { "Iron", 195.5}
        };
        public void AddProduct(Product product)
        {
            _products[product.GetName()] = product.GetPrice();   
        }

        public double GetProductPrice(string name)
        {
            return _products[name];
        }
    }

   
}
