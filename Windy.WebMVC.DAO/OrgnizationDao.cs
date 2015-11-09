using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windy.WebMVC.DAO.Entity;

namespace Windy.WebMVC.DAO
{
    public class OrgnizationDao:BaseDao
    {


        private static OrgnizationDao m_Instance = null;

        /// <summary>
        /// 获取系统运行上下文实例
        /// </summary>
        public static OrgnizationDao Instance
        {
            get
            {
                if (m_Instance == null)
                    m_Instance = new OrgnizationDao();
                return OrgnizationDao.m_Instance;
            }
        }
        /// <summary>
        /// 获取手术代码
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        public IList<Orgnization> GetOrgnizations(Orgnization orgnization)
        {
            var reValue = SqlMapper.QueryForList<Orgnization>("GetOrgnizations", orgnization);
              logger.Debug("GetOrgnizations:" + (reValue == null ? 0 : reValue.Count));
            return reValue;
        }
        /// <summary>
        /// 插入手术代码
        /// </summary>
        /// <param name="checkPatientModel"></param>
        /// <returns></returns>
        public int InsertOperationInfo(OperationInfo operationInfo)
        {
            SqlMapper.Insert("InsertOperationInfo", operationInfo);
            return 1;
        }
    }
}
