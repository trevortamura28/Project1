using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaBox2.Domain.Models;
using PizzaBox2.Data;
using System.Linq;
using System.Security.Claims;

namespace PizzaBox2.Client.Controllers
{
  public class LocationController : Controller
  {
    private PizzaBox2DbContext _db = new PizzaBox2DbContext();
  

    public IActionResult Index()
    {
      return View();
    }

    [HttpGet]
    public IActionResult SelectLocation()
    {
      return View(_db);
    }

    [HttpGet]
    public IActionResult ViewLocation()
    {
      foreach (var item in _db.Transactions)
      {
          if(item.Id == _db.Transactions.Count())
          {
            foreach (var l in _db.Locations)
            {
                if (item.L==l.Id)
                {
                    return View(l);
                }
            }
          }
      }
      return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult SelectLocation(Hold h)
    {
     var res = _db.Transactions.Single(c => c.Id == _db.Transactions.Count());
      
      foreach (var item in _db.Locations)
      {
          if(item.Id==h.Num)
          {
            res.L=item.Id;
            _db.Attach(res);
            
          }
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }



  }
}