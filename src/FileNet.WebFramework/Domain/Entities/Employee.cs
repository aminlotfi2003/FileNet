namespace FileNet.WebFramework.Domain.Entities;

public class Employee : EntityBase
{
    public Guid DepartmentId { get; set; }
    public Department Department { get; set; } = default!;

    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string NationalCode { get; set; } = default!;
    public Gender Gender { get; set; }
    public DateTimeOffset BirthDate { get; set; }

    public ICollection<Document> Documents { get; set; } = new HashSet<Document>();

    public Employee() { }
}

public enum Gender : byte
{ 
    Male, 
    Female 
}
