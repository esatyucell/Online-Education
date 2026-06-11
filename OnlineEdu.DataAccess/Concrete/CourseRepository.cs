using Microsoft.EntityFrameworkCore;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.DataAccess.Context;
using OnlineEdu.DataAccess.Repositories;
using OnlineEdu.DTO.DTOs.CourseDTOs;
using OnlineEdu.Entity;
using OnlineEdu.Entity.CustomModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace OnlineEdu.DataAccess.Concrete
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(OnlineEduContext _context) : base(_context) { }


        public void DontShowOnHome(int id)
        {
            var value = _context.Courses.Find(id);
            value.IsShown = false;
            _context.SaveChanges();
        }

        public void ShowOnHome(int id)
        {
            var value = _context.Courses.Find(id);
            value.IsShown = true;
            _context.SaveChanges();
        }

        public List<Course> GetAllCoursesWithCategories()
        {
            return _context.Courses.Include(x=>x.CourseCategory).ToList();
        }

        public List<Course> GetAllCoursesWithCategories(Expression<Func<Course, bool>> filter = null)
        {
            IQueryable<Course> values = _context.Courses.Include(x => x.CourseCategory).AsQueryable();
            if (filter != null)
            {
                values = values.Where(filter);
            }
            return values.ToList();
        }

        public List<MonthlyCourseCount> GetMonthlyCourseCounts()
        {

            var values = _context.Courses
                .GroupBy(x => x.CourseCreatedDate.Month)
                .Select(y => new MonthlyCourseCount 
                {
                    CourseMonth = y.Key,
                    CourseCount = y.Count()
                })
                .OrderBy(z => z.CourseMonth)
                .ToList();

            return values;
        }

    }
}
