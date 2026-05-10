using OnlineEdu.Business.Abstract;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.Business.Concrete
{
    public class SubscriberManager(IRepository<Subscriber> _repository) : GenericManager<Subscriber>(_repository), ISubscriberService
    {
    }
}
