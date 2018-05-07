using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YapartStore.BL.Services;
using YapartStore.DAL.Repositories;
using YapartStore.DAL.Repositories.Base;

namespace YapartStore.Tests.BL
{
    [TestClass]
    public class BLUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var unitOfWork = (IUnitOfWork)new UnitOfWork();
            var productService = new ProductService(unitOfWork);

            var result = productService.GetAll();
        }
    }
}
