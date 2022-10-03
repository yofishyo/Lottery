using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery.DataModels.Models
{
    public class SampleDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Sort { get; set; }
        public string CreateUserId { get; set; }
        public DateTime CreateDatetime { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDatetime { get; set; }
        public bool IsDelete { get; set; }
    }

    /// <summary>
    /// sample 輸入
    /// </summary>
    public class SampleInputDto
    {
        [Required(ErrorMessage ="姓名 為必要項")]
        public string Name { get; set; }

        [MaxLength(5, ErrorMessage = "最大字數不可超過5個字")]
        public string Description { get; set; }
        public int Sort { get; set; }
        public string CreateUserId { get; set; }     
    }
}
