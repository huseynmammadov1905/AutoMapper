using AutoMapper;
using AutomapperTask.Models;

namespace AutomapperTask
{
    public class PersonProfile : Profile
    {

        public PersonProfile()
        {
            CreateMap<Person, PersonDTO>();
            CreateMap<PersonDTO, Person>();
                
        }
    }
}
