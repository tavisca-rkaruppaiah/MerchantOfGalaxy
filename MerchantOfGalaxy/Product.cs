namespace MerchantOfGalaxy
{
    public class Product
    {
        private string _name { get; }
        private double _price { get; }
        public Product(string name, double price)
        {
            _name = name;
            _price = price;
        }

        public string GetName()
        {
            return _name;
        }

        public double GetPrice()
        {
            return _price;
        }
    }

   
}
