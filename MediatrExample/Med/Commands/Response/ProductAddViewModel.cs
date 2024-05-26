namespace MediatrExample.Med.Commands.Response
{
    public class ProductAddViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public bool IsSuccess { get; set; }
    }
}
