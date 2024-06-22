namespace netlab13Noe.Models
{
    public class Detail
    {
        public int DetailId { get; set; }
        public int Amount { get; set; }
        public float Price { get; set; }
        public float Subtotal { get; set; }

        public Invoice Invoice { get; set; }
        public int InvoiceId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
