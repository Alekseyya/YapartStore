using System;
using System.Data.Entity;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YapartStore.DAL.Repositories;
using YapartStore.DL.Context;

namespace YapartStore.Tests.DAL
{
    [TestClass]
    public class ModificationUnitTest
    {
        [TestMethod]
        public async Task GetAllModifications()
        {
            //Arrage
            var yapartContext = new YapartStoreContext();
            var modifications = new ModificationRepository(yapartContext);
            //Act
            var result = await modifications.GetAll().ToListAsync();

            //Assert
            var aa = 0;
        }
    }
}
