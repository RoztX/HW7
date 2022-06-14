namespace HW7
{
    public class Catalog
    {
        private Product[] _catalogArray =
        {
            new Product("Мilka      ", 31.60m, 0.090, 100),
            new Product("Сникерс    ", 27.20m, 0.1125, 100),
            new Product("Рошен      ", 23.20m, 0.080, 100),
            new Product("Корона     ", 23.30m, 0.085, 100),
            new Product("Lion       ", 13.50m, 0.042, 100),
            new Product("Kit-Kat    ", 15.90m, 0.040, 100),
            new Product("ШMillennium", 28.40m, 0.090, 100),
            new Product("Bounty     ", 25.4m, 0.0855, 100),
            new Product("Twix       ", 27.57m, 0.075, 100),
            new Product("САЛО       ", 500, 1, 100)
        };

        public Product[] CatalogArray
        {
            get { return _catalogArray; }
            set { _catalogArray = value; }
        }
    }
}
