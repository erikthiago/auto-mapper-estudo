// See https://aka.ms/new-console-template for more information

using EstudoAutoMapper;

#region Sem AutoMapper

Employee emp = new Employee
{
    Name = "James",
    Salary = 20000,
    Address = "London",
    Department = "IT"
};

EmployeeDTO empDTO = new EmployeeDTO
{
    Name = emp.Name,
    Salary = emp.Salary,
    Address = emp.Address,
    Department = emp.Department
};

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
                  "Name: " + dtoMapeado.FullName +
                  ", Salary: " + dtoMapeado.Salary +
                  ", Address: " + dtoMapeado.Address +
                  ", Department: " + dtoMapeado.Dept);

#endregion

Console.ReadLine();