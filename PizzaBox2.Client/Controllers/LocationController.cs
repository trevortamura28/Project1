using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaBox2.Domain.Models;
using PizzaBox2.Data;
using System.Linq;
using System.Security.Claims;
using PizzaBox2.Client.Models;
using System;

namespace PizzaBox2.Client.Controllers
{
  public class LocationController : Controller
  {
    private PizzaBox2DbContext _db = new PizzaBox2DbContext();
    [HttpGet]
    public IActionResult SelectLocation()
    {
      ViewBag.locations = _db.Locations;
      return View();
    }
    [HttpGet]
    public IActionResult ViewLocation()
    {
      OrderHelper oh = new OrderHelper();
      int id = oh.GetLocation();
      foreach (Location l in _db.Locations)
      {
        if (id == l.Id)
        {
          return View(l);
        }
      }
      return RedirectToAction("Index", "Home", new { area = "Admin" });
    }
    [HttpPost]
    public IActionResult SelectLocation(Hold h)
    {
      Transaction t = _db.Transactions.Single(c => c.Id == _db.Transactions.Count());
      foreach (Location item in _db.Locations)
      {
        if (item.Id == h.Num)
        {
          t.L = item.Id;
          _db.Attach(t);
        }
      }
      _db.SaveChanges();

      return RedirectToAction("Index", "Home", new { area = "Admin" });
    }
  }
}