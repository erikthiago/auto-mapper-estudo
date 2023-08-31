namespace EstudoAutoMapper
{
    /// <summary>
    /// Classe usada para estudar a condicional no AutoMapper
    /// </summary>
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string OptionalName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public int Amount { get; set; }
    }
}
