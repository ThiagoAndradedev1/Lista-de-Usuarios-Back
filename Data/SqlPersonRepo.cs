using System;
using System.Collections.Generic;
using System.Linq;
using People.Models;

namespace People.Data 
{
    public class SqlPersonRepo : IPersonRepo
    {
        private readonly PersonContext _context;

        public SqlPersonRepo(PersonContext context)
        {
            _context = context;
        }

        public void CreatePerson(Person cmd)
        {
            if(cmd == null)
            {
             throw new ArgumentNullException(nameof(cmd));  
            }
            _context.People.Add(cmd);
        }

        public void DeletePerson(Person cmd)
        {
            if(cmd == null)
            {
             throw new ArgumentNullException(nameof(cmd));  
            }
            _context.People.Remove(cmd);
        }

        public IEnumerable<Person> GetAllPeople()
        {
            return _context.People.ToList();
        }

        public Person GetPersonById(int id)
        {
            return _context.People.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdatePerson(Person cmd)
        {
            
        }
    }
}