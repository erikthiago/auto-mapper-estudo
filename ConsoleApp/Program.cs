// See https://aka.ms/new-console-template for more information

using EstudoAutoMapper;

Address address = new Address
{
    City = "Mahacastra",
    Country = "India",
    State = "Mumbai"
};

Employee emp = new Employee
{
    Name = "James",
    Salary = 20000,
    Address = "London",
    Department = "IT",
    AddressObject = address
};

EmployeeDTO empDTO = new EmployeeDTO
{
    Name = emp.Name,
    Salary = emp.Salary,
    Address = emp.Address,
    Department = emp.Department
};

#region Sem AutoMapper

Console.WriteLine("Sem AutoMapper \n" + "Name:" + empDTO.Name + ", Salary:" + empDTO.Salary + ", Address:" + empDTO.Address + ", Department:" + empDTO.Department);

#endregion

// Inicializando o AutoMapper
var mapper = MapperConfig.InitializeAutomapper();

#region Usando o AutoMapper

// Primeira forma de fazer os mapeamentos:
var dtoMapeadoFormaUm = mapper.Map<EmployeeDTO>(emp);

// Segunda forma de fazer os mapeamentos:
var dtoMapeadoFormaDois = mapper.Map<Employee, EmployeeDTO>(emp);

Console.WriteLine("Com AutoMapper \n" +
                  "Name: " + dtoMapeadoFormaUm.Name + 
                  ", Salary: " + dtoMapeadoFormaUm.Salary +
                  ", Address: " + dtoMapeadoFormaUm.Address + 
                  ", Department: " + dtoMapeadoFormaUm.Department);
#endregion

#region Usando o AutoMapper com props com nomes diferentes deve retornar vazio

// Departamento e Nome não devem ser mostrados
var dtoMapeado = mapper.Map<EmployeeDTO>(emp);

Console.WriteLine("Com AutoMapper e com props com nomes diferentes não vão aparecer \n" +
                  "Name: " + dtoMapeado.FullNameEmpty +
                  ", Salary: " + dtoMapeado.Salary +
                  ", Address: " + dtoMapeado.Address +
                  ", Department: " + dtoMapeado.DeptEmpty);

#endregion

#region Usando o AutoMapper com props com nomes diferentes configurado para aparecer normal

// Outras configurações na classe MapperConfig
var dtoMapeado1 = mapper.Map<EmployeeDTO>(emp);

Console.WriteLine("Com AutoMapper e com props com nomes diferentes configurados vão aparecer \n" +
                  "Name: " + dtoMapeado1.FullName +
                  ", Salary: " + dtoMapeado1.Salary +
                  ", Address: " + dtoMapeado1.Address +
                  ", Department: " + dtoMapeado1.Dept);

#endregion

#region AutoMapper vai lançar uma exceção por conta do objeto complexo Address

// Outras configurações na classe MapperConfig
var dtoMapeado2 = mapper.Map<EmployeeDTO>(emp);

Console.WriteLine("Com AutoMapper vai lançar exceção por conta do objeto complexo Address \n" +
                  "Name: " + dtoMapeado2.FullName +
                  ", Salary: " + dtoMapeado2.Salary +
                  ", Address: " + dtoMapeado2.Address +
                  ", Department: " + dtoMapeado2.Dept);

// COMENTADO PARA FINS DE ESTUDOS. QUANDO QUISER SER O ERRO, DESCOMENTE
//Console.WriteLine("Com AutoMapper vai lançar exceção por conta do objeto complexo Address \n" +
//                  "City: " + dtoMapeado.AddressObject.City +
//                  ", State: " + dtoMapeado.AddressObject.State+
//                  ", Country: " + dtoMapeado.AddressObject.Country);

#endregion

#region AutoMapper configurado com o objeto complexo Address

// Outras configurações na classe MapperConfig
var dtoMapeado3 = mapper.Map<EmployeeDTO>(emp);

Console.WriteLine("Com AutoMapper configurado com o objeto complexo Address \n" +
                  "Name: " + dtoMapeado3.FullName +
                  ", Salary: " + dtoMapeado3.Salary +
                  ", Address: " + dtoMapeado3.Address +
                  ", Department: " + dtoMapeado3.Dept);

Console.WriteLine("Mostrando os dados do objeto complexo Address \n" +
                  "City: " + dtoMapeado3.AddressObject.City +
                  ", State: " + dtoMapeado3.AddressObject.State +
                  ", Country: " + dtoMapeado3.AddressObject.Country);

#endregion

#region AutoMapper configurado com o objeto complexo Address com nome diferente vai retornar erro

// Outras configurações na classe MapperConfig
var dtoMapeado4 = mapper.Map<EmployeeDTO>(emp);

Console.WriteLine("Com AutoMapper configurado com o objeto complexo Address com nome diferente vai retornar erro \n" +
                  "Name: " + dtoMapeado4.FullName +
                  ", Salary: " + dtoMapeado4.Salary +
                  ", Address: " + dtoMapeado4.Address +
                  ", Department: " + dtoMapeado4.Dept);

// COMENTADO PARA FINS DE ESTUDO, DESCOMENTE SE PRECISAR VER O COMPORTAMENTO
//Console.WriteLine("Mostrando os dados do objeto complexo Address com nome diferente vai retornar erro \n" +
//                  "City: " + dtoMapeado4.AddressDTO.City +
//                  ", State: " + dtoMapeado4.AddressDTO.State +
//                  ", Country: " + dtoMapeado4.AddressDTO.Country);

#endregion

#region AutoMapper configurado com o objeto complexo Address com nome diferente vai retornar normal

// Outras configurações na classe MapperConfig
var dtoMapeado5 = mapper.Map<EmployeeDTO>(emp);

Console.WriteLine("Com AutoMapper configurado com o objeto complexo Address com nome diferente vai retornar normal \n" +
                  "Name: " + dtoMapeado5.FullName +
                  ", Salary: " + dtoMapeado5.Salary +
                  ", Address: " + dtoMapeado5.Address +
                  ", Department: " + dtoMapeado5.Dept);

Console.WriteLine("Mostrando os dados do objeto complexo Address com nome diferente vai retornar normal \n" +
                  "City: " + dtoMapeado5.AddressObject.City +
                  ", State: " + dtoMapeado5.AddressObject.State +
                  ", Country: " + dtoMapeado5.AddressObject.Country);

#endregion

#region AutoMapper configurado com o objeto complexo Address com props nome diferente vai retornar vazio

// Outras configurações na classe MapperConfig
var dtoMapeado6 = mapper.Map<EmployeeDTO>(emp);

Console.WriteLine("Com AutoMapper configurado com o objeto complexo Address com props nome diferente vai retornar vazio \n" +
                  "Name: " + dtoMapeado6.FullName +
                  ", Salary: " + dtoMapeado6.Salary +
                  ", Address: " + dtoMapeado6.Address +
                  ", Department: " + dtoMapeado6.Dept);

Console.WriteLine("Mostrando os dados do objeto complexo Address com props nome diferente vai retornar vazio \n" +
                  "City: " + dtoMapeado6.AddressObject.EmpCityEmpty +
                  ", State: " + dtoMapeado6.AddressObject.EmpCityEmpty +
                  ", Country: " + dtoMapeado6.AddressObject.Country);

#endregion

#region AutoMapper configurado com o objeto complexo Address com props nome diferente vai retornar normal

// Outras configurações na classe MapperConfig
var dtoMapeado7 = mapper.Map<EmployeeDTO>(emp);

Console.WriteLine("Com AutoMapper configurado com o objeto complexo Address com props nome diferente vai retornar normal \n" +
                  "Name: " + dtoMapeado7.FullName +
                  ", Salary: " + dtoMapeado7.Salary +
                  ", Address: " + dtoMapeado7.Address +
                  ", Department: " + dtoMapeado7.Dept);

Console.WriteLine("Mostrando os dados do objeto complexo Address com props nome diferente vai retornar normal \n" +
                  "City: " + dtoMapeado7.AddressObject.EmpCity +
                  ", State: " + dtoMapeado7.AddressObject.EmpCity +
                  ", Country: " + dtoMapeado7.AddressObject.Country);

#endregion

Console.ReadLine();