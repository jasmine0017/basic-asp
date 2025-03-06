using BasicASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicASP.Controllers
{
	public class StudentController : Controller
	{
		public IActionResult Index()
		{
			Student student = new Student();	
			student.Id = 1;
			student.Name = "Sirisopha";
			student.Score = 99;

			var st = new Student();
			st.Id = 2;
			st.Name = "Siriwan";
			st.Score = 88;

			Student std = new();
			std.Id = 3;
			std.Name = "Kosol";
			std.Score = 0;

			List<Student> students = new List<Student>();
			students.Add(student);
			students.Add(std);
			students.Add(st);

			return View(students);
		}

		public IActionResult Create()
		{
			return View();
		}

		public IActionResult Update(int id)
		{
			return Content($"Detail {id}");
		}

		public IActionResult Delete(int id)
		{
			return Content($"Detail {id}");
		}
	}
}
