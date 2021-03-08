using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BeforeBuying.Business;
using System.Threading.Tasks;
using BeforeBuying.Model;
using System.Collections.Generic;
using System.Linq;

namespace BeforeBuying.Test
{
    [TestClass]
    public class UnitTest1
    {
        public Model.BeforeBuyingContainer _context = new Model.BeforeBuyingContainer();

        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void SetShp()
        {
            Business.DBRepository2 bll = new Business.DBRepository2();
            ShopDataContract shopDataContract = new ShopDataContract();
            shopDataContract.Name = "Carefour";
            
            var a = bll.SetShop(shopDataContract);
        }

        [TestMethod]
        public void UpdateShp()
        {
            Business.DBRepository2 bll = new Business.DBRepository2();
            ShopDataContract shopDataContract = new ShopDataContract();
            shopDataContract.Name = "Carefours";
            shopDataContract.Id = 5;

            var a = bll.UpdateShop(shopDataContract);
        }

        [TestMethod]
        public void GetItem()
        {
            Business.DBRepository2 bll = new Business.DBRepository2();
            var a = bll.GetAllItems();
        }

        [TestMethod]
        public void GetItemsAsync()
        {
            Business.DBRepository2 bll = new Business.DBRepository2();
            var a = bll.GetAllItemsAsync().Result;
        }

        [TestMethod]
        public  void GetItemById(int itemId)
        {
            Business.DBRepository2 bll = new Business.DBRepository2();
            //Task t = bll.GetItemById(1);
            
            var a =  bll.GetItemByIdAsync(itemId).Result;
        }

        //[TestMethod]
        //public void GetItemByIdShop()
        //{
        //    Business.DBRepository2 bll = new Business.DBRepository2();
        //    var a = bll.GetItemInShop(1,1);
        //}

        //[TestMethod]
        //public void GetShops()
        //{
        //    Business.DBRepository2 bll = new Business.DBRepository2();
        //    var a = bll.GetShopsAsync().Result;
        //}

        //[TestMethod]
        //public void SetShop()
        //{

        //    Business.DBRepository2 bll = new Business.DBRepository2();
        //    Model.Shop shop = new Model.Shop();
        //    shop.Name = "Lidl";
        //    //shop.Price = new Model.Price { }
        //    try
        //    {
        //        var a = bll.InsertOrUpdateShop(shop);
        //        bll.Save();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //        throw;
        //    }
            
        //}

        //[TestMethod]
        //public void SetItem()
        //{

        //    Business.DBRepository2 bll = new Business.DBRepository2();
        //    Model.Item item = new Model.Item();
        //    item.EAN = "159951";
        //    item.Name = "rybie prsty";
        //    //item.Price1
        //    item.UnitOfMeasure = "kg";

        //    //shop.Price = new Model.Price { }
        //    try
        //    {
        //        var a = bll.InsertOrUpdateItem(item);
        //        bll.Save();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //        throw;
        //    }

        //}

        //[TestMethod]
        //public void SetPrice()
        //{

        //    Business.DBRepository2 bll = new Business.DBRepository2();
        //    Model.Price price = new Model.Price();
        //    price.ItemId = 4;
        //    price.PriceInclVAT = 3.25m;
        //    price.PricePerUnit = 1.11m;
        //    price.ShopId = 1;
            

        //    //shop.Price = new Model.Price { }
        //    try
        //    {
        //        var a = bll.InsertOrUpdatePrice(price);
        //        bll.Save();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //        throw;
        //    }

        //}

        //[TestMethod]
        //public void SetDiscount()
        //{

        //    Business.DBRepository2 bll = new Business.DBRepository2();
        //    Model.Discount discount = new Model.Discount();
        //    discount.DiscountFrom = (DateTime)DateTime.Now;
        //    discount.Percent = 5;
        //    discount.PriceId = 4;
        //    discount.PriceInclVAT = 15.4m;

        //    //shop.Price = new Model.Price { }
        //    try
        //    {
        //        var a = bll.InsertOrUpdateDiscount(discount);
        //        bll.Save();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //        throw;
        //    }

        //}

        //[TestMethod]
        //public void SetAll()
        //{

        //    Business.DBRepository2 bll = new Business.DBRepository2();

        //    Model.Shop shop = new Model.Shop();
        //    shop.Name = "Lidl";

        //    Model.Item item = new Model.Item();
        //    item.EAN = "159951";
        //    item.Name = "rybie prsty";
        //    //item.Price1
        //    item.UnitOfMeasure = "kg";

        //    Model.Price price = new Model.Price();
        //    price.Item = item;
        //    price.PriceInclVAT = 3.25m;
        //    price.PricePerUnit = 1.11m;
        //    price.Shop = shop;

        //    Model.Discount discount = new Model.Discount();
        //    discount.DiscountFrom = (DateTime)DateTime.Now;
        //    discount.Percent = 5;
        //    discount.Price = price;
        //    discount.PriceInclVAT = 15.4m;

        //    //shop.Price = new Model.Price { }
        //    try
        //    {
        //        var a = bll.InsertOrUpdateDiscount(discount);
        //        bll.InsertOrUpdatePrice(price);
        //        bll.InsertOrUpdateShop(shop);
        //        bll.InsertOrUpdateItem(item);
                
                
        //        bll.Save();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //        throw;
        //    }

        //}

        //[TestMethod]
        //public void GetCheaperFromShop()
        //{
        //    int itemId = 1;
        //    Business.DBRepository2 bll = new DBRepository2();
        //    List<Nakup> nakupy = new List<Nakup>();
        //    Item item = bll.GetItemById(itemId).Result;

        //    int polozka = 0;
        //    try
        //    {
        //        polozka = nakupy.Select(x => x.Polozka).DefaultIfEmpty(0).Max();
        //        polozka++;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }
            

        //    List<Price> prices = bll.GetPricesByItem(item.Id);
        //    foreach (var price in prices)
        //    {
        //        Nakup nakup = new Nakup();
        //        nakup.Cena = price.PriceInclVAT;
        //        nakup.ItemId = price.ItemId;
        //        nakup.ShopId = price.ShopId;
        //        nakup.Kusov = 5;
        //        nakup.Polozka = polozka;

        //        nakupy.Add(nakup);

        //    }

        //    //druha polozka
        //    itemId = 1;
        //    try
        //    {
        //        polozka = nakupy.Select(x => x.Polozka).DefaultIfEmpty(0).Max();
        //        polozka++;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }


        //    prices = bll.GetPricesByItem(item.Id);
        //    foreach (var price in prices)
        //    {
        //        Nakup nakup = new Nakup();
        //        nakup.Cena = price.PriceInclVAT;
        //        nakup.ItemId = price.ItemId;
        //        nakup.ShopId = price.ShopId;
        //        nakup.Kusov = 5;
        //        nakup.Polozka = polozka;

        //        nakupy.Add(nakup);

        //    }

        //    //tretia polozka
        //    itemId = 5;
        //    try
        //    {
        //        polozka = nakupy.Select(x => x.Polozka).DefaultIfEmpty(0).Max();
        //        polozka++;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }


        //    prices = bll.GetPricesByItem(item.Id);
        //    foreach (var price in prices)
        //    {
        //        Nakup nakup = new Nakup();
        //        nakup.Cena = price.PriceInclVAT;
        //        nakup.ItemId = price.ItemId;
        //        nakup.ShopId = price.ShopId;
        //        nakup.Kusov = 5;
        //        nakup.Polozka = polozka;

        //        nakupy.Add(nakup);

        //    }
        //}
    }
}
