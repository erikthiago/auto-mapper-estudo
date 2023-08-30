using AutoMapper;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;

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
                .ForMember(dest => dest.AddressObject, act => act.MapFrom(src => src.AddressObject));
            });

            //Create an Instance of Mapper and return that Instance
            var mapper = new Mapper(config);

            return mapper;
        }
    }
}
