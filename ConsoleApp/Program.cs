// See https://aka.ms/new-console-template for more information

// link do tutorial https://dotnettutorials.net/lesson/automapper-in-c-sharp/

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
    AddressObject = address,
    City = "Brasilia",
    Country = "Brazil",
    State = "Distrito Federal",
    Email = "test@email.com"
};

EmployeeDTO empDTO = new EmployeeDTO
{
    Name = emp.Name,
    Salary = emp.Salary,
    Address = emp.Address,
    Department = emp.Department,
    Email = emp.Email
};

PermanentAddress permAddress = new PermanentAddress()
{
    Name = "Pranaya",
    Address = "Mumbai"
};

PermanentAddress permAddress1 = new PermanentAddress()
{
    Name = "Pranaya",
    Address = "Mumbai",
    CreatedBy = "Dot Net Tutorials",
    CreatedOn = DateTime.Now,
    AddressNull = null
};

#region Sem AutoMapper

Console.WriteLine("Sem AutoMapper \n" + "Name:" + empDTO.Name + ", Salary:" + empDTO.Salary + ", Address:" + empDTO.Address + ", Department:" + empDTO.Department);

#endregion

Console.WriteLine();

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

Console.WriteLine();

#region Usando o AutoMapper com props com nomes diferentes deve retornar vazio

// Departamento e Nome não devem ser mostrados
var dtoMapeado = mapper.Map<EmployeeDTO>(emp);

Console.WriteLine("Com AutoMapper e com props com nomes diferentes não vão aparecer \n" +
                  "Name: " + dtoMapeado.FullNameEmpty +
                  ", Salary: " + dtoMapeado.Salary +
                  ", Address: " + dtoMapeado.Address +
                  ", Department: " + dtoMapeado.DeptEmpty);

#endregion

Console.WriteLine();

#region Usando o AutoMapper com props com nomes diferentes configurado para aparecer normal

// Outras configurações na classe MapperConfig
var dtoMapeado1 = mapper.Map<EmployeeDTO>(emp);

Console.WriteLine("Com AutoMapper e com props com nomes diferentes configurados vão aparecer \n" +
                  "Name: " + dtoMapeado1.FullName +
                  ", Salary: " + dtoMapeado1.Salary +
                  ", Address: " + dtoMapeado1.Address +
                  ", Department: " + dtoMapeado1.Dept);

#endregion

Console.WriteLine();

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

Console.WriteLine();

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

Console.WriteLine();

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

Console.WriteLine();

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

Console.WriteLine();

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
                  ", State: " + dtoMapeado6.AddressObject.EmpStateEmpty +
                  ", Country: " + dtoMapeado6.AddressObject.Country);

#endregion

Console.WriteLine();

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
                  ", State: " + dtoMapeado7.AddressObject.EmpState +
                  ", Country: " + dtoMapeado7.AddressObject.Country);

#endregion

Console.WriteLine();

#region AutoMapper configurado tipos primitivos para o objeto complexo Address

// Outras configurações na classe MapperConfig
var dtoMapeado8 = mapper.Map<EmployeeDTO>(emp);

Console.WriteLine("Com AutoMapper configurado tipos primitivos para o objeto complexo Address \n" +
                  "Name: " + dtoMapeado8.FullName +
                  ", Salary: " + dtoMapeado8.Salary +
                  ", Address: " + dtoMapeado8.Address +
                  ", Department: " + dtoMapeado8.Dept);

Console.WriteLine("Mostrando os dados dos tipos primitivos para o objeto complexo Address \n" +
                  "City: " + dtoMapeado8.AddressObject.City +
                  ", State: " + dtoMapeado8.AddressObject.State+
                  ", Country: " + dtoMapeado8.AddressObject.Country);

#endregion

Console.WriteLine();

#region AutoMapper configurado o objeto complexo Address para tipos primitivos

// Outras configurações na classe MapperConfig
var dtoMapeado9 = mapper.Map<EmployeeDTO>(emp);

Console.WriteLine("Com AutoMapper configurado o objeto complexo Address para tipos primitivos \n" +
                  "Name: " + dtoMapeado9.FullName +
                  ", Salary: " + dtoMapeado9.Salary +
                  ", Address: " + dtoMapeado9.Address +
                  ", Department: " + dtoMapeado9.Dept);

Console.WriteLine("Mostrando os dados dos o objeto complexo Address para tipos primitivos \n" +
                  "City: " + dtoMapeado9.AddressObjectPrimtive.City +
                  ", State: " + dtoMapeado9.AddressObjectPrimtive.State +
                  ", Country: " + dtoMapeado9.AddressObjectPrimtive.Country);

#endregion

Console.WriteLine();

#region AutoMapper configurado com o reverse mapping

// Create the Order Request
Order OrderRequest = CreateOrderRequest();

var orderDTOData = mapper.Map<OrderDTO>(OrderRequest);

// Print the OrderDTO Data
Console.WriteLine("After Mapping - OrderDTO Data");
Console.WriteLine("OrderId : " + orderDTOData.OrderId);
Console.WriteLine("NumberOfItems : " + orderDTOData.NumberOfItems);
Console.WriteLine("TotalAmount : " + orderDTOData.TotalAmount);
Console.WriteLine("CustomerId : " + orderDTOData.CustomerId);
Console.WriteLine("Name : " + orderDTOData.Name);
Console.WriteLine("Postcode : " + orderDTOData.PostCode);
Console.WriteLine("MobileNo : " + orderDTOData.MobileNo);

Console.WriteLine();

// Modify the OrderDTO data
orderDTOData.OrderId = 10;
orderDTOData.NumberOfItems = 20;
orderDTOData.TotalAmount = 2000;
orderDTOData.CustomerId = 5;
orderDTOData.Name = "Smith";
orderDTOData.PostCode = "12345";

// AutoMapper Reverse Mapping
mapper.Map(orderDTOData, OrderRequest);

// Print Order Data
Console.WriteLine("After Reverse Mapping - Order Data");
Console.WriteLine("OrderNo : " + OrderRequest.OrderNo);
Console.WriteLine("NumberOfItems : " + OrderRequest.NumberOfItems);
Console.WriteLine("TotalAmount : " + OrderRequest.TotalAmount);
Console.WriteLine("CustomerId : " + OrderRequest.Customer.CustomerID);
Console.WriteLine("FullName : " + OrderRequest.Customer.FullName);
Console.WriteLine("Postcode : " + OrderRequest.Customer.PostCode);
Console.WriteLine("ContactNo : " + OrderRequest.Customer.ContactNo);

#endregion

Console.WriteLine();

#region AutoMapper configurado com o reverse mapping e map de objetos complexos e primitivos

// Create the Order Request
var OrderRequestWithoutCustomerObject = CreateOrderRequestWithoutCustomerObject();

// Map the OrderRequest object to Order DTO
var orderDTOData1 = mapper.Map<Order, OrderDTO>(OrderRequestWithoutCustomerObject);

// Print the OrderDTO Data
Console.WriteLine("After Mapping - OrderDTO Data");
Console.WriteLine("OrderId : " + orderDTOData1.OrderId);
Console.WriteLine("NumberOfItems : " + orderDTOData1.NumberOfItems);
Console.WriteLine("TotalAmount : " + orderDTOData1.TotalAmount);
Console.WriteLine("CustomerId : " + orderDTOData1.Customer.CustomerID);
Console.WriteLine("FullName : " + orderDTOData1.Customer.FullName);
Console.WriteLine("Postcode : " + orderDTOData1.Customer.PostCode);
Console.WriteLine("ContactNo : " + orderDTOData1.Customer.ContactNo);

Console.WriteLine();

// Modify the OrderDTO data
orderDTOData1.OrderId = 10;
orderDTOData1.NumberOfItems = 20;
orderDTOData1.TotalAmount = 2000;
orderDTOData1.Customer.CustomerID = 5;
orderDTOData1.Customer.FullName = "Pranaya Rout";
orderDTOData1.Customer.PostCode = "12345";
orderDTOData1.Customer.ContactNo = "0011220034";

// Reverse Mapping
mapper.Map(orderDTOData1, OrderRequestWithoutCustomerObject);

// Print the Order Data
Console.WriteLine("After Reverse Mapping - Order Data");
Console.WriteLine("OrderNo : " + OrderRequestWithoutCustomerObject.OrderNo);
Console.WriteLine("NumberOfItems : " + OrderRequestWithoutCustomerObject.NumberOfItems);
Console.WriteLine("TotalAmount : " + OrderRequestWithoutCustomerObject.TotalAmount);
Console.WriteLine("\nCustomerId : " + OrderRequestWithoutCustomerObject.CustomerId);
Console.WriteLine("Name : " + OrderRequestWithoutCustomerObject.Name);
Console.WriteLine("Postcode : " + OrderRequestWithoutCustomerObject.PostCode);
Console.WriteLine("MobileNo : " + OrderRequestWithoutCustomerObject.MobileNo);

#endregion

Console.WriteLine();

#region AutoMapper configurado com condições

Product product = new Product()
{
    ProductID = 101,
    Name = "Led TV", // Se aqui o nome começar com A, mostra, se não, mostra o OptionalName
    OptionalName = "Product name not start with A",
    Quantity = -5, // Se for maior que 0, mostra, senão, mostra 0
    Amount = 1000 // Se for maior que 100, mostra, senão, mostra 0
};

var productDTO = mapper.Map<Product, ProductDTO>(product);

Console.WriteLine("Before Mapping : Product Object");
Console.WriteLine("ProductID : " + product.ProductID);
Console.WriteLine("Name : " + product.Name);
Console.WriteLine("OptionalName : " + product.OptionalName);
Console.WriteLine("Quantity : " + product.Quantity);
Console.WriteLine("Amount : " + product.Amount);

Console.WriteLine();

Console.WriteLine("After Mapping : ProductDTO Object");
Console.WriteLine("ProductID : " + productDTO.ProductID);
Console.WriteLine("ItemName : " + productDTO.ItemName);
Console.WriteLine("ItemQuantity : " + productDTO.ItemQuantity);
Console.WriteLine("Amount : " + productDTO.Amount);

#endregion

Console.WriteLine();

#region AutoMapper configurado para ignorar propriedades

// Outras configurações na classe MapperConfig
var dtoMapeado10 = mapper.Map<EmployeeDTO>(emp);

Console.WriteLine("AutoMapper configurado para ignorar propriedades \n" +
                  "Name: " + dtoMapeado10.FullName +
                  ", Salary: " + dtoMapeado10.Salary +
                  ", Address: " + dtoMapeado10.Address +
                  ", Department: " + dtoMapeado10.Dept +
                  ", Email: " + dtoMapeado10.Email);

Console.WriteLine("AutoMapper configurado para ignorar propriedades \n" +
                  "Name: " + dtoMapeado10.FullName +
                  ", Salary: " + dtoMapeado10.Salary +
                  ", Department: " + dtoMapeado10.Dept +
                  ", Email: " + dtoMapeado10.Email +
                  ", Address: " + dtoMapeado10.AddressToIgnore);

#endregion

Console.WriteLine();

#region AutoMapper configurado para ignorar propriedades com método de extensão

// Outras configurações na classe MapperConfig
var dtoMapeado11 = mapper.Map<EmployeeDTO>(emp);

Console.WriteLine("AutoMapper configurado para ignorar propriedades com método de extensão \n" +
                  "Name: " + dtoMapeado11.FullName +
                  ", Salary: " + dtoMapeado11.Salary +
                  ", Address: " + dtoMapeado11.Address +
                  ", Department: " + dtoMapeado11.Dept +
                  ", Email: " + dtoMapeado11.Email);

Console.WriteLine("AutoMapper configurado para ignorar propriedades com método de extensão \n" +
                  "Name: " + dtoMapeado11.FullName +
                  ", Salary: " + dtoMapeado11.Salary +
                  ", Department: " + dtoMapeado11.Dept +
                  ", Email: " + dtoMapeado11.EmailToIgnore +
                  ", Address: " + dtoMapeado11.AddressToIgnoreExtensionMethod);

#endregion

Console.WriteLine();

#region AutoMapper configurado para usar valores fixos e dinamicos

// Outras configurações na classe MapperConfig
var tempAddress = mapper.Map<TemporaryAddress>(permAddress);

Console.WriteLine("After Mapping Permanent Address without createdby and createdon null");
//Here CreatedBy and CreatedOn will be empty for Permanent Address
Console.WriteLine($"Name: {permAddress.Name}, Address: {permAddress.Address}, CreatedBy: {permAddress.CreatedBy}, CreatedOn: {permAddress.CreatedOn}");
Console.WriteLine("After Mapping Permanent Address");
//Here CreatedBy with Fixed Valye and CreatedOn with Dynamic Value
Console.WriteLine($"Name: {tempAddress.Name}, Address: {tempAddress.Address}, CreatedBy: {tempAddress.CreatedBy}, CreatedOn: {tempAddress.CreatedOn}");

#endregion

Console.WriteLine();

#region AutoMapper configurado para usar valores fixos e dinamicos e substituindo valores nulll por N/A

// Outras configurações na classe MapperConfig
var tempAddress1 = mapper.Map<TemporaryAddress>(permAddress1);

Console.WriteLine("After Mapping Permanent Address without createdby and createdon null");
//Here CreatedBy and CreatedOn will be empty for Permanent Address
Console.WriteLine($"Name: {permAddress1.Name}, Address: {permAddress1.Address}, CreatedBy: {permAddress1.CreatedBy}, CreatedOn: {permAddress1.CreatedOn}");
Console.WriteLine("After Mapping Permanent Address");
//Here CreatedBy with Fixed Valye and CreatedOn with Dynamic Value
Console.WriteLine($"Name: {tempAddress1.Name}, Address: {tempAddress1.AddressNull}, CreatedBy: {tempAddress1.CreatedBy}, CreatedOn: {tempAddress1.CreatedOn}");

#endregion

Console.ReadLine();

static Order CreateOrderRequest()
{
    return new Order
    {
        OrderNo = 101,
        NumberOfItems = 3,
        TotalAmount = 1000,
        Customer = new Customer()
        {
            CustomerID = 777,
            FullName = "James Smith",
            PostCode = "755019",
            ContactNo = "1234567890"
        },
    };
}

static Order CreateOrderRequestWithoutCustomerObject()
{
    return new Order
    {
        OrderNo = 101,
        NumberOfItems = 3,
        TotalAmount = 1000,
        CustomerId = 777,
        Name = "James Smith",
        PostCode = "755019",
        MobileNo = "1234567890"
    };
}