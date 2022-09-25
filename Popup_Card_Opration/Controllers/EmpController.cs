using Microsoft.AspNetCore.Mvc;
using Popup_Card_Opration.Models;

namespace Popup_Card_Opration.Controllers
{
    public class EmpController : Controller
    {
        private readonly ApplicationContext _context;

        public EmpController(ApplicationContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Employees.ToList();
            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            Employee emp = new Employee();
            return PartialView("_EmployeeModelPartial", emp);
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            var data = _context.Employees.Add(employee);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var data = _context.Employees.Where(x => x.Id == id).FirstOrDefault();
            return PartialView("_DetailsEmployeeModalPartial", data);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = _context.Employees.Where(x => x.Id == id).FirstOrDefault();
            return PartialView("_DeleteEmployeeModalPartial", data);
        }
        [HttpPost]
        public IActionResult Delete(int id,Employee employee)
        {
            var data = _context.Employees.Where(x => x.Id == id).FirstOrDefault();
            _context.Employees.Remove(data);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data = _context.Employees.Where(x => x.Id == id).FirstOrDefault();
            return PartialView("_EditEmployeeModalPartial", data);
        }
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
