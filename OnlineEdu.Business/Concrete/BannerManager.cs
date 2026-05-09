using OnlineEdu.Business.Abstract;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.Business.Concrete
{
    public class BannerManager<T>(IRepository<Banner> _repository) : GenericManager<Banner>(_repository), IBannerService
    {
    }
}
