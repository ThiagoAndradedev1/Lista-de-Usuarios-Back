using Microsoft.EntityFrameworkCore;
using People.Models;

namespace People.Data 
{
    public class PersonContext : DbContext
    {
       public PersonContext(DbContextOptions<PersonContext> opt) : base(opt)
       {
           
       }

       public DbSet<Person> People { get; set; }
    }
}