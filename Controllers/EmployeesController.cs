using EmployeeManagement.Api.Models;
using EmployeeManagement.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly EmployeeService _service;

    public EmployeesController(EmployeeService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<Employee>>> GetAll()
    {
        return Ok(await _service.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Employee>> GetById(int id)
    {
        var employee = await _service.GetByIdAsync(id);

        if (employee == null)
            return NotFound();

        return Ok(employee);
    }

    [HttpPost]
    public async Task<ActionResult<Employee>> Create(Employee employee)
    {
        var created = await _service.CreateAsync(employee);

        return CreatedAtAction(
            nameof(GetById),
            new { id = created.Id },
            created);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, Employee employee)
    {
        if (id != employee.Id)
            return BadRequest();

        await _service.UpdateAsync(employee);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);

        return NoContent();
    }
}