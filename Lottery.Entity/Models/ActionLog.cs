using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery.Entities.Models
{
    public class ActionLog
    {
        [Key]
        public int Id { get; set; }

        [Required, Comment("操作行為")]
        public int ActionType { get; set; }

        [Required, Column(TypeName = "char"), StringLength(50), Comment("使用者識別碼")]
        public string UserId { get; set; }

        [Required, Comment("操作紀錄時間")]
        public System.DateTime LogTime { get; set; }

        [Column(TypeName = "nvarchar"), Comment("操作記錄描述")]
        public string LogDesc { get; set; }

        [Column(TypeName = "varchar"), StringLength(50), Comment("來源位址")]
        public string IpAddress { get; set; }

        [Column(TypeName = "nvarchar"), StringLength(200), Comment("功能名稱")]
        public string Logger { get; set; }

        [Column(TypeName = "varchar"), StringLength(100), Comment("程式Area名稱")]
        public string AreaName { get; set; }

        [Column(TypeName = "varchar"), StringLength(100), Comment("程式Controller名稱")]
        public string ControllerName { get; set; }

        [Column(TypeName = "varchar"), StringLength(100), Comment("程式Action名稱")]
        public string ActionName { get; set; }

        [Column(TypeName = "varchar"), StringLength(50), Comment("資料Id")]
        public string MainId { get; set; }

        [Column(TypeName = "varchar"), StringLength(50), Comment("瀏覽器版本")]
        public string BrowserVersion { get; set; }
    }
}
