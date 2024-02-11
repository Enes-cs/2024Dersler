using System;
using Intro.DataAccess.Abstracts;
using Intro.DataAccess.Concretes;
using Intro.Entities;
namespace Intro.Business
{
    //dependency injection
    public class CourseManager
    {
        /*Course[] courses = new Course[3]; //GetAll'da da coursesı kullanabilmek için CM bloğunun dışına yazdık
        //newlenince ilk CourseManager'ı çağırır
        public CourseManager()
        {

            courses[0] = course1;
            courses[1] = course2;
            courses[2] = course3;

        }*/

        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> GetAll()
        {
            // Veri kaynağından çekilir.

            //business rules


            return _courseDal.GetAll();
        }
    }
}

