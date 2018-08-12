using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YapartStore.DAL.Repositories;
using YapartStore.DL.Context;

namespace YapartStore.Tests.DAL
{
    [TestClass]
    public class ProductModificationsUnitTest
    {
        [TestMethod]
        public void GetAll()
        {
            var productRep = new ProductModificationsRepository(new YapartStoreContext());

            var result = productRep.GetAll().ToList();
            var aa = 0;
        }
    }
}
