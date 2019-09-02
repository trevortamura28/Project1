using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaBox2.Domain.Abstracts
{
  [NotMapped]
  public class APizza
  {
   public int CrustId {get; set;}
   public string SizeName {get; set;}
   public int Id {get; set;}

   [DataType(DataType.Currency)]
   public decimal Cost {get; set;}
   public List<PizzaInput> ToppingsList {get; set;}
   public int OrderId {get; set;}
  }
}