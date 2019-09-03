using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox2.Data;
using PizzaBox2.Domain.Models;

namespace PizzaBox2.Client.Models
{
  public class OrderHelper
  {
    private PizzaBox2DbContext _db = new PizzaBox2DbContext();
    public List<string> ToppingFinder()
    {
      List<string> t = new List<string>();
      int l = GetLocation();
      foreach (Inventory i in _db.Inventories)
      {
        if (i.LocationId == l)
        {
          t.Add(i.Name);
        }
      }
      return t;
    }
    public int GetTransaction()
    {
      int i = _db.Transactions.Count();
      return i;
    }
    public User GetUser()
    {
      int i = GetTransaction();
      int u = 0;
      User currentUser = new User();
      foreach (Transaction t in _db.Transactions)
      {
        if (t.Id == i)
        {
          u = t.U;
        }
      }
      foreach (User user in _db.Users)
      {
        if (user.Id == u)
        {
          currentUser = user;
        }
      }
      return currentUser;
    }
    public int GetLocation()
    {
      int i = GetTransaction();
      foreach (Transaction t in _db.Transactions)
      {
        if (i == t.Id)
        {
          return t.L;
        }
      }
      return 0;
    }
    public List<string> PizzaSentence(int orderId)
    {
      List<string> orderlist = new List<string>();
      foreach (Pizza p in _db.Pizzas)
      {
        List<string> toppings = new List<string>();
        string crust = null;
        string size = null;
        if (p.OrderId == orderId)
        {

          foreach (Crust c in _db.Crusts)
          {
            if (c.Id == p.CrustId)
            {
              crust = c.Name;
            }
          }
          foreach (Size s in _db.Sizes)
          {
            if (s.Id == p.SizeId)
            {
              size = s.Name;
            }
          }
          foreach (Topping t in _db.Toppings)
          {
            if (t.PizzaId == p.Id)
            {
              toppings.Add(t.Name);
            }
          }
          string pizzaSentence = "A " + size + " pizza with " + crust + " crust, topped with ";
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
          orderlist.Add(pizzaSentence);
        }
      }
      return orderlist;
    }
    public int SetToppingPrice(int size)
    {
      int pid = _db.Pizzas.Count();
      var p = _db.Pizzas.Single(c => c.Id == pid);
      if (size == 0 || size == 1 || size == 2)
      {

      }
      else
      {
        switch (size)
        {
          case 3:
            {
              p.Cost = p.Cost + 1;
              break;
            }
          case 4:
            {
              p.Cost = p.Cost + 2;
              break;
            }
          default:
            {
              p.Cost = p.Cost + 3;
              break;
            }
        }
      }
      _db.Attach(p);
      _db.SaveChanges();
      return pid;
    }
    public void ReduceInventory(List<string> l)
    {
      int location = GetLocation();
      foreach (string s in l)
      {
        foreach (Inventory i in _db.Inventories)
        {
          if (s == i.Name && location == i.LocationId)
          {
            Inventory item = _db.Inventories.Single(id => id.Id == i.Id);
            item.Count = item.Count - 1;
            _db.Attach(item);
            _db.SaveChanges();
          }
        }
      }
    }
    public List<List<string>> AccountHistory()
    {
      List<List<string>> list = new List<List<string>>();
      foreach (Order o in _db.Orders)
      {
        if (o.User == GetUser())
        {
          List<string> temp = PizzaSentence(o.Id);
          list.Add(temp);
        }
      }
      return list;
    }
  }
}