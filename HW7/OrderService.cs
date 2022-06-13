namespace HW7
{
    public class OrderService
    {
        // не понимаю почему не могу изменить на var
        private Order _order = new Order();
        public void OrderOutput()
        {
            for (var i = 0; i < _order.OrderArray.Length; i++)
            {
                if (_order.OrderArray[i].Quantity > 0)
                {
                    Console.WriteLine($"N{i + 1}\tНазвание:{_order.OrderArray[i].Name}\tЦена:{_order.OrderArray[i].Price}грн.\tВес:{_order.OrderArray[i].Weight}кг.\tВыбранное количество:{_order.OrderArray[i].Quantity}");
                }
            }
        }

        public void InformationAboutOrder()
        {
            Random rand = new Random();
            Console.WriteLine($"Ваш завказ N:{rand.Next(1000, 10000)} был сформирован:");
            OrderOutput();
            decimal priceSum = 0;
            double weightSum = 0;
            int quantitySum = 0;
            for (var i = 0; i < _order.OrderArray.Length; i++)
            {
                priceSum += (decimal)(_order.OrderArray[i].Price * _order.OrderArray[i].Quantity);
                weightSum += _order.OrderArray[i].Weight;
                quantitySum += _order.OrderArray[i].Quantity;
            }

            Console.WriteLine($"Количество единиц товара:{quantitySum}\tОбщий вес заказа:{weightSum}кг.\tНа сумму:{priceSum}грн.");
        }

        public void AddToOrder(int index, int requiredQuantity)
        {
            _order.OrderArray[index].Quantity += requiredQuantity;
        }
    }
}
