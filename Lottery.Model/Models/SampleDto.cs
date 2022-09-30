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
        public int Sort { get; set; }
        public string CreateUserId { get; set; }
        public DateTime CreateDatetime { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDatetime { get; set; }
        public bool IsDelete { get; set; }
    }
}
