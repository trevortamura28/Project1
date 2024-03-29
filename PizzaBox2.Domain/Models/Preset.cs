using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PizzaBox2.Domain.Abstracts;

namespace PizzaBox2.Domain.Models
{
  public class Preset 
  {
    public int Id {get; set;}
    public int LocationId {get; set;}
    public string Name {get; set;}
    public int CrustId {get; set;}
  }
}