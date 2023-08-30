namespace EstudoAutoMapper
{
    /// <summary>
    /// DTO que vai receber os dados da classe Address
    /// </summary>
    public class AddressDTO
    {
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }

        /// <summary>
        /// Colocado para exemplificar quando há nomes diferentes entre os objetos para vir vazio
        /// </summary>
        public string? EmpCityEmpty { get; set; }
        /// <summary>
        /// Colocado para exemplificar quando há nomes diferentes entre os objetos para vir vazio
        /// </summary>
        public string? EmpStateEmpty { get; set; }

        /// <summary>
        /// Colocado para exemplificar quando há nomes diferentes entre os objetos para vir normal
        /// </summary>
        public string? EmpCity { get; set; }
        /// <summary>
        /// Colocado para exemplificar quando há nomes diferentes entre os objetos para vir normal
        /// </summary>
        public string? EmpState { get; set; }
    }
}
