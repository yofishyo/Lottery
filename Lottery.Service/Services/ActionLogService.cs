using Lottery.DataModels.Enums;
using Lottery.DataModels.Models.JWTAuthentication;
using Lottery.Entities.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Lottery.Services.Services
{
    public class ActionLogService : IActionLogService
    {
        private readonly LotteryDbContext _db;
        private readonly IHttpContextAccessor _httpContext;
        public ActionLogService(LotteryDbContext db, IHttpContextAccessor httpContext) 
        {
            _db = db;
            _httpContext = httpContext;
        }

        /// <summary>
        /// 取得麵包屑路徑。
        /// </summary>
        /// <returns></returns>
        private string GetBreadCrumb()
        {
            //var requestDomain = _httpContext.GetRouter();
            //var currentFunction = GetRepository<MenuFunction>()
            //    .Include(x => x.MenuBlock)
            //    .Include(x => x.MenuBlock.MenuPanel)
            //    .FirstOrDefault(x => !x.IsDelete && x.RouterPath != null && x.RouterPath.Contains(requestDomain));

            //if (currentFunction != null)
            //{
            //    return $"/{currentFunction.MenuBlock.MenuPanel.Name}/{currentFunction.MenuBlock.Name}/{currentFunction.Name}";
            //}
            return string.Empty;
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="mainId">資料編號</param>
        /// <param name="actionType">操作行為</param>
        /// <param name="logger">服務名稱 (若無則自動辨認)</param>
        /// <param name="logDesc">Log 詳細訊息</param>
        /// <returns></returns>
        public bool Add(string mainId, ActionType actionType, string logger = null, string logDesc = null)
        {
            //if (string.IsNullOrWhiteSpace(logger))
            //{
            //    var breadCrumb = GetBreadCrumb();
            //    if (string.IsNullOrWhiteSpace(breadCrumb))
            //    {
            //        return false;
            //    }
            //    logger = breadCrumb;
            //}

            var userId = _httpContext.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            //var userId = _httpContext.HttpContext.User.Identity.Name ?? string.Empty;
            //var ip = _httpContext.GetClientIp();
            //var browser = _httpContext.GetBrowserVersion();
            var data = new ActionLog
            {
                UserId = userId,
                ActionType = (int)actionType,
                //IpAddress = ip,
                Logger = logger,
                LogDesc = logDesc,
                MainId = mainId,
                //BrowserVersion = browser,
                LogTime = DateTime.Now
            };
            _db.ActionLog.Add(data);
            var result = _db.SaveChanges();

            return result > 0 ? true : false;
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="mainId">資料編號</param>
        /// <param name="actionType">操作行為</param>
        /// <param name="logger">服務名稱 (若無則自動辨認)</param>
        /// <param name="logDesc">Log 詳細訊息</param>
        /// <returns></returns>
        public bool Add(int mainId, ActionType actionType, string logger = null, string logDesc = null)
        {
            return Add(mainId.ToString(), actionType, logger, logDesc);
        }
        /// <summary>
        /// 新增多筆
        /// </summary>
        /// <param name="idList">資料編號清單</param>
        /// <param name="actionType">操作行為</param>
        /// <param name="logger">服務名稱 (若無則自動辨認)</param>
        /// <param name="logDesc">Log 詳細訊息</param>
        /// <returns></returns>
        public bool AddMany(IEnumerable<string> idList, ActionType actionType, string logger = null, string logDesc = null)
        {
            if (string.IsNullOrWhiteSpace(logger))
            {
                var breadCrumb = GetBreadCrumb();
                if (string.IsNullOrWhiteSpace(breadCrumb))
                {
                    return false;
                }
                logger = breadCrumb;
            }
            //var userId = _httpContext.User.Identity.GetUserId() ?? string.Empty;
            //var ip = _httpContext.GetClientIp();
            //var browser = _httpContext.GetBrowserVersion();
            var list = idList.Select(x => new ActionLog
            {
                //UserId = userId,
                ActionType = (int)actionType,
                //IpAddress = ip,
                Logger = logger,
                LogDesc = logDesc,
                MainId = x,
                //BrowserVersion = browser,
                LogTime = DateTime.Now
            }).ToArray();
            _db.ActionLog.AddRange(list);
            var result = _db.SaveChanges();

            return result > 0 ? true : false;
        }
        /// <summary>
        /// 新增多筆
        /// </summary>
        /// <param name="idList">資料編號清單</param>
        /// <param name="actionType">操作行為</param>
        /// <param name="logger">服務名稱 (若無則自動辨認)</param>
        /// <param name="logDesc">Log 詳細訊息</param>
        /// <returns></returns>
        public bool AddMany(IEnumerable<int> idList, ActionType actionType, string logger = null, string logDesc = null)
        {
            var strIdList = idList.Select(x => x.ToString()).ToArray();
            return AddMany(strIdList, actionType, logger, logDesc);
        }

        public string GetUserId()
        {
            var userId = _httpContext.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            return userId;
        }
    }

    public interface IActionLogService
    {

        string GetUserId();

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="mainId">資料編號</param>
        /// <param name="actionType">操作行為</param>
        /// <param name="logger">服務名稱 (若無則自動辨認)</param>
        /// <param name="logDesc">操作紀錄描述</param>
        /// <returns></returns>
        bool Add(string mainId, ActionType actionType, string logger = null, string logDesc = null);
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="mainId">資料編號</param>
        /// <param name="actionType">操作行為</param>
        /// <param name="logger">服務名稱 (若無則自動辨認)</param>
        /// <param name="logDesc">操作紀錄描述</param>
        /// <returns></returns>
        bool Add(int mainId, ActionType actionType, string logger = null, string logDesc = null);
        /// <summary>
        /// 新增多筆
        /// </summary>
        /// <param name="idList">資料編號清單</param>
        /// <param name="actionType">操作行為</param>
        /// <param name="logger">服務名稱 (若無則自動辨認)</param>
        /// <param name="logDesc">操作紀錄描述</param>
        /// <returns></returns>
        bool AddMany(IEnumerable<string> idList, ActionType actionType, string logger = null, string logDesc = null);
        /// <summary>
        /// 新增多筆
        /// </summary>
        /// <param name="idList">資料編號清單</param>
        /// <param name="actionType">操作行為</param>
        /// <param name="logger">服務名稱 (若無則自動辨認)</param>
        /// <param name="logDesc">操作紀錄描述</param>
        /// <returns></returns>
        bool AddMany(IEnumerable<int> idList, ActionType actionType, string logger = null, string logDesc = null);
    }
}
