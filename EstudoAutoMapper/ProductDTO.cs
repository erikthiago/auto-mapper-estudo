namespace EstudoAutoMapper
{
    /// <summary>
    /// Classe usada para estudar a condicional no AutoMapper
    /// </summary>
    public class ProductDTO
    {
        public int ProductID { get; set; }
        public string ItemName { get; set; } = string.Empty;
        public int ItemQuantity { get; set; }
        public int Amount { get; set; }
    }
}
