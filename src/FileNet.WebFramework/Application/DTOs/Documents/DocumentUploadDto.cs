using FileNet.WebFramework.Domain.Entities;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace FileNet.WebFramework.Application.DTOs.Documents;

public class DocumentUploadDto
{
    [Required]
    public Guid EmployeeId { get; set; }

    [StringLength(256)]
    public string? Title { get; set; }

    [Required]
    public DocumentCategory Category { get; set; }

    [Required]
    public IFormFile File { get; set; } = default!;
}
