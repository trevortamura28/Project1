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
   public int SizeId {get; set;}
   public int Id {get; set;}

   [DataType(DataType.Currency)]
   public decimal Cost {get; set;}
   public int OrderId {get; set;}
  }
}