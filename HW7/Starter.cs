namespace HW7
{
    public class Starter
    {
        public void Run()
        {
            var consoleServise = new ConsoleServise();
            var catalogServise = new CatalogServise();
            var orderService = new OrderService();

            while (true)
            {
                Console.WriteLine("Доступные товары:");
                catalogServise.CatalogOutput();
                Console.WriteLine("Выберете номер интересующего вас товара:");
                var index = consoleServise.ValidValueNumber();
                Console.WriteLine("Введите необходимое количество выбранного товара:");
                var requiredQuantity = consoleServise.ValidValueQuantity(index);
                catalogServise.GetFromCatalog(index, requiredQuantity);
                orderService.AddToOrder(index, requiredQuantity);
                Console.WriteLine("Товары в корзине:");
                orderService.OrderOutput();
                Console.WriteLine("Продолжить покупки? (y/n)");
                var response = consoleServise.ValidValueResponse();
                if (response == "n" || response == "N")
                {
                    break;
                }
            }

            orderService.InformationAboutOrder();
        }
    }
}
