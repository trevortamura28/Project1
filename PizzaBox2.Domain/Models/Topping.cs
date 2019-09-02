using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaBox2.Domain.Abstracts;

namespace PizzaBox2.Domain.Models
{
  public class Topping : PizzaInput
  {
    public int PizzaId {get; set;}
  }
}