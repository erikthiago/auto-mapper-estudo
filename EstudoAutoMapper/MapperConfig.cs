using AutoMapper;

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
                //Configuring Employee and EmployeeDTO
                cfg.CreateMap<Employee, EmployeeDTO>();

                //Configuring Employee and EmployeeDTO with the different names of properties
                cfg.CreateMap<Employee, EmployeeDTO>()
                //Provide Mapping Configuration of FullName and Name Property
                .ForMember(dest => dest.FullName, act => act.MapFrom(src => src.Name))
                //Provide Mapping Dept of FullName and Department Property
                .ForMember(dest => dest.Dept, act => act.MapFrom(src => src.Department));
            });

            //Create an Instance of Mapper and return that Instance
            var mapper = new Mapper(config);

            return mapper;
        }
    }
}
