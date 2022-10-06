using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery.DataModels.Models.JWTAuthentication
{
    /// <summary>
    /// 註冊
    /// </summary>
    public class RegisterModel
    {
        /// <summary>
        /// 帳號
        /// </summary>
        [Required(ErrorMessage = "帳號 為必填")]
        public string Username { get; set; }

        //[EmailAddress]
        //[Required(ErrorMessage = "Email is required")]
        //public string Email { get; set; }

        /// <summary>
        /// 密碼
        /// </summary>
        [Required(ErrorMessage = "密碼 為必填")]
        public string Password { get; set; }
    }
}
