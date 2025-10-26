namespace FileNet.WebFramework.Domain.Entities;

public class Department : EntityBase
{
    public string Code { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string? Description { get; set; }

    public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();

    public Department() { }
}
