using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaBox2.Client.Models;
using PizzaBox2.Domain.Models;

namespace PizzaBox2.Client.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
      public IActionResult Account()
    {
      OrderHelper oh = new OrderHelper();
      User currentUser= oh.GetUser();
      ViewBag.list = oh.AccountHistory();
      return View(currentUser);
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
