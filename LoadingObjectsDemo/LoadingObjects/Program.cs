using Microsoft.EntityFrameworkCore;

namespace LoadingObjects
{

    public class Program
    {

        public static void Main()
        {
            //Eager 
            using (var context = new SchoolContext()) {

                //Eagerly Loaded Related courses to student 
                var studentWithCourses = context.Students.Include(s => s.Courses).ToList(); //
                                                   
            }

            //Lazy     
            using(var context2 = new SchoolContext())
            {

                //related entities are not loaded until accessed 
                var students = context2.Students.ToList(); 


               
                foreach(var student in students)
                {
                    Console.WriteLine($"{student.StudentName}");
                }


                //acceess coureses for each Student to trigger Lazy Loading 
                foreach (var course in students.Courses()) { }
                {
                    Console.WriteLine($"{course}");
                }


            }


            //Lazy Loading example 


            //Eager Loading Example 

            // var courses = contaxt.Courses.Include(char => char.Instructor).ToList();
            //Include method will internally uses join 

            //For Single Properties 
            //  ContextBoundObject.Courses.Include(c => c.Author());

            //For Collection  Propeties
           // ContextBoundObject.Courses.Include(a => a.Tags.Select(t => t.Moderator)).Include(c => c.Category).Include(c => c.Cover) ;
        } 
    }
}

//BEST EXAMPLE   ->> Eager vs Lazy 

// If I ask you to get me Tom's personal data and I alert you that I will probably need personal data of (some of) his children;
// would you rather fetch all this data of Tom and all of his children at once (eager loading) or
// would you rather give me Tom's data and then promise me that you will go and get any of his children's data
// if I end up asking for it (lazy loading)? Both approaches have their benefit, lazy loading can avoid loading unused data,
// but eager loading minimizes the trips to the database. 

// -- https://stackoverflow.com/questions/31366236/lazy-loading-vs-eager-loading