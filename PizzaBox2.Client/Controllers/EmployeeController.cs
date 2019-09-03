using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaBox2.Domain.Models;
using PizzaBox2.Data;
using System.Linq;
using System.Security.Claims;
using PizzaBox2.Client.Models;

namespace PizzaBox2.Client.Controllers
{
  public class EmployeeController : Controller
  {
    private PizzaBox2DbContext _db = new PizzaBox2DbContext();
    public IActionResult Index()
    {
      return View();
    }
    [HttpGet]
    public IActionResult SelectLocation()
    {
      ViewBag.Locations=_db.Locations;
      return View();
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
      OrderHelper oh = new OrderHelper();
      List<int> userIDs = new List<int>();
      List<string> names = new List<string>();
     int l = oh.GetLocation();
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
      OrderHelper oh = new OrderHelper();
      List<List<string>> list = new List<List<string>>();
      int l = oh.GetLocation();
      foreach (Order o in _db.Orders)
      {
        if (o.LocationId == l)
        {
          List<string> temp = oh.PizzaSentence(o.Id);
          list.Add(temp);
        }
      }
      ViewBag.list = list;
      return View();
    }
    public IActionResult ShowSales()
    {
      OrderHelper oh = new OrderHelper();
      int l = oh.GetLocation();
      List<decimal> list = new List<decimal>();
      foreach (Order o in _db.Orders)
      {
        if (o.LocationId == l)
        {
          list.Add(o.Cost);
        }
      }
      ViewBag.costs=list;
      return View();
    }

    public IActionResult ShowInventory()
    {
      OrderHelper oh = new OrderHelper();
      int l = oh.GetLocation();
      List<Inventory> list = new List<Inventory>();
       foreach (Inventory i in _db.Inventories)
      {
        if (i.LocationId == l)
        {
          list.Add(i);
        }
      }
      ViewBag.inventories=list;
      return View();
    }
    
  }
}