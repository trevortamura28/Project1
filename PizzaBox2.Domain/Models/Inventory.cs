using System;
using System.ComponentModel.DataAnnotations;
using PizzaBox2.Domain.Abstracts;

namespace PizzaBox2.Domain.Models
{
  public class Inventory
  {
    
    public int Id {get; set;}
    public string Name {get; set;}
    public int Count {get; set;}
    public int LocationId {get; set;}
  }
}