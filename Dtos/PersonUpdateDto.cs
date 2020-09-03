using System.ComponentModel.DataAnnotations;

namespace People.Dtos 
{
    public class PersonUpdateDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Platform { get; set; }
     }
}