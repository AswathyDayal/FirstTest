using FirstTest.Data;
using FirstTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstTest.Controllers;

public class EmployeeController(ApplicationDbContext context) : Controller
{
    [HttpGet]
    public IActionResult Create()
    {
        return View(new Employee());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Employee employee)
    {
        if (!ModelState.IsValid)
        {
            return View(employee);
        }

        context.Employees.Add(employee);
        await context.SaveChangesAsync();

        TempData["SuccessMessage"] = "Employee saved successfully.";
        return RedirectToAction(nameof(Create));
    }
}
