using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox2.Domain.Models
{
  public class Order
  {
    public int Id { get; set; }

    [DataType(DataType.Currency)]
    public decimal Cost { get; set; }
    public User User { get; set; }
    public List<Pizza> PizzaList;
    public int LocationId {get; set;}
  }
}