using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaBox2.Domain.Models;
using PizzaBox2.Data;
using System.Linq;
using System.Security.Claims;
using PizzaBox2.Client.Models;

namespace PizzaBox2.Client.Controllers
{
  public class PresetController : Controller
  {
    PizzaBox2DbContext _db = new PizzaBox2DbContext();
    [HttpGet]
    public IActionResult PresetStarter()
    {
      ViewBag.crusts = _db.Crusts;
      return View();
    }
    [HttpPost]
    public IActionResult PresetStarter(Hold h)
    {
      OrderHelper oh = new OrderHelper();
      Preset p = new Preset();
      p.LocationId = oh.GetLocation();
      p.CrustId = h.Num;
      p.Name = h.List[0];
      _db.Presets.Add(p);
      _db.SaveChanges();
      return RedirectToAction("PresetTopping");
    }
    [HttpGet]
    public IActionResult PresetTopping()
    {
      OrderHelper oh = new OrderHelper();
      ViewBag.top = oh.ToppingFinder();
      return View();
    }
    [HttpPost]
    public IActionResult PresetTopping(Hold h)
    {
      if (h.List == null)
      {
        return RedirectToAction("PresetTopping");
      }
      else if (h.List.Count() == 1 || h.List.Count() > 5)
      {
        return RedirectToAction("PresetTopping");
      }
      else
      {
        OrderHelper oh = new OrderHelper();
        int l = oh.GetLocation();
        int id = _db.Presets.Count();
        foreach (string toppingName in h.List)
        {
          foreach (Inventory i in _db.Inventories)
          {
              if (i.LocationId==l && i.Name==toppingName)
              {
                  PresetTopping pt = new PresetTopping();
                  pt.InventoryId = i.Id;
                  pt.PresetId = id;
                  _db.PresetToppings.Add(pt);
              }
          }
        }
        _db.SaveChanges();
        return RedirectToAction("PresetComplete");
      }
    }
    [HttpGet]
    public IActionResult PresetComplete()
    {
      return View();
    }
    [HttpPost]
    public IActionResult PresetComplete(Hold h)
    {
      switch (h.Num)
      {
          case 1:
          {
            return RedirectToAction("PresetStarter");
          }
          default:
          {
            return RedirectToAction("Index", "Employee", new { area = "Admin" });
          }
      }
      
    }
  }
}