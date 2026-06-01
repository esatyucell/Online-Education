using Microsoft.EntityFrameworkCore;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.DataAccess.Context;
using OnlineEdu.DataAccess.Repositories;
using OnlineEdu.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace OnlineEdu.DataAccess.Concrete
{
    public class CourseRegisterRepositoy : GenericRepository<CourseRegister>, ICourseRegisterRepository
    {
        public CourseRegisterRepositoy(OnlineEduContext _context) : base(_context) { }

        public List<CourseRegister> GetAllWithCourseAndCategory(Expression<Func<CourseRegister, bool>> filter)
        {
            return _context.CourseRegisters.Where(filter).Include(x => x.Course).ThenInclude(x => x.CourseCategory).ToList();
        }
    }
}
