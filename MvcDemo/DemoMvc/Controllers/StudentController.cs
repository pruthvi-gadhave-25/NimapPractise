using DemoMvc.Data;
using DemoMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

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

            var student = new Student
            {
                Name = studentViewMoel.Name,
                Phone = studentViewMoel.Phone,
                Email = studentViewMoel.Email,
                Subscribed = studentViewMoel.Subscribed,
            };
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
            return View();
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
            var student = await _context.Students.FindAsync(viewModal.Id);
                
            if(student ! == null)
            {
                student.Name = viewModal.Name;
                student.Phone = viewModal.Phone;
                student.Email = viewModal.Email;
                student.Subscribed = viewModal.Subscribed;

            }

            await _context.SaveChangesAsync();
            return RedirectToAction("List" ,"Students");
        }
    }
}
