using Microsoft.EntityFrameworkCore.Metadata.Internal;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery.Entities.Models
{
    public class Sample
    {
        [Key]
        public int Id { get; set; }

        [Required, Column(TypeName = "nvarchar"), StringLength(128), Description("名稱")]
        public string Name { get; set; }

        [Description("排序")]
        public int Sort { get; set; }

        //[Required, Column(TypeName = "char"), StringLength(50), Description("建立者")]
        //public string CreateUserId { get; set; }

        [Required, Description("建立時間")]
        public DateTime CreateDatetime { get; set; }

        [Column(TypeName = "char"), StringLength(50), Description("異動者")]
        public string UpdateUserId { get; set; }

        [Description("異動時間")]
        public DateTime? UpdateDatetime { get; set; }

        public bool IsDelete { get; set; }
    }
}
