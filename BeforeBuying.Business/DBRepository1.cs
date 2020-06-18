using BeforeBuying.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeforeBuying.Business
{
    public class DBRepository1<TEntity, TContext>
         where TEntity : class
        where TContext : DbContext
    {
        private BeforeBuying.Model.BeforeBuyingContainer _context = null;

        public DBRepository1()
        {
            _context = new BeforeBuyingContainer();
        }

        public T GetData<T>(int id)
        {
            
            var value = _context.ItemSet.FirstOrDefault(x => x.Id == id);
            
                //_context.Set<TEntity>().FirstOrDefault(x => x.I)
            return (T)Convert.ChangeType(value, typeof(T));
        }

        public Price GetPriceById(int id)
        {
            Price price = _context.PriceSet.FirstOrDefault(x => x.Id == id);
            return price;
        }

        public Item GetItemById(int id)
        {
            Item item = _context.ItemSet.FirstOrDefault(x => x.Id == id);
            return item;
        }

        public Shop GetShopById(int id)
        {
            Shop shop = _context.ShopSet.FirstOrDefault(x => x.Id == id);
            return shop;
        }

        public Discount GetDiscountById(int id)
        {
            Discount discount = _context.DiscountSet.FirstOrDefault(x => x.Id == id);
            return discount;
        }
    }
}
