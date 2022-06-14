namespace HW7
{
    public class ConsoleServise
    {
        public int ValidValueNumber()
        {
            var productList = new Catalog();
            int minValue = 0;
            int maxValue = productList.CatalogArray.Length + 1;
            int index;
            while (true)
            {
                index = Convert.ToInt32(Console.ReadLine()) - 1;
                if (index >= minValue && index <= maxValue)
                {
                    break;
                }

                Console.WriteLine("Invalid value");
            }

            return index;
        }

        public int ValidValueQuantity(int index)
        {
            var productList = new Catalog();
            int minValue = 1;
            int maxValue = productList.CatalogArray[index].Quantity;
            int requiredQuantity;
            while (true)
            {
                requiredQuantity = Convert.ToInt32(Console.ReadLine());
                if (requiredQuantity >= minValue && requiredQuantity <= maxValue)
                {
                    break;
                }

                Console.WriteLine("Invalid value");
            }

            return requiredQuantity;
        }

        public string ValidValueResponse()
        {
            string? response;
            while (true)
            {
                response = Console.ReadLine();
                if (response == "y" || response == "Y" || response == "n" || response == "N")
                {
                    break;
                }

                Console.WriteLine("Invalid value");
            }

            return response;
        }
    }
}
