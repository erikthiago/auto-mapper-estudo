namespace EstudoAutoMapper
{
    /// <summary>
    /// Classe utilizada para estudo do mapeamento inverso usando AutoMapper
    /// </summary>
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string PostCode { get; set; } = string.Empty;
        public string ContactNo { get; set; } = string.Empty;
    }
}
