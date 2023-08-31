namespace EstudoAutoMapper
{
    public class Order
    {
        public int OrderNo { get; set; }
        public int NumberOfItems { get; set; }
        public int TotalAmount { get; set; }
        public Customer? Customer { get; set; } 

        /// <summary>
        /// Para testar com tipos primitivos
        /// </summary>
        public int CustomerId { get; set; }
        /// <summary>
        /// Para testar com tipos primitivos
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Para testar com tipos primitivos
        /// </summary>
        public string PostCode { get; set; } = string.Empty;
        /// <summary>
        /// Para testar com tipos primitivos
        /// </summary>
        public string MobileNo { get; set; } = string.Empty;
    }
}
