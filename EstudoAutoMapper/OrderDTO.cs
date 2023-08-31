namespace EstudoAutoMapper
{
    public class OrderDTO
    {
        public int OrderId { get; set; }
        public int NumberOfItems { get; set; }
        public int TotalAmount { get; set; }
        public int CustomerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PostCode { get; set; } = string.Empty;
        public string MobileNo { get; set; } = string.Empty;

        /// <summary>
        /// Para testar com objetos complexos
        /// </summary>
        public Customer? Customer { get; set; }
    }
}
