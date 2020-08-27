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
        BeforeBuyingContainer context = null;

        public DBRepository2()
        {
            context = new BeforeBuyingContainer();
        }

        public async Task<List<Item>> GetAllItemsAsync(int id)
        {
            return await context.ItemSet.ToListAsync();
            return context.ItemSet.Select(x => x).ToList();

        }

        public List<Item> GetAllItems(int id)
        {
            return context.ItemSet.Select(x => x).ToList();
        }

        public bool InsertOrUpdateItem(Item item)
        {
            context.ItemSet.Add(item);
            return true;
        }

        
        public bool InsertOrUpdateShop(Shop shop)
        {
            context.ShopSet.Add(shop);
            return true;
        }

        public bool InsertOrUpdatePrice(Price price)
        {
            context.PriceSet.Add(price);
            return true;
        }

        public bool InsertOrUpdateDiscount(Discount discount)
        {
            context.DiscountSet.Add(discount);
            return true;
        }

        public async Task<Item> GetItemById(int id)
        {
            Item item;
            item = await context.ItemSet.FirstOrDefaultAsync(x => x.Id == id);
            return item;
        }

        public List<Item> GetItemInShop(int idItem, int idShop)
        {
            List<Item> item;
            //item = context.ItemSet.Where(x => x.Id == idItem).Include(y => y.Price1).Where(z => z.Price1.)
            item = context.ItemSet.Include(x => x.Id == idItem).ToList();
            List<Price> price;
            price = context.PriceSet.Include(x => x.ItemId == idItem).ToList();

            //var query = from pricex in context.PriceSet
            //            join itemx in context.ItemSet on context.ItemSet == pricex;

            //query = from itemx in context.ItemSet
            //            join price in context.PriceSet on itemx equals price.Item
            //            join shop in context.ShopSet on
            //            new { Owner = itemx, Letter = price.PriceInclVAT }
            //            equals new { shop.Owner, Letter = shopx.Name }
            //            select new { CatName = price.PriceInclVAT, DogName = price.PricePerUnit };

            return item;
        }

        public bool Save()
        {
            bool retVal = false;
            try
            {
                context.SaveChanges();
                retVal = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return retVal;
        }
        public async Task<bool> SaveAsync()
        {
            bool retVal = false;
            try
            {
                await context.SaveChangesAsync();
                retVal = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return retVal;
        }
    }
}
