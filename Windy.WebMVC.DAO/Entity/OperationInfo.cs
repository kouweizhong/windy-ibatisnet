using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heren.MedQC.DAO.Entity
{

    /// <summary>
    /// 手术分级信息类
    /// </summary>
    public class OperationInfo
    {
        /// <summary>
        /// 手术代码
        /// </summary>
        public string OperationCode { get; set; }

        /// <summary>
        /// 默认等级1-小；2-中；3-大；4-特；
        /// </summary>
        public int? OperationScale{get;set;}
        /// <summary>
        /// 默认切口0-0；1-Ⅰ；2-Ⅱ；3-Ⅲ；
        /// </summary>
        public int? OperationWound { get; set; }
        /// <summary>
        /// 手术级别1-一级；2-二级；3-三级；4-四级；
        /// </summary>
        public int? OperationLevel { get; set; }


    }
}
