using OnlineEdu.Business.Abstract;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.Business.Concrete
{
    public class TestimonialManager(IRepository<Testimonial> _repository) : GenericManager<Testimonial>(_repository), ITestimonialService
    {
    }
}
