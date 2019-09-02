using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaBox2.Domain.Models
{
  public class Location
  {
    
    public int Id { get; set; }
    [NotMapped]
    public List<Topping> ToppingsOffered { get; set; }
    public String Street {get; set;}
    public String City {get; set;}
    public String State {get; set;}

        public override string ToString()
      {
        return Street + City + State;
      }
   

  
  }
}