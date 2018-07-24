using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YapartStore.UI.Services;

namespace YapartStore.Tests.UI.Services
{
    [TestClass]
    public class ModelServiceUnitTest
    {
        [TestMethod]
        public async Task GetModelByMarkNameTest()
        {
            ModelService modelService = new ModelService();
            var result = await modelService.GetModelByMarkName("audi");

        }
    }
}
