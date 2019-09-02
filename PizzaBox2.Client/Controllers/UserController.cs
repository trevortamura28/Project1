using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaBox2.Domain.Models;
using PizzaBox2.Data;
using System.Linq;
using System.Security.Claims;

namespace PizzaBox2.Client.Controllers
{
  public class UserController : Controller
  {
    private PizzaBox2DbContext _db = new PizzaBox2DbContext();

    [HttpGet]
    public IActionResult Login()
    {
      return View();
    }
    public IActionResult Index()
    {
      
      return View();
    }
    [HttpGet]
    public IActionResult NewUser()
    {
      return View();
    }
    [HttpPost]
    public IActionResult NewUser(User user)
    {
      if (ModelState.IsValid)
      {
        _db.Users.Add(user);
        _db.SaveChanges();
        Transaction t = new Transaction();
        t.U=user.Id;
        _db.Transactions.Add(t);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
      return View();

    }
    public IActionResult UserAccount()
    {
      foreach (var item in _db.Transactions)
      {
          if (item.Id == _db.Transactions.Count())
          {
            foreach (var u in _db.Users)
            {
                if (item.U==u.Id)
                {
                  return View(u);
                }
            }
           
          }
      }
      return RedirectToAction("Login");
    }
  

    [HttpPost]
    
    public IActionResult Login(User user)
    {
      
      bool b =false;
        foreach (var item in _db.Users)
        {
          if (user.FirstName == item.FirstName)
          {
            if (user.LastName == item.LastName)
            {
              Transaction T = new Transaction();
              T.U=item.Id;
              _db.Transactions.Add(T);
              b=true;
              
            }
          }
        }
        if(b==true)
        {
        _db.SaveChanges();
        return View("Index");
        }
      else
      {
      return RedirectToAction("Login");
      }
    }
  }
}