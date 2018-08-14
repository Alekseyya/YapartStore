using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YapartStore.DAL.Repositories;
using YapartStore.DL.Context;

namespace YapartStore.Tests.DAL
{
    [TestClass]
    public class CategoryUnitTest
    {
        [TestMethod]
        public void GetCategoriesByModification()
        {
            var categoryRepository = new CategoryRepository(new YapartStoreContext());
            var result = categoryRepository.GetCategoriesByModification("4G/C7").ToList();

        }
    }
}
