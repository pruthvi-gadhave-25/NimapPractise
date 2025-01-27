using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;

namespace FileUploadDemo.Controllers
{
    public class FileUploadController : Controller
    {
        public IActionResult Index()
        {   

            return View();
        }

        public async Task<IActionResult> SingleFileUpload(IFormFile SingleFile)
        {
           if(ModelState.IsValid)
            {

                //using buffering 
                if(SingleFile !=null || SingleFile.Length > 0)
                {
                    var filePath =  Path.Combine(Directory.GetCurrentDirectory(),"www/uploads" ,SingleFile.FileName);

                    using(var stream = System.IO.File.Create(filePath))
                    {
                        await SingleFile.CopyToAsync(stream);
                    }
                    return View("UploadSuccess");
                }
            }
            return View("Index");


        }
    }
}
