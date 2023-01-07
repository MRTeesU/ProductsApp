namespace ProductsApp.Api.Models
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int productid, int userid)
        {
            ProductId = productid;
            UserId = userid;
        }
        public int ProductId { get; set; }
        public int UserId { get; set; }
    }

}
