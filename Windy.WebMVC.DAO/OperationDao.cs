using Heren.MedQC.DAO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windy.WebMVC.DAO;

namespace Heren.MedQC.DAO
{
    public class OperationDao:BaseDao
    {


        private static OperationDao m_Instance = null;

        /// <summary>
        /// 获取系统运行上下文实例
        /// </summary>
        public static OperationDao Instance
        {
            get
            {
                if (m_Instance == null)
                    m_Instance = new OperationDao();
                return OperationDao.m_Instance;
            }
        }
        /// <summary>
        /// 获取手术代码
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        public IList<OperationInfo> GetOperationInfos(OperationInfo operationInfo)
        {
            var reValue = SqlMapper.QueryForList<OperationInfo>("GetOperationInfos", operationInfo);
            logger.Debug("GetOperationInfos:" + (reValue == null ? 0 : reValue.Count));
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
