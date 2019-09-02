using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaBox2.Domain.Abstracts
{
  [NotMapped]
  public abstract class PizzaInput
  {
    [Required]
    public string Name { get; set; }
    public int Id { get; set; }
    
    [DataType(DataType.Currency)]
    public decimal Cost { get; set; }

  }
}