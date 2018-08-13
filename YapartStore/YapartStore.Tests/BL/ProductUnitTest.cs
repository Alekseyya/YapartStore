using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YapartStore.BL.Services;
using YapartStore.DAL.Repositories;
using YapartStore.DAL.Repositories.Base;

namespace YapartStore.Tests.BL
{
    [TestClass]
    public class ProductUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var unitOfWork = (IUnitOfWork)new UnitOfWork();
            var productService = new ProductService(unitOfWork);

            var result = productService.GetProductsByModification("4B/C5");
        }

        [TestMethod]
        public void GetSizeOfCapsTest()
        {
            var unitOfWork = (IUnitOfWork)new UnitOfWork();
            var productService = new ProductService(unitOfWork);

            var result = productService.GetSizeOfCaps(14);

        }

        [TestMethod]
        public async Task GetProductsByModification()
        {
            var unitOfWork = (IUnitOfWork)new UnitOfWork();
            var productService = new ProductService(unitOfWork);

            var result = await productService.GetProductsByModification("4B/C5");
            var aa = 0;
        }


        [TestMethod]
        public async Task GetProductsByModel()
        {
            var unitOfWork = (IUnitOfWork)new UnitOfWork();
            var productService = new ProductService(unitOfWork);

            var result = await productService.GetProductsByModel("A6");
            var aa = 0;
        }

    }
}
