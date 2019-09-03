using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaBox2.Domain.Models;
using PizzaBox2.Data;
using System.Linq;
using System.Security.Claims;
using PizzaBox2.Client.Models;

namespace PizzaBox2.Client.Controllers
{
  public class OrderController : Controller
  {
    private PizzaBox2DbContext _db = new PizzaBox2DbContext();
    [HttpGet]
    public IActionResult Index()
    {
      OrderHelper oh = new OrderHelper();
      int tran = oh.GetTransaction();
      int oid=0;
      int count=0;
      decimal cost=0;
      foreach (Transaction t in _db.Transactions)
      {
          if (t.Id==tran)
          {
              foreach (Order o in _db.Orders)
              {
                  if (o.Id==t.O)
                  {
                      oid=o.Id;
                  }
              }
          }
      }
      foreach (Pizza p in _db.Pizzas)
      {
          if (p.OrderId==oid)
          {
              count++;
              cost=cost+p.Cost;
          }
      }
      if(count >= 100)
      {
        return RedirectToAction("OrderConfirm");
      }
      else
      {
        ViewBag.cost=cost;
        ViewBag.list=oh.PizzaSentence(oid);
        return View();
      }
    }
    [HttpPost]
    public IActionResult Index(Hold h)
    {
      switch (h.Num)
      {
        case 1:
          {
            return RedirectToAction("CustomOrPreset", "Pizza", new { area = "Admin" });
          }
        default:
          {
            return RedirectToAction("OrderConfirm");
          }
      }
    }
    public IActionResult Welcome()
    {
      var t = _db.Transactions.Single(c => c.Id == _db.Transactions.Count());
      Order O = new Order();
      foreach (var u in _db.Users)
      {
        if (t.U == u.Id)
        {
          O.User = u;
        }
      }
      foreach (Location l in _db.Locations)
      {
        if (t.L == l.Id)
        {
          O.LocationId = l.Id;
        }
      }
      _db.Orders.Add(O);
      _db.SaveChanges();
      t.O = O.Id;
      _db.Attach(t);
      _db.SaveChanges();
      return RedirectToAction("CustomOrPreset", "Pizza", new { area = "Admin"});
    }
    public IActionResult OrderConfirm()
    {
      OrderHelper oh = new OrderHelper();
      int i = oh.GetTransaction();
      int oid = 0;
      foreach (Transaction t in _db.Transactions)
      {
        if (t.Id == i)
        {
          oid = t.O;
        }
      }
      decimal total = 0;
      foreach (Pizza p in _db.Pizzas)
      {
        if (p.OrderId == oid)
        {
          total = total + p.Cost;
        }
      }
      Order o = _db.Orders.Single(c => c.Id == oid);
       o.Cost=total;
      _db.Attach(o);
      _db.SaveChanges();
      ViewBag.MyString = oh.PizzaSentence(oid);
      return View(total);
    }
  }
}