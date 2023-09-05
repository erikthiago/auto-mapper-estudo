using AutoMapper;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;
using System.Linq;

namespace EstudoAutoMapper
{
    /// <summary>
    /// Classe responsável pela configuração do AutoMapper
    /// </summary>
    public class MapperConfig
    {
        /// <summary>
        /// Método que vai fazer as configurações do AutoMapper
        /// </summary>
        /// <returns></returns>
        public static Mapper InitializeAutomapper()
        {
            //Provide all the Mapping Configuration
            var config = new MapperConfiguration(cfg =>
            {
                //Configuring Address and AddressDTO
                cfg.CreateMap<Address, AddressDTO>();

                //Configuring Address and AddressDTO
                cfg.CreateMap<Address, AddressDTO>()
                .ForMember(dest => dest.EmpCity, act => act.MapFrom(src => src.City))
                .ForMember(dest => dest.EmpState, act => act.MapFrom(src => src.State));

                //Configuring Employee and EmployeeDTO
                cfg.CreateMap<Employee, EmployeeDTO>();

                //Configuring Employee and EmployeeDTO with the different names of properties
                cfg.CreateMap<Employee, EmployeeDTO>()
                //Provide Mapping Configuration of FullName and Name Property
                .ForMember(dest => dest.FullName, act => act.MapFrom(src => src.Name))
                //Provide Mapping Dept of FullName and Department Property
                .ForMember(dest => dest.Dept, act => act.MapFrom(src => src.Department))

                // Provide Mapping Information for AddressDTO and address
                .ForMember(dest => dest.AddressObject, act => act.MapFrom(src => src.AddressObject))

                //Provide Mapping Information for City Property
                .ForMember(dest => dest.City, act => act.MapFrom(src => src.AddressObject.City))
                //Provide Mapping Information for State Property
                .ForMember(dest => dest.State, act => act.MapFrom(src => src.AddressObject.State))
                //Provide Mapping Information for Country Property
                .ForMember(dest => dest.Country, act => act.MapFrom(src => src.AddressObject.Country))

                //Ignoring the Address property of the destination type
                .ForMember(dest => dest.AddressToIgnore, act => act.Ignore())

                // Ignoring property by extension method that decoretad with [NoMap]
                .IgnoreNoMap()

                // Provide Mapping Information for Address Object
                .ForMember(dest => dest.AddressObjectPrimtive, act => act.MapFrom(src => new Address()
                {
                    City = src.City,
                    State = src.State,
                    Country = src.Country
                }));

                // Configuring reverse map
                cfg.CreateMap<Order, OrderDTO>()
                   //OrderId is different so map them using For Member
                   .ForMember(dest => dest.OrderId, act => act.MapFrom(src => src.OrderNo))
                   //Customer is a Complex type, so Map Customer to Simple type using For Member
                   .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Customer.FullName))
                   .ForMember(dest => dest.PostCode, act => act.MapFrom(src => src.Customer.PostCode))
                   .ForMember(dest => dest.MobileNo, act => act.MapFrom(src => src.Customer.ContactNo))
                   .ForMember(dest => dest.CustomerId, act => act.MapFrom(src => src.Customer.CustomerID))
                   .ReverseMap(); //Making the Mapping Bi-Directional;

                //Mapping Order with OrderDTO
                cfg.CreateMap<Order, OrderDTO>()
                   .ForMember(dest => dest.OrderId, act => act.MapFrom(src => src.OrderNo))
                   .ForMember(dest => dest.Customer, act => act.MapFrom(src => new Customer()
                   {
                       CustomerID = src.CustomerId,
                       FullName = src.Name,
                       PostCode = src.PostCode,
                       ContactNo = src.MobileNo
                   }))
                   .ReverseMap() //This will make the Mapping as Bi-Directional
                                 //Now, we can also Map OrderDTO with Order Object
                                 // Mappping Complex Type to Primitive Type Properties (if this config is not present, AutoMapper 
                                 // do not put the correct values on reverse map)
                   .ForMember(dest => dest.CustomerId, act => act.MapFrom(src => src.Customer.CustomerID))
                   .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Customer.FullName))
                   .ForMember(dest => dest.MobileNo, act => act.MapFrom(src => src.Customer.ContactNo))
                   .ForMember(dest => dest.PostCode, act => act.MapFrom(src => src.Customer.PostCode));

                cfg.CreateMap<Product, ProductDTO>()
                   //If the Name Start with A then Map the Name Value else Map the OptionalName value
                   .ForMember(dest => dest.ItemName, act => act.MapFrom(src => (src.Name.StartsWith("A") ? src.Name : src.OptionalName)))
                   //Map the quantity value if its greater than 0
                   .ForMember(dest => dest.ItemQuantity, act => act.Condition(src => (src.Quantity > 0)))
                   //Map the amount value if its greater than 100
                   .ForMember(dest => dest.Amount, act => act.Condition(src => (src.Amount > 100)));

                cfg.CreateMap<PermanentAddress, TemporaryAddress>()
                   //Using MapFrom Method to Store Static or Hard-Coded Value in a Destination Property
                   .ForMember(dest => dest.CreatedBy, act => act.MapFrom(src => "System"))
                   //Before AutoMapper 8.0, to Store Static Value use the UseValue() method
                   //.ForMember(dest => dest.CreatedBy, act => act.UseValue("System"))
                   //Using MapFrom Method to Store Dynamic Value in a Destination Property
                   //Here, we are calling GetCurrentDateTime method which will return a dynamic value
                   .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => GetCurrentDateTime()))
                   ////Before AutoMapper 8.0, To Store Dynamic value use ResolveUsing() method
                   //.ForMember(dest => dest.CreatedBy, act => act.ResolveUsing(src =>
                   //{
                   //    return DateTime.Now;
                   //}))
                   //Storing NA in the destination Address Property, if Source Address is NULL
                   .ForMember(dest => dest.AddressNull, act => act.NullSubstitute("N/A"))
                   .ReverseMap();
            });

            //Create an Instance of Mapper and return that Instance
            var mapper = new Mapper(config);

            return mapper;
        }

        //Method to return Dynamic Value
        public static DateTime GetCurrentDateTime()
        {
            //Write the Logic to Get Dynamic value
            return DateTime.Now;
        }
    }
}
