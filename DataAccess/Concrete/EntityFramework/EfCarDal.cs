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
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet
    public class EfCarDal : EfEntityRepositoryBase<Car, RecapDemoServerContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RecapDemoServerContext context= new RecapDemoServerContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             select new CarDetailDto { Id= c.Id, BrandId= b.BrandId ,BrandName= b.BrandName ,
                                 ColorId= c.ColorId,ColorName = co.ColorName ,DailyPrice = c.DailyPrice , 
                                 Description = c.Description , ModelYear=c.ModelYear };
                return result.ToList();

            }
        }
    }
}
