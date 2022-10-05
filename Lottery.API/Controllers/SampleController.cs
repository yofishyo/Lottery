using Lottery.DataModels.Models;
using Lottery.Services.Services;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System.Net;

namespace Lottery.API.Controllers
{
    /// <summary>
    /// 範例CRUD
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly ISampleService  _sampleService;

        public SampleController(ISampleService sampleService)
        {
            _sampleService = sampleService;
        }

        /// <summary>
        /// 取得 (單筆)
        /// </summary>
        /// <param name="id"></param>
        /// <response code="404">找不到該筆資料</response>    
        /// <returns></returns>
        [HttpPost]
        [Route("Get")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(SampleDto), (int)HttpStatusCode.OK)]
        public ActionResult<SampleDto> Get(int id)
        {
            var result = _sampleService.Get(id);
            if (result is null) Response.StatusCode = (int)HttpStatusCode.NotFound;

            return result;
        }

        /// <summary>
        /// 取得 (多筆)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAll")]
        [Produces("application/json")]
        [Authorize]
        public ActionResult<List<SampleDto>> GetAll()
        {
            var list = _sampleService.GetAll();
            return Ok(list);
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Create")]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        public ActionResult Create(SampleInputDto dto)
        {
            var result = _sampleService.Create(dto);
            return Ok(result);
        }

        /// <summary>
        /// 刪除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("Delete")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        public ActionResult Delete(int id)
        {
            var result = _sampleService.DeleteById(id);
            return Ok(result);
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Update")]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        public ActionResult Update(SampleDto dto)
        {
            var result = _sampleService.Update(dto);
            return Ok(result);
        }
    }
}
