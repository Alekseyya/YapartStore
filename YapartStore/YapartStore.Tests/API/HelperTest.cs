using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YapartStore.API.Helpers;
using YapartStore.BL.Services;
using YapartStore.DAL.Repositories;
using YapartStore.DAL.Repositories.Base;

namespace YapartStore.Tests.API
{
    [TestClass]
    public class HelperTest
    {
        [TestMethod]
        public void ChangePath()
        {
            var unitOfWork = (IUnitOfWork)new UnitOfWork();
            var productService = new ProductService(unitOfWork);

            var result = productService.GetAll();
            var aa = result.ChangePath();
        }
    }
}
