using System.Collections.Generic;
using People.Models;

namespace People.Data 
{
    public interface IPersonRepo 
    {
        bool SaveChanges();
        IEnumerable<Person> GetAllPeople();
        Person GetPersonById(int id);
        void CreatePerson(Person cmd);
        void UpdatePerson(Person cmd);
        void DeletePerson(Person cmd);
    }
}