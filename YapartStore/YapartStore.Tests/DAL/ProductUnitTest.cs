using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YapartStore.DAL.Repositories;
using YapartStore.DAL.Repositories.Base;
using YapartStore.DL.Context;

namespace YapartStore.Tests.DAL
{
    [TestClass]
    public class ProductUnitTest
    {
        [TestMethod]
        public void ProductGetAllTest()
        {
            var productRepository = new ProductRepository(new YapartStoreContext());
            var result = productRepository.GetAll().ToList();
        }
        [TestMethod]
        public void ProductGetAllIncludeBrandTest()
        {
            var productRepository = new ProductRepository(new YapartStoreContext());
            var result = productRepository.GetAllProductsIncludeBrand().ToList();
        }

        [TestMethod]
        public void ProductGetCapsTest()
        {
            var productRepository = new ProductRepository(new YapartStoreContext());
            var result = productRepository.GetAllCaps().ToList();
        }

        
    }
}
