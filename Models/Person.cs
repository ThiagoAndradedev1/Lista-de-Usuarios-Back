using System.ComponentModel.DataAnnotations;

namespace People.Models 
{
  public class Person
  {
    [Key] 
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Surname { get; set; }
    [Required]
    public string Platform { get; set; }
  }  
}