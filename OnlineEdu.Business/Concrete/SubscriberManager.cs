using OnlineEdu.Business.Abstract;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.Business.Concrete
{
    public class SubscriberManager<T>(IRepository<Subscriber> _repository) : GenericManager<Subscriber>(_repository), ISubscrşberService
    {
    }
}
