namespace EstudoAutoMapper
{
    /// <summary>
    /// Classe usada como exemplo para o estudo do automapper
    /// Link: https://dotnettutorials.net/lesson/automapper-in-c-sharp/
    /// </summary>
    public class Employee
    {
        public string? Name { get; set; }
        public int Salary { get; set; }
        public string? Address { get; set; }
        public string? Department { get; set; }
        public Address? AddressObject { get; set; }

        /// <summary>
        /// Tipo criado para exemplificar como mapear de tipos primitivos para objeto complexo
        /// </summary>
        public string? City { get; set; }
        /// <summary>
        /// Tipo criado para exemplificar como mapear de tipos primitivos para objeto complexo
        /// </summary>
        public string? State { get; set; }
        /// <summary>
        /// Tipo criado para exemplificar como mapear de tipos primitivos para objeto complexo
        /// </summary>
        public string? Country { get; set; }
    }

}