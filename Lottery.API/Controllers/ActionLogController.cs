using Lottery.DataModels.Models;
using Lottery.Services.Services;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lottery.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActionLogController : ControllerBase
    {
        private readonly IActionLogService _actionLogService;
        public ActionLogController(IActionLogService actionLogService)
        {
            _actionLogService = actionLogService;
        }

        [HttpGet]
        [Route("Get")]
        [Produces("application/json")]
        public ActionResult<List<SampleDto>> Get()
        {
            var list = _actionLogService.GetUserId();
            return Ok(list);
        }
    }
}
