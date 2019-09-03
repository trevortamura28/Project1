using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaBox2.Domain.Models;
using PizzaBox2.Data;
using System.Linq;
using System.Security.Claims;
using PizzaBox2.Client.Models;

namespace PizzaBox2.Client.Controllers
{
  public class PizzaController : Controller
  {
    private PizzaBox2DbContext _db = new PizzaBox2DbContext();

    [HttpGet]
    public IActionResult CustomOrPreset()
    {
      return View();
    }
    [HttpPost]
    public IActionResult CustomOrPreset(Hold h)
    {
      switch (h.Num)
      {
        case 1:
        {
            return RedirectToAction("CustomSize","Size", new { area = "Admin"});
        }

        default:
        {
            return RedirectToAction("ClassicPizzaSelect");
        }
      }
    }
    [HttpGet]
    public IActionResult ClassicPizzaSelect()
    {
      OrderHelper oh = new OrderHelper();
      int l= oh.GetLocation();
      List<Preset> list = new List<Preset>();
      foreach (Preset p in _db.Presets)
      {
          if (p.LocationId==l)
          {
              list.Add(p);
          }
      }
      ViewBag.preset = list;
      return View();
    }
    [HttpPost]
    public IActionResult ClassicPizzaSelect(Hold h)
    {
      PizzaHelper ph = new PizzaHelper();
      ph.PizzaBuilder(h.Num);
      return RedirectToAction("ClassicPizzaSize");
    }
    [HttpGet]
    public IActionResult ClassicPizzaSize()
    {
      ViewBag.s = _db.Sizes;
      return View();
    }
    [HttpPost]
    public IActionResult ClassicPizzaSize(Hold h)
    {
      PizzaHelper ph = new PizzaHelper();
      ph.PizzaFinish(h.Num);
      return RedirectToAction("Index", "Order", new { area = "Admin"});
    }
  }
}