namespace FileNet.WebFramework.Domain.Entities;

public class Document
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid EmployeeId { get; set; }
    public Employee Employee { get; set; } = default!;

    public string? Title { get; set; }
    public string FileName { get; set; } = default!;
    public string ContentType { get; set; } = "application/octet-stream";
    public long Size { get; set; }

    public DocumentCategory Category { get; set; }

    public byte[] Data { get; set; } = default!;

    public DateTimeOffset UploadedAt { get; set; } = DateTimeOffset.UtcNow;
}

public enum DocumentCategory : byte
{
    RetentionAndSeparation = 0,     // ابقاء و رهایی
    PersonnelInformation = 1,       // اطلاعات پرسنلی
    InsuranceAndLoans = 2,          // امور بیمه و وام
    VeteranAffairs = 3,             // ایثارگری
    Training = 4,                   // آموزش
    PromotionsAndAppointments = 5,  // ترفیعات و انتصابات
    RewardsAndDiscipline = 6,       // تشویق و تنبیه
    Commission = 7,                 // کمیسیون
    Miscellaneous = 8,              // متفرقه
    LeaveAndDutyTravel = 9,         // مرخصی و ماموریت
    TransfersAndRelocations = 10,   // نقل و انقالات
    Other = 255                     // سایر
}
