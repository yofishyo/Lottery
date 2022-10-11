using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lottery.DataModels.Enums
{
    public enum ActionType
    {
        /// <summary>
        /// None
        /// </summary>
        [Display(Name = "None", Description = "None")]
        None = 0,
        /// <summary>
        /// 新增
        /// </summary>
        [Display(Name = "新增", Description = "新增")]
        Add,
        /// <summary>
        /// 變更
        /// </summary>
        [Display(Name = "變更", Description = "變更")]
        Edit,
        /// <summary>
        /// 刪除
        /// </summary>
        [Display(Name = "刪除", Description = "刪除")]
        Delete,
        /// <summary>
        /// 檢視
        /// </summary>
        [Display(Name = "檢視", Description = "檢視")]
        View,
        /// <summary>
        /// 匯入
        /// </summary>
        [Display(Name = "匯入", Description = "匯入")]
        Import,
        /// <summary>
        /// 匯出
        /// </summary>
        [Display(Name = "匯出", Description = "匯出")]
        Export,
        /// <summary>
        /// 上傳
        /// </summary>
        [Display(Name = "上傳", Description = "上傳")]
        Upload,
        /// <summary>
        /// 下載
        /// </summary>
        [Display(Name = "下載", Description = "下載")]
        Download,
        /// <summary>
        /// 排序
        /// </summary>
        [Display(Name = "排序", Description = "排序")]
        Sort,
        /// <summary>
        /// 還原
        /// </summary>
        [Display(Name = "還原", Description = "還原")]
        Revert
    }
}
