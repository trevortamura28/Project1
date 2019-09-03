using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaBox2.Domain.Models;
using PizzaBox2.Data;
using System.Linq;
using System.Security.Claims;
using PizzaBox2.Client.Models;

namespace PizzaBox2.Client.Controllers
{
  public class SizeController : Controller
  {
    private PizzaBox2DbContext _db = new PizzaBox2DbContext();

    [HttpGet]
    public IActionResult CustomSize()
    {
      ViewBag.sizes = _db.Sizes;
      return View();
    }
    [HttpPost]
    public IActionResult CustomSize(Hold h)
    {
      OrderHelper oh = new OrderHelper();
      Pizza pizza = new Pizza();

      foreach (var t in _db.Transactions)
      {
        if (t.Id == oh.GetTransaction())
        {
          pizza.OrderId = t.O;
        }
      }
      foreach (Size s in _db.Sizes)
      {
        if (s.Id == h.Num)
        {
          pizza.SizeId = s.Id;
          pizza.Cost = pizza.Cost + s.Cost;
        }
      }
      _db.Pizzas.Add(pizza);
      _db.SaveChanges();
      return RedirectToAction("CustomCrust", "Crust", new { area = "Admin" });
    }
    [HttpGet]
    public IActionResult AddSize()
    {
      return View();
    }
    [HttpPost]
    public IActionResult AddSize(Size s)
    {
      Size size = new Size();
      size.Name = s.Name;
      size.Cost = s.Cost;
      _db.Sizes.Add(size);
      _db.SaveChanges();
      return RedirectToAction("Index", "Employee", new { area = "Admin"});
    }
  }
}