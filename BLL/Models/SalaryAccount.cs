using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class SalaryAccount
    {
        /// <summary>
        /// Identity：自增长   None：不处理  Computed：表示这一列是计算列。
        /// </summary>
        public int id { get; set; }
        public string account_name { get; set; }

        public string account_pwd { get; set; }

        public DateTime creat_date { get; set; }

        public DateTime? up_date { get; set; }
        /// <summary>
        /// 角色 0 普通用过 1管理 2超级管理 计算状态赋值无效
        /// </summary>
        public int account_role { get; set; }

        public string account_remark { get; set; }
        /// <summary>
        /// 0 正常(使用) 1禁用 2删除
        /// </summary>
        public int account_state { get; set; }
    }
}
