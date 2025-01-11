using DemoMvc.Data;
using DemoMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoMvc.Controllers
{
    public class StudentController : Controller
    {

        private readonly StudentContext _context;
        public StudentController(StudentContext context)
        {
            _context = context;
        }

        [HttpGet]
        public  IActionResult Add()
        { 
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add( AddStudentViewMoel studentViewMoel)
        {
            if (ModelState.IsValid)
            {               
                var student = new Student
                {
                    Name = studentViewMoel.Name,
                    Phone = studentViewMoel.Phone,
                    Email = studentViewMoel.Email,
                    Subscribed = studentViewMoel.Subscribed,
                    //Photo = studentViewMoel.Photo,
                };

                await _context.Students.AddAsync(student);
                await _context.SaveChangesAsync();
                return RedirectToAction("List");
            }

            else
            {
                return View(studentViewMoel);
            }               
            
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
           var students =  await _context.Students.ToListAsync();
            return View(students);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var students = await _context.Students.FindAsync(id);

            return View(students);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Student viewModal)
        {
            Console.WriteLine(viewModal.Id);
            var student = await _context.Students.FindAsync(viewModal.Id);
                
            if(student is not  null)
            {
                student.Name = viewModal.Name;
                student.Phone = viewModal.Phone;
                student.Email = viewModal.Email;
                student.Subscribed = viewModal.Subscribed;
                await _context.SaveChangesAsync();
            }

           
            return RedirectToAction("List" ,"Student");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Student viewModal)
        {
            var student = await _context.Students.AsNoTracking().FirstOrDefaultAsync(s => s.Id == viewModal.Id);
            if(student != null)
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("List", "Student");
        }
    }
}
