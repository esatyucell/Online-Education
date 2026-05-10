using OnlineEdu.Business.Abstract;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.Business.Concrete
{
    public class ContactManager(IRepository<Contact> _repository) : GenericManager<Contact>(_repository), IContactService
    {
    }
}
