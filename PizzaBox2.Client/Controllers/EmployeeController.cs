using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaBox2.Domain.Models;
using PizzaBox2.Data;
using System.Linq;
using System.Security.Claims;

namespace PizzaBox2.Client.Controllers
{
  public class EmployeeController : Controller
  {
    public PizzaBox2DbContext _db = new PizzaBox2DbContext();
    public IActionResult Index()
    {
      return View();
    }
    [HttpGet]
    public IActionResult SelectLocation()
    {
      return View(_db);
    }
    [HttpPost]
    public IActionResult SelectLocation(Hold h)
    {
      Transaction t = new Transaction();
      t.L = h.Num;
      _db.Transactions.Add(t);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public IActionResult ShowUsers()
    {
      List<int> userIDs = new List<int>();
      List<string> names = new List<string>();
      int l = 0;
      int t = _db.Transactions.Count();
      foreach (Transaction tran in _db.Transactions)
      {
        if (tran.Id == t)
        {
          l = tran.L;
        }
      }
      foreach (Transaction transaction in _db.Transactions)
      {
        if (transaction.L == l && transaction.U != 0 && !userIDs.Contains(transaction.U))
        {
          userIDs.Add(transaction.U);
        }
      }

      foreach (User user in _db.Users)
      {
        foreach (int item in userIDs)
        {
          if (user.Id == item)
          {
            string s = user.FirstName + " " + user.LastName;
            names.Add(s);
          }
        }
      }
      return View(names);
    }


    public IActionResult ShowOrders()
    {
      List<string> ordersS = new List<string>();
      List<int> intL = new List<int>();
      int lastT = _db.Transactions.Count();
      int locID = 0;
      string k = null;
      foreach (Transaction t in _db.Transactions)
      {
        if (lastT == t.Id)
        {
          locID = t.L;
        }
      }
      foreach (Order o in _db.Orders)
      {
        if (o.LocationId == locID)
        {
          intL.Add(o.Id);
        }
      }
      foreach (Pizza p in _db.Pizzas)
      {
        List<string> orderList = new List<string>();
        foreach (int i in intL)
        {
          if (p.OrderId == i)
          {
            List<string> toppings = new List<string>();
            string crust = null;
            foreach (Crust c in _db.Crusts)
            {
              if (c.Id == p.CrustId)
              {
                crust = c.Name;
              }
            }
            foreach (Topping t in _db.Toppings)
            {
              if (t.PizzaId == p.Id)
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
        
        foreach (var item in orderList)
        {
          k = k + item;
        }
        ordersS.Add(k);
      }
      return View(ordersS);
    }




  }
}