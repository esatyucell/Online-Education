using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.DataAccess.Abstract
{
    public interface ICourseCategoryRepository
    {
        void ShowOnHome(int id);
        void DontShowOnHome(int id);
    }
}
