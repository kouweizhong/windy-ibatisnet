using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windy.WebMVC.DAO;
using Windy.WebMVC.DAO.Entity;

namespace Windy.WebMVC.Winform
{
    class Program
    {
        static void Main(string[] args)
        {
            OperationInfo orgnization = new OperationInfo();
            var lstOrgnization = OperationDao.Instance.GetOperationInfos(orgnization);
        }
    }
}
