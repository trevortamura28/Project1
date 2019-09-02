using System.ComponentModel.DataAnnotations;

namespace PizzaBox2.Domain.Models
{
    public class User
    {
      [Required]
      public string FirstName {get; set;}
      [Required]
      public string LastName {get; set;}
      public int Id {get; set;}


      public override string ToString()
      {
        return FirstName + "  " + LastName;
      }
    }
}