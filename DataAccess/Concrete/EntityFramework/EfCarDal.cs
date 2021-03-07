using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCarProjectSqlContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCarProjectSqlContext context = new ReCarProjectSqlContext())
            {
                var result = from c in context.Car
                             join b in context.Brand on c.BrandId equals b.BrandId
                             join cl in context.Color on c.ColorId equals cl.ColorId
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandName = b.BrandName,
                                 Description = c.Description,
                                 ColorName = cl.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,




                             };
                return result.ToList();
            }
        }
    }
}
