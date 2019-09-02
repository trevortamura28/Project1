using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaBox2.Domain.Models;
using PizzaBox2.Data;
using System.Linq;
using System.Security.Claims;

namespace PizzaBox2.Client.Controllers
{
  public class OrderController : Controller
  {
    public PizzaBox2DbContext _db = new PizzaBox2DbContext();


    [HttpGet]
    public IActionResult Index()
    {
      return View();
    }
    [HttpPost]
    public IActionResult Index(Hold h)
    {
      switch (h.Num)
      {
        case 1:
          {
            return RedirectToAction("CustomSize");
          }
        case 2:
          {
            return RedirectToAction("OrderConfirm");
          }
        default:
          {
            return View();
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
      return RedirectToAction("CustomSize");
    }


    [HttpGet]
    public IActionResult CustomSize()
    {
      return View();
    }

    [HttpPost]
    public IActionResult CustomSize(Pizza p)
    {
      Pizza pizza = new Pizza();
      pizza.SizeName = p.SizeName;
      foreach (var t in _db.Transactions)
      {
        if (t.Id == _db.Transactions.Count())
        {
          pizza.OrderId = t.O;
        }
      }
      switch (pizza.SizeName)
      {
        case "Traditional":
          {
            pizza.Cost = 6;
            break;
          }
        case "Thin":
          {
            pizza.Cost = 8;
            break;
          }

        default:
          {
            pizza.Cost = 10;
            break;
          }
      }
      _db.Pizzas.Add(pizza);
      _db.SaveChanges();
      return RedirectToAction("CustomCrust");
    }

    [HttpGet]
    public IActionResult CustomCrust()
    {
      return View();
    }

    [HttpPost]
    public IActionResult CustomCrust(Crust c)
    {
      Crust crust = new Crust();
      crust.Name = c.Name;
      switch (crust.Name)
      {
        case "Traditional":
          {
            crust.Cost = 0;
            break;
          }
        case "Thin":
          {
            crust.Cost = 0;
            break;
          }

        default:
          {
            crust.Cost = 2;
            break;
          }
      }
      _db.Crusts.Add(crust);
      _db.SaveChanges();
      var p = _db.Pizzas.Single(j => j.Id == _db.Pizzas.Count());
      p.CrustId = crust.Id;
      _db.Attach(p);
      _db.SaveChanges();
      return RedirectToAction("CustomTopping");
    }

    [HttpGet]
    public IActionResult CustomTopping()
    {
      return View();
    }

    [HttpPost]
    public IActionResult CustomTopping(DeliveryTruck t)
    {
      int i = _db.Pizzas.Count();
      var p = _db.Pizzas.Single(c => c.Id == _db.Pizzas.Count());
      switch(t.List.Count())
      {
        case 0:
        {
          break;
        }
        case 1:
        {
          break;
        }
        case 2:
        {
          break;
        }
        case 3:
        {
          p.Cost= p.Cost+1;
          break;
        }
        case 4:
        {
          p.Cost=p.Cost+2;
          break;
        }
        default:
        {
          p.Cost=p.Cost+3;
          break;
        }
      }
      _db.Pizzas.Attach(p);
      foreach (var toppingName in t.List)
      {
        Topping x = new Topping();
        x.PizzaId = i;
        x.Name = toppingName;
        _db.Toppings.Add(x);
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public IActionResult OrderConfirm()
    {
      string s = "Your order is:";
      List<string> orderList = new List<string>();
      orderList.Add(s);
      var o1 = _db.Orders.Single(z => z.Id == _db.Orders.Count());
      int oid = _db.Orders.Count();
      foreach (Pizza p in _db.Pizzas)
      {
        List<string> toppings = new List<string>();
        string crust = null;
        if (p.OrderId == oid)
        {
          o1.Cost=o1.Cost+p.Cost;
          int pid = p.Id;
          foreach (Crust c in _db.Crusts)
          {
            if (c.Id == p.CrustId)
            {
              crust = c.Name;
            }
          }
          foreach (Topping t in _db.Toppings)
          {
            if (t.PizzaId == pid)
            {
              toppings.Add(t.Name);
            }
          }
          string pizzaSentence = "A " + p.SizeName + " pizza with " + crust + " crust, topped with ";
          int count = 0;
          foreach (string top in toppings)
          {
            if (count == 0)
            {
              pizzaSentence = pizzaSentence + top;
              count++;
            }
            else if (count == (toppings.Count() - 1))
            {
              pizzaSentence = pizzaSentence + " and " + top + ".";
            }
            else
            {
              pizzaSentence = pizzaSentence + ", " + top;
              count++;
            }
          }
          orderList.Add(pizzaSentence);
        }
      }
      decimal cost = o1.Cost;
      _db.Orders.Attach(o1);
      ViewBag.MyString = orderList;
      return View(cost);
    }


  }
}