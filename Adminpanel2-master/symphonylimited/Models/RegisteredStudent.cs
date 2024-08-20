using System;
using System.Collections.Generic;

namespace symphonylimited.Models;

public partial class RegisteredStudent
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int PhoneNo { get; set; }

    public string Address { get; set; } = null!;

    public string FeeStatus { get; set; } = null!;

    public int CourseId { get; set; }
}
