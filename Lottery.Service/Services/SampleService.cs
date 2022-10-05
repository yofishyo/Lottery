using Lottery.DataModels.Models;
using Lottery.Entities.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery.Services.Services
{
    public class SampleService : ISampleService
    {
        private readonly LotteryDbContext _db;
        public SampleService(LotteryDbContext db)
        {
            _db = db;
        }

        public bool Create(SampleInputDto dto)
        {
            var efData = Map(dto);

            _db.Sample.Add(efData);
            var result = _db.SaveChanges();

            return result > 0 ? true : false;
        }

        private Sample Map(SampleInputDto dto)
        {
            var ef = new Sample
            {
                Name = dto.Name,
                Description = dto.Description,
                CreateDatetime = DateTime.Now,
                Sort=dto.Sort,
            };

            return ef;
        }

        public bool DeleteById(int id)
        {
            var data = _db.Sample.Find(id);
            if (data is null) return false;

            data.IsDelete = true;
            data.UpdateDatetime = DateTime.Now;
            _db.SaveChanges();
            return true;
        }

        public List<SampleDto> GetAll()
        {
            var result = _db.Sample.Where(x=>!x.IsDelete)
                                .Select(x => new SampleDto
                                {
                                    Id = x.Id,
                                    Name = x.Name,
                                    Sort = x.Sort,
                                    IsDelete=x.IsDelete
                                }).ToList();

            return result;
        }

        public SampleDto Get(int id)
        {      
            var result = _db.Sample.Where(x => x.Id == id && !x.IsDelete)
                 .Select(x => new SampleDto
                 {
                     Id = x.Id,
                     Name = x.Name,
                     Sort = x.Sort,
                     IsDelete = x.IsDelete
                 }).FirstOrDefault();

            return result;
        }

        public bool Update(SampleDto dto)
        {
            var ef = _db.Sample.Find(dto.Id);

            if (ef is null) return false;

            ef.Name = dto.Name;
            ef.Sort = dto.Sort;
            ef.UpdateDatetime = DateTime.Now;

            _db.Sample.Update(ef);
            _db.SaveChanges();
            return true;
        }
    }

    public interface ISampleService
    {
        /// <summary>
        /// 取得 單筆
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        SampleDto Get(int id);

        /// <summary>
        /// 取得 多筆
        /// </summary>
        /// <returns></returns>
        List<SampleDto> GetAll();

        /// <summary>
        /// 刪除
        /// </summary>
        /// <param name="id"></param>
        bool DeleteById(int id);

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        bool Create(SampleInputDto dto);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        bool Update(SampleDto dto);
    }
}
