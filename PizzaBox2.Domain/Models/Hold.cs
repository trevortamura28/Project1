using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PizzaBox2.Domain.Abstracts;

namespace PizzaBox2.Domain.Models
{
  [NotMapped]
  public class Hold
  { 
    public int Num {get; set;}
    public List<string> List {get; set;}
  }
}