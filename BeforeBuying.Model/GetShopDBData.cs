using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeforeBuying.Model
{
    public class GetShopDBData
    {
        BeforeBuyingContainer context = null;

        public GetShopDBData()
        {
            context = new BeforeBuyingContainer();
        }

        #region Shop
        public List<ShopDataContract> GetShops()
        {
            List<ShopDataContract> shops = new List<ShopDataContract>();
            List<Shop> shopsTmp = new List<Shop>();
            
            try
            {
                shopsTmp = context.ShopSet.ToList();
                foreach (var item in shopsTmp)
                {
                    ShopDataContract shopTmp = new ShopDataContract();
                    shopTmp.Name = item.Name;
                    shopTmp.Id = item.Id;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return shops;
        }

        public bool SetShop(ShopDataContract shopDC)
        {
            Shop shopEF = new Shop();

            shopEF.Name = shopDC.Name;
            //shopEF.Price = shopDC. Price;
            try
            {
                context.ShopSet.Add(shopEF);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            

            return true;
        }

        public bool UpdateShop(ShopDataContract shopDC)
        {
            Shop shopEF = new Shop();
            shopEF = context.ShopSet.FirstOrDefault(x => x.Id == shopDC.Id);
            shopEF.Name = shopDC.Name;
            //shopEF.Id = shopDC.Id;
            //shopEF.Price = shopDC. Price;
            try
            {
                //context.ShopSet.Add(shopEF);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }


            return true;
        }

        #endregion Shop

        #region Price
        public List<PriceDataContract> GetPricesByItem(int? itemId)
        {
            List<PriceDataContract> pricessDC = new List<PriceDataContract>();

            List<Price> pricesEF = context.PriceSet.Where(x => x.ItemId == itemId).ToList();
            foreach (var priceEF in pricesEF)
            {
                PriceDataContract priceDC = new PriceDataContract();
                //priceDC.Discount = priceEF.Discount;
                //priceDC.DiscountsId = priceEF.DiscountId;
                priceDC.Id = priceEF.Id;
                //priceDC.Item = priceEF.Item;
                priceDC.ItemId = priceEF.ItemId;
                priceDC.PriceInclVAT = priceEF.PriceInclVAT;
                priceDC.PricePerUnit = priceEF.PricePerUnit;
                //priceDC.Shop = priceEF.Shop;
                priceDC.ShopId = priceEF.ShopId;

                pricessDC.Add(priceDC);
            }

            return pricessDC;
        }

        public bool SetPrice(PriceDataContract priceDC)
        {
            Price priceEF = new Price();

            priceEF.PriceInclVAT = priceDC.PriceInclVAT;
            priceEF.PricePerUnit = priceDC.PricePerUnit;
            
            //itemEF.Price1 = itemDC.Price1;

            try
            {
                context.PriceSet.Add(priceEF);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }


            return true;
        }

        public bool UpdatePrice(PriceDataContract priceDC)
        {
            Price priceEF = new Price();
            priceEF = context.PriceSet.FirstOrDefault(x => x.Id == priceDC.Id);
            priceEF.PriceInclVAT = priceDC.PriceInclVAT;
            priceEF.PricePerUnit = priceDC.PricePerUnit;
            //priceEF.UnitOfMeasure = itemDC.UnitOfMeasure;

            //itemEF.Price1 = itemDC.Price1;
            try
            {
                //context.ShopSet.Add(shopEF);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }


            return true;
        }

        #endregion Price

        #region Items
        public List<ItemDataContract> getItems()
        {
            List<ItemDataContract> itemsDC = new List<ItemDataContract>();

            List<Item> itemsEF = context.ItemSet.ToList();
            foreach (var item in itemsEF)
            {
                ItemDataContract itemDC = new ItemDataContract();
                itemDC.EAN = item.EAN;
                itemDC.Id = item.Id;
                itemDC.Name = item.Name;
                //todo
                //itemDC.Price1 = item.Price1.ToList();
                //itemDC.PriceId
                itemDC.UnitOfMeasure = item.UnitOfMeasure;

                itemsDC.Add(itemDC);
            }

            return itemsDC;
            
        }

        public ItemDataContract GetItemById(int itemId)
        {
            var itemEF = context.ItemSet.FirstOrDefault(x => x.Id == itemId);
            ItemDataContract itemDC = new ItemDataContract();
            itemDC.EAN = itemEF.EAN;
            itemDC.Id = itemEF.Id;
            itemDC.Name = itemEF.Name;
            //todo
            //itemDC.Price1 = item.Price1.ToList();
            //itemDC.PriceId
            itemDC.UnitOfMeasure = itemEF.UnitOfMeasure;

            return itemDC;
        }

        public bool SetItem(ItemDataContract itemDC)
        {
            Item itemEF = new Item();

            itemEF.Name = itemDC.Name;
            itemEF.EAN = itemDC.EAN;
            itemEF.UnitOfMeasure = itemDC.UnitOfMeasure;
            //itemEF.Price1 = itemDC.Price1;
            
            try
            {
                context.ItemSet.Add(itemEF);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }


            return true;
        }

        public bool UpdateItem(ItemDataContract itemDC)
        {
            Item itemEF = new Item();
            itemEF = context.ItemSet.FirstOrDefault(x => x.Id == itemDC.Id);
            itemEF.Name = itemDC.Name;
            itemEF.EAN = itemDC.EAN;
            itemEF.UnitOfMeasure = itemDC.UnitOfMeasure;
            
            //itemEF.Price1 = itemDC.Price1;
            try
            {
                //context.ShopSet.Add(shopEF);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }


            return true;
        }

        #endregion Items

        #region Discount

        public List<DiscountDataContract> GetDiscountByPrice(int priceId)
        {
            List<DiscountDataContract> discountsDC = new List<DiscountDataContract>();

            List<Discount> discountsEF = context.DiscountSet.Where(x => x.PriceId == priceId).ToList();
            foreach (var item in discountsEF)
            {
                DiscountDataContract discountDataContract = new DiscountDataContract();
                discountDataContract.DiscountFrom = item.DiscountFrom;
                discountDataContract.DiscountTo = item.DiscountTo;
                discountDataContract.Id = item.Id;
                discountDataContract.Percent = item.Percent;
                //discountDataContract.Price = item.Price;
                discountDataContract.PriceId = item.PriceId;
                discountDataContract.PriceInclVAT = item.PriceInclVAT;

                discountsDC.Add(discountDataContract);
            }
            

            return discountsDC;
        }

        public bool SetDiscount(DiscountDataContract discountDC)
        {
            Discount discountEF = new Discount();

            discountEF.PriceInclVAT = discountDC.PriceInclVAT;
            discountEF.Percent = discountDC.Percent;
            discountEF.DiscountFrom = discountDC.DiscountFrom;
            discountEF.DiscountTo = discountDC.DiscountTo;

            //itemEF.Price1 = itemDC.Price1;

            try
            {
                context.DiscountSet.Add(discountEF);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }


            return true;
        }

        public bool UpdateDiscount(DiscountDataContract discountDC)
        {
            Discount discountEF = new Discount();
            discountEF = context.DiscountSet.FirstOrDefault(x => x.Id == discountDC.Id);
            discountEF.PriceInclVAT = discountDC.PriceInclVAT;
            discountEF.Percent = discountDC.Percent;
            discountEF.DiscountFrom = discountDC.DiscountFrom;
            discountEF.DiscountTo = discountDC.DiscountTo;
            //priceEF.UnitOfMeasure = itemDC.UnitOfMeasure;

            //itemEF.Price1 = itemDC.Price1;
            try
            {
                //context.ShopSet.Add(shopEF);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }


            return true;
        }
        #endregion Discount
    }

}
