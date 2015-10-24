using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Windy.WebMVC.DAO.Entity;

namespace Windy.WebMVC.DAO.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Orgnization orgnization = new Orgnization();
            var lstOrgnization = OrgnizationDao.Instance.GetOrgnizations(orgnization);
        }
    }
}
