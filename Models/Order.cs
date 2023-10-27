namespace orders_asp_net_app.Models
{
    public enum Payment
    {
        CASH,
        CREDIT,
    }

    public class Order
    {
        public int Id { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;  

        public List<Product> Products { get; set; }

        public string ClientName { get; set; }  

        public string ClientAddress { get; set; }    

        public int ClientPhone { get; set; }

        public Payment PaymentMethod { get; internal set; }
    }
}
