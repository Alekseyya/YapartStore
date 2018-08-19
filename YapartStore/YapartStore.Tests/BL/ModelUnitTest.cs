using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YapartStore.BL.Services;
using YapartStore.DAL.Repositories;
using YapartStore.DAL.Repositories.Base;

namespace YapartStore.Tests.BL
{
    [TestClass]
    public class ModelUnitTest
    {
        [TestMethod]
        public async Task GetModelsByMarkNameTest()
        {
            var unitOfWork = (IUnitOfWork)new UnitOfWork();
            var modelService = new ModelService(unitOfWork);

            var result = await modelService.GetModelsByMarkName("Audi");
            
        }
    }
}
