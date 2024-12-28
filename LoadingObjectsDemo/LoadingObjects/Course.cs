namespace LoadingObjects
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int StudentId { get; set; }

        //Naviagtion Propety
        public Student Student { get; set; }

       
    }
}
