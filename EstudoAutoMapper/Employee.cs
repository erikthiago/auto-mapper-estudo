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
    }

}