using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Api.Models;

public class Employee
{
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string LastName { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string Department { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string Position { get; set; } = string.Empty;

    [Range(0, 1000000)]
    public decimal Salary { get; set; }

    public DateTime HireDate { get; set; } = DateTime.UtcNow;
}