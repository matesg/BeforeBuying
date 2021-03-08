using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using BeforeBuying.Model;

namespace BeforeBuying.Business
{
    public class DBRepository2
    {
        public List<ShopDataContract> GetShops()
        {
            GetShopDBData dBRepository = new GetShopDBData();

            List<ShopDataContract> shops = new List<ShopDataContract>();
            
            
            try
            {   
                shops = dBRepository.GetShops();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return shops;
        }

        public ShopDataContract SetShop(ShopDataContract shopDataContract)
        {
            GetShopDBData dBRepository = new GetShopDBData();

            bool retVal = false;


            try
            {
                retVal = dBRepository.SetShop(shopDataContract);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return shopDataContract;
        }

        public ShopDataContract UpdateShop(ShopDataContract shopDataContract)
        {
            GetShopDBData dBRepository = new GetShopDBData();

            bool retVal = false;


            try
            {
                retVal = dBRepository.UpdateShop(shopDataContract);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return shopDataContract;
        }

        //BeforeBuyingContainer context = null;

        //public DBRepository2()
        //{
        //    context = new BeforeBuyingContainer();
        //}

        public async Task<List<ItemDataContract>> GetAllItemsAsync(/*int id*/)
        {

            GetShopDBData dbRepository = new GetShopDBData();

            List<ItemDataContract> items = new List<ItemDataContract>();

            try
            {
                items = dbRepository.getItems();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return items;
            //    context.ItemSet.ToListAsync();
            //return context.ItemSet.Select(x => x).ToList();

        }

        public async Task<ItemDataContract> GetItemByIdAsync(int itemId)
        {
            GetShopDBData dbRepository = new GetShopDBData();
            ItemDataContract itemDataContract = new ItemDataContract();

            itemDataContract = dbRepository.GetItemById(itemId);
            return itemDataContract;
            
        }

        public List<ItemDataContract> GetAllItems(/*int id*/)
        {
            GetShopDBData dbRepository = new GetShopDBData();

            List<ItemDataContract> items = new List<ItemDataContract>();

            try
            {
                items = dbRepository.getItems();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return items;
            //List<ItemDataContract> itemDataContract = new List<ItemDataContract>();

            //return context.ItemSet.Select(x => x).ToList();
        }

        //public bool InsertOrUpdateItem(Item item)
        //{
        //    context.ItemSet.Add(item);

        //    return true;
        //}

        //public List<Shop> GetShops()
        //{
        //    List<Shop> shops = new List<Shop>();
        //    try
        //    {
        //        shops = context.ShopSet.ToList();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //    return shops;
        //}

        //public async Task<List<Shop>> GetShopsAsync()
        //{
        //    return await context.ShopSet.ToListAsync();
        //}

        //public bool InsertOrUpdateShop(Shop shop)
        //{
        //    context.ShopSet.Add(shop);
        //    return true;
        //}

        //public List<Price> GetPrices()
        //{
        //    return context.PriceSet.ToList();
        //}

        public List<PriceDataContract> GetPricesByItem(int? itemId)
        {
            GetShopDBData dbRepository = new GetShopDBData();

            List<PriceDataContract> prices = new List<PriceDataContract>();

            try
            {
                prices = dbRepository.GetPricesByItem(itemId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return prices; 
                //context.PriceSet.Where(x => x.ItemId == itemId).ToList();
        }

        //public async Task<List<Price>> GetPricesAsync()
        //{
        //    return await context.PriceSet.ToListAsync();
        //}

        //public bool InsertOrUpdatePrice(Price price)
        //{
        //    context.PriceSet.Add(price);
        //    return true;
        //}

        //public List<Discount> GetDiscounts()
        //{
        //    return context.DiscountSet.ToList();
        //}

        //public async Task<List<Discount>> GetDiscountsAsync()
        //{
        //    return await context.DiscountSet.ToListAsync();
        //}

        //public bool InsertOrUpdateDiscount(Discount discount)
        //{
        //    context.DiscountSet.Add(discount);
        //    return true;
        //}

        //public async Task<Item> GetItemById(int id)
        //{
        //    Item item;
        //    item = await context.ItemSet.FirstOrDefaultAsync(x => x.Id == id);
        //    return item;
        //}

        //public List<Item> GetItemInShop(int idItem, int idShop)
        //{
        //    List<Item> item;
        //    //item = context.ItemSet.Where(x => x.Id == idItem).Include(y => y.Price1).Where(z => z.Price1.)
        //    item = context.ItemSet.Include(x => x.Id == idItem).ToList();
        //    List<Price> price;
        //    price = context.PriceSet.Include(x => x.ItemId == idItem).ToList();

        //    //var query = from pricex in context.PriceSet
        //    //            join itemx in context.ItemSet on context.ItemSet == pricex;

        //    //query = from itemx in context.ItemSet
        //    //            join price in context.PriceSet on itemx equals price.Item
        //    //            join shop in context.ShopSet on
        //    //            new { Owner = itemx, Letter = price.PriceInclVAT }
        //    //            equals new { shop.Owner, Letter = shopx.Name }
        //    //            select new { CatName = price.PriceInclVAT, DogName = price.PricePerUnit };

        //    return item;
        //}

        //public bool Save()
        //{
        //    bool retVal = false;
        //    try
        //    {
        //        context.SaveChanges();
        //        retVal = true;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }

        //    return retVal;
        //}

        //public async Task<bool> SaveAsync()
        //{
        //    bool retVal;
        //    try
        //    {
        //        await context.SaveChangesAsync();
        //        retVal = true;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }

        //    return retVal;
        //}
    }
}
