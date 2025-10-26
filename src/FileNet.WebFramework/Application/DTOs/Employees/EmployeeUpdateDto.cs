using FileNet.WebFramework.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace FileNet.WebFramework.Application.DTOs.Employees;

public class EmployeeUpdateDto
{
    [Required]
    public Guid Id { get; set; }

    [Required, StringLength(10)]
    public string NationalCode { get; set; } = default!;

    [Required, StringLength(100)]
    public string FirstName { get; set; } = default!;

    [Required, StringLength(100)]
    public string LastName { get; set; } = default!;

    [Required]
    public Gender Gender { get; set; }

    [Required]
    public Guid DepartmentId { get; set; }
}
