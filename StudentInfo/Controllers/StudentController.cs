using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentInfo.Data;
using StudentInfo.Models;

namespace StudentInfo.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentDbContext _studentDbContext;
        public StudentController(StudentDbContext studentDbContext)
        {
            _studentDbContext = studentDbContext;
        }

        [HttpGet]
        public IActionResult GetStudentList()
        {
            try
            {
                return View(_studentDbContext.Students?.ToList());
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult? AddStudent(StudentModel studentModel)
        {
            try
            {
                _studentDbContext.Students?.Add(studentModel);
                _studentDbContext.SaveChanges();
                return RedirectToAction("GetStudentList");
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message, StatusCode = 500 });
            }
        }

        [HttpGet]
        public IActionResult UpdateStudent(int? id)
        {
            var res = _studentDbContext.Students?.Where(x => x.StudentId == id).SingleOrDefault();
            return View(res);
        }

        [HttpPost]
        public IActionResult UpdateStudent(StudentModel studentModel)
        {
            try
            {
                var exists = _studentDbContext.Students!.Any(x => x.StudentId == studentModel.StudentId);
                if (exists)
                {
                    _studentDbContext.Students?.Update(studentModel);
                    _studentDbContext.SaveChanges();
                    return RedirectToAction("GetStudentList");
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message, StatusCode = 500 });
            }
        }

        [HttpGet]
        public IActionResult DeleteStudent()
        {
            //var res = _studentDbContext.Students?.Where(x => x.StudentId == id).SingleOrDefault();
            //return View(res);

            return View();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            try
            {
                var del = _studentDbContext.Students?.FirstOrDefault(x => x.StudentId == id);
                if (del != null)
                {
                    _studentDbContext.Students?.Remove(del);
                    _studentDbContext.SaveChanges();
                    return RedirectToAction("GetStudentList");
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message, StatusCode = 500 });
            }
        }
    }
}
