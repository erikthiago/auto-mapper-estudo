﻿namespace EstudoAutoMapper
{
    public class TemporaryAddress
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Propriedade usada para exemplificar quando vier nulo, mostrar um texto alternativo
        /// </summary>
        public string? AddressNull { get; set; }
    }
}
