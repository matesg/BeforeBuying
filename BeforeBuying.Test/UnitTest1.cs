using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BeforeBuying.Business;

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
        public void GetItem()
        {
            Business.DBRepository2 bll = new Business.DBRepository2();
            var a = bll.GetAll(1);
        }

        [TestMethod]
        public void GetItemById()
        {
            Business.DBRepository2 bll = new Business.DBRepository2();
            var a = bll.GetItemById(1);
        }

        [TestMethod]
        public void GetItemByIdShop()
        {
            Business.DBRepository2 bll = new Business.DBRepository2();
            var a = bll.GetItemInShop(1,1);
        }
    }
}
