namespace EstudoAutoMapper
{
    /// <summary>
    /// DTO que vai receber os dados da classe Employee
    /// </summary>
    public class EmployeeDTO
    {
        public string? Name { get; set; }
        /// <summary>
        /// Colocado para exemplificar quando há nomes diferentes entre os objetos para vir vazio
        /// </summary>
        public string? FullNameEmpty { get; set; }
        /// <summary>
        /// Colocado para exemplificar quando há nomes diferentes entre os objetos
        /// </summary>
        public string? FullName { get; set; }
        public int Salary { get; set; }
        public string? Address { get; set; }
        public string? Department { get; set; }
        /// <summary>
        /// Colocado para exemplificar quando há nomes diferentes entre os objetos para vir vazio
        /// </summary>
        public string? DeptEmpty { get; set; }
        /// <summary>
        /// Colocado para exemplificar quando há nomes diferentes entre os objetos
        /// </summary>
        public string? Dept { get; set; }
        /// <summary>
        /// Objeto criado para representar como mapear objetos complexos
        /// </summary>
        public AddressDTO? AddressObject { get; set; }
        /// <summary>
        /// Objeto criado para representar como mapear objetos complexos para mostrar erro por estar com nome diferente
        /// </summary>
        public AddressDTO? AddressDTO { get; set; }
    }
}
