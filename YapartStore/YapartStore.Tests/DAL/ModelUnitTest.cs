using System;
using System.Data.Entity;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YapartStore.DAL.Repositories;
using YapartStore.DL.Context;

namespace YapartStore.Tests.DAL
{
    [TestClass]
    public class ModelUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var yapartContext = new YapartStoreContext();
            var models = new ModelRepository(yapartContext);
            //Act
            var result = models.GetAll().ToList();

            //Assert
            var aa = 0;
        }
    }
}
