using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaBox2.Domain.Models;
using PizzaBox2.Data;
using System.Linq;

namespace PizzaBox2.Client.Controllers
{
  public class CrustController : Controller
  {
    private PizzaBox2DbContext _db = new PizzaBox2DbContext();

    [HttpGet]
    public IActionResult CustomCrust()
    {
      ViewBag.crusts = _db.Crusts;
      return View();
    }
    [HttpPost]
    public IActionResult CustomCrust(Hold h)
    {
      Crust crust = new Crust();
      foreach (Crust c in _db.Crusts)
      {
        if (c.Id == h.Num)
        {
          crust.Name = c.Name;
          crust.Cost = c.Cost;
          crust.Id = h.Num;
        }
      }
      var p = _db.Pizzas.Single(j => j.Id == _db.Pizzas.Count());
      p.Cost = p.Cost + crust.Cost;
      p.CrustId = crust.Id;
      _db.Attach(p);
      _db.SaveChanges();
      return RedirectToAction("CustomTopping", "Topping", new { area = "Admin" });
    }
    [HttpGet]
    public IActionResult AddCrust()
    {
      return View();
    }
    [HttpPost]
    public IActionResult AddCrust(Crust c)
    {
      Crust crust = new Crust();
      crust.Name = c.Name;
      crust.Cost = c.Cost;
      _db.Crusts.Add(crust);
      _db.SaveChanges();
      return RedirectToAction("Index", "Employee", new { area = "Admin" });
    }
  }
}