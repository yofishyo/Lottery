using Microsoft.EntityFrameworkCore;
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

        [Required, Column(TypeName = "nvarchar"), StringLength(128), Comment("名稱")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar"), StringLength(256), Comment("描述")]
        public string Description { get; set; }

       
        [Comment("排序")]
        public int Sort { get; set; }

        //[Required, Column(TypeName = "char"), StringLength(50), Comment("建立者")]
        //public string CreateUserId { get; set; }

        [Required, Comment("建立時間")]
        public DateTime CreateDatetime { get; set; }

        [Column(TypeName = "char"), StringLength(50), Comment("異動者")]
        public string UpdateUserId { get; set; }

        [Comment("異動時間")]
        public DateTime? UpdateDatetime { get; set; }

        public bool IsDelete { get; set; }
    }
}
