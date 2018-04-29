using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YapartStore.DAL.Repositories;
using YapartStore.DL.Context;
using YapartStore.DL.Entities;

namespace YapartStore.Tests.DAL
{
    [TestClass]
    public class PictureUnitTest
    {
        [TestMethod]
        public void GetAllPicturesAsync()
        {
            //Arrage
            var yapartContext = new YapartStoreContext();
            var pictures = new PictureRepository(yapartContext);
            //Act
            var result = Task.Run(() =>
            {
                return pictures.GetAllAsync();
            }).Result;
            
            //Assert
            var aa = 0;
        }
    }
}
