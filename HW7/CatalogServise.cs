namespace HW7
{
    public class CatalogServise
    {
        // не понимаю почему не могу изменить на var
        private Catalog _catalog = new Catalog();
        public void CatalogOutput()
        {
            for (var i = 0; i < _catalog.CatalogArray.Length; i++)
            {
                Console.WriteLine($"N{i + 1}\tНазвание:{_catalog.CatalogArray[i].Name}\tЦена:{_catalog.CatalogArray[i].Price}\tВес:{_catalog.CatalogArray[i].Weight}кг.\tДоступное количество:{_catalog.CatalogArray[i].Quantity}");
            }
        }

        public void GetFromCatalog(int index, int requiredQuantity)
        {
            for (var i = 0; i < _catalog.CatalogArray.Length; i++)
            {
                _catalog.CatalogArray[index].Quantity -= requiredQuantity;
            }
        }
    }
}
