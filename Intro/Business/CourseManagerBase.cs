using Intro.DataAccess.Concretes;

namespace Intro.Business
{
    public class CourseManagerBase
    {
        /*Course[] courses = new Course[3]; //GetAll'da da coursesı kullanabilmek için CM bloğunun dışına yazdık
        //newlenince ilk CourseManager'ı çağırır
        public CourseManager()
        {

            courses[0] = course1;
            courses[1] = course2;
            courses[2] = course3;

        }*/

        private readonly CourseDal _courseDal;
    }
}