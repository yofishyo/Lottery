using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery.Entities.Models
{
    /// <summary>
    /// User角色
    /// </summary>
    public class UserRoles
    {
        /// <summary>
        /// 管理者(主管)
        /// </summary>
        public const string Admin = "Admin";
        /// <summary>
        /// 一般使用者(工作人員)
        /// </summary>
        public const string User = "User";
    }
}
