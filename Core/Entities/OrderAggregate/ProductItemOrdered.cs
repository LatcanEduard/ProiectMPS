namespace Core.Entities.OrderAggregate
{
    public class ProductItemOrdered
    {
        public ProductItemOrdered()
        {
        }

        public ProductItemOrdered(int productItemId, string productName, string pricureUrl)
        {
            ProductItemId = productItemId;
            ProductName = productName;
            PricureUrl = pricureUrl;
        }

        public int ProductItemId { get; set; }
        public string ProductName { get; set; }
        public string PricureUrl { get; set; }
    }
}