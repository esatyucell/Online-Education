using OnlineEdu.Business.Abstract;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.Business.Concrete
{
    public class SocialMediaManager(IRepository<SocialMedia> _repository) : GenericManager<SocialMedia>(_repository), ISocialMediaService
    {
    }
}
