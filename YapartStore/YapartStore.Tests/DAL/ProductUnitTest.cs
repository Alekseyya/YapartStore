﻿using System;
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

            var result = productRepository.GetAll();
            var aa = 0;
            
            
        }
    }
}
