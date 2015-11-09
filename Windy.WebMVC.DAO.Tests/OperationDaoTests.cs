using Microsoft.VisualStudio.TestTools.UnitTesting;
using Windy.WebMVC.DAO;
using Windy.WebMVC.DAO.Entity;

namespace Heren.MedQC.DAO.Tests
{
    [TestClass()]
    public class OperationDaoTests
    {
        [TestMethod()]
        public void GetOperationInfosTest()
        {
            OperationInfo orgnization = new OperationInfo();
            var lstOrgnization = OperationDao.Instance.GetOperationInfos(orgnization);
        }
    }
}