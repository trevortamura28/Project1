using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox2.Data;
using PizzaBox2.Domain.Models;

namespace PizzaBox2.Client.Models
{
  public class PizzaHelper
  {
    private PizzaBox2DbContext _db = new PizzaBox2DbContext();
    private OrderHelper oh = new OrderHelper();
    
    public void PizzaBuilder(int classicId)
    {
      int tran = oh.GetTransaction();
      int o=0;
      foreach (Transaction transaction in _db.Transactions)
      {
          if (transaction.Id==tran)
          {
              o= transaction.O;
          }
      }
      Pizza p = new Pizza();
      List<int> inventoryIds = new List<int>();
      List<string> toppings = new List<string>();
      int crust=0;
      foreach (Preset pre in _db.Presets)
      {
          if (pre.Id==classicId)
          {
            crust = pre.CrustId;
          }
      }
      p.CrustId=crust;
      p.OrderId=o;
      _db.Pizzas.Add(p);
      _db.SaveChanges();
      foreach (PresetTopping pt in _db.PresetToppings)
      {
          if (pt.PresetId==classicId)
          {
              inventoryIds.Add(pt.InventoryId);
          }
      }
      foreach (int item in inventoryIds)
      {
          foreach (Inventory i in _db.Inventories)
          {
              if (item==i.Id)
              {
                  toppings.Add(i.Name);
              }
          }
      }
      oh.ReduceInventory(toppings);
      foreach (string top in toppings)
      {
          Topping t = new Topping();
          t.Name= top;
          t.PizzaId =p.Id;
          _db.Toppings.Add(t);
          _db.SaveChanges();
      }
    }
    public void PizzaFinish(int sizeId)
    {
      int pizzaId=_db.Pizzas.Count();
      var p = _db.Pizzas.Single(c => c.Id == pizzaId);
      p.SizeId = sizeId;
      foreach (Size s in _db.Sizes)
      {
          if (s.Id==sizeId)
          {
              p.Cost=p.Cost+s.Cost;
          }
      }
      foreach (Crust c in _db.Crusts)
      {
          if(c.Id==p.CrustId)
          {
            p.Cost=p.Cost+c.Cost;
          }
      }
      _db.Attach(p);
      _db.SaveChanges();
      int count=0;
      foreach (Topping t in _db.Toppings)
      {
          if (t.PizzaId==p.Id)
          {
              count++;
          }
      }
      int y = oh.SetToppingPrice(count);
    }
  }
}