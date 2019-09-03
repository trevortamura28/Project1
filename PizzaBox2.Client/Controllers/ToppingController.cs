using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaBox2.Domain.Models;
using PizzaBox2.Data;
using System.Linq;
using PizzaBox2.Client.Models;

namespace PizzaBox2.Client.Controllers
{
  public class ToppingController : Controller
  {
    private PizzaBox2DbContext _db = new PizzaBox2DbContext();

    [HttpGet]
    public IActionResult CustomTopping()
    {
      OrderHelper oh = new OrderHelper();
      ViewBag.toppings = oh.ToppingFinder();
      return View();
    }
    [HttpPost]
    public IActionResult CustomTopping(Hold h)
    {
      if (h.List == null)
      {
        return RedirectToAction("CustomTopping");
      }
      else if (h.List.Count() == 1 || h.List.Count() > 5)
      {
        return RedirectToAction("CustomTopping");
      }
      else
      {
        OrderHelper oh = new OrderHelper();
        int pid = oh.SetToppingPrice(h.List.Count());
        oh.ReduceInventory(h.List);
        foreach (var toppingName in h.List)
        {
          Topping x = new Topping();
          x.PizzaId = pid;
          x.Name = toppingName;
          _db.Toppings.Add(x);
        }
        _db.SaveChanges();
        return RedirectToAction("Index", "Order", new { area = "Admin" });
      }
    }

    [HttpGet]
    public IActionResult AddTopping()
    {
      return View();
    }
    [HttpPost]
    public IActionResult AddTopping(Topping t)
    {
      OrderHelper oh = new OrderHelper();
      Inventory i = new Inventory();
      int tran = oh.GetTransaction();
      foreach (Transaction transaction in _db.Transactions)
      {
        if (tran == transaction.Id)
        {
          i.LocationId = transaction.L;
        }
      }
      i.Name = t.Name;
      i.Count = 500;
      _db.Inventories.Add(i);
      _db.SaveChanges();
      return RedirectToAction("Index", "Employee", new { area = "Admin"});
    }
  }

}