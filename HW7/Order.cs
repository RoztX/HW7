namespace HW7
{
    public class Order
    {
        private Product[] _orderArray =
        {
            new Product("Шоколад Мilka", 31.60m, 0.090, 0),
            new Product("Сникерс", 27.20m, 0.1125, 0),
            new Product("Шоколад Рошен", 23.20m, 0.080, 0),
            new Product("Шоколад Корона", 23.30m, 0.085, 0),
            new Product("Lion", 13.50m, 0.042, 0),
            new Product("Kit-Kat", 15.90m, 0.040, 0),
            new Product("Шоколад Millennium", 28.40m, 0.090, 0),
            new Product("Bounty", 25, 0.0855, 0),
            new Product("Twix", 27.57m, 0.075, 0),
            new Product("САЛО", 500, 1, 0)
        };

        public Product[] OrderArray
        {
            get { return _orderArray; }
            set { _orderArray = value; }
        }
    }
}
