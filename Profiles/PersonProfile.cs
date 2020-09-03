using AutoMapper;
using People.Dtos;
using People.Models;

namespace People.Profiles 
{
   public class PersonProfile : Profile 
   {
   public PersonProfile() 
   {
       CreateMap<Person, PersonReadDto>();
       CreateMap<PersonCreateDto, Person>();
       CreateMap<PersonUpdateDto, Person>();
       CreateMap<Person, PersonUpdateDto>();
   }
   }
}