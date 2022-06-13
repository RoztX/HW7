namespace HW7
{
    public class Product
    {
        public Product(string name, decimal price, double weight, int quantity)
        {
            Name = name;
            Price = price;
            Weight = weight;
            Quantity = quantity;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public double Weight { get; set; }
        public int Quantity { get; set; }
    }
}
