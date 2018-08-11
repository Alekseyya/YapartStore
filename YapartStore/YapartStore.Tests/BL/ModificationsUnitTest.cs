using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YapartStore.BL.Services;
using YapartStore.DAL.Repositories;
using YapartStore.DAL.Repositories.Base;

namespace YapartStore.Tests.BL
{
    [TestClass]
    public class ModificationsUnitTest
    {
        [TestMethod]
        public async Task GetModificationsByModelName()
        {
            var unitOfWork = (IUnitOfWork)new UnitOfWork();
            var modificationService = new ModificationService(unitOfWork);

            var result = await modificationService.GetAllModificationByModelName("A6");
            
        }
    }
}
