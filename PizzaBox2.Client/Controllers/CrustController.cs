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
      public IActionResult Create()
      {
        return View();
      }
      public ViewResult Read()
      {
        return View(_db.Crusts.ToList());
      }

      [HttpPost]
      public IActionResult Create(Crust crust)
      {
        if(ModelState.IsValid)
        {
        _db.Crusts.Add(crust);
        _db.SaveChanges();
        
        return RedirectToAction("Read");
        }
        return RedirectToAction("Create");
      }

      [HttpPut]
      public IActionResult Update(Crust crust)
      {
        var res=_db.Crusts.Single(c=>c.Id==crust.Id);
        res.Name= crust.Name;
        res.Cost= crust.Cost;
        _db.Attach(crust);
        _db.SaveChanges();

        return RedirectToAction("Read");
      }
      [HttpGet("{id}")]
      public IActionResult Update(int id)
      {

        return View(_db.Crusts.Single(c=>c.Id==id));
      }
    }
}