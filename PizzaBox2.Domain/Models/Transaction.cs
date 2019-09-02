using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox2.Domain.Models
{
  public class Transaction
  {
    public int Id {get; set;}
    public int O {get; set;}
    public int U {get; set;}
    public int L {get; set;}
    
  }
}