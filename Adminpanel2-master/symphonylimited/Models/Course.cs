using System;
using System.Collections.Generic;

namespace symphonylimited.Models;

public partial class Course
{
    public string Title { get; set; } = null!;

    public string Discription { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string Fees { get; set; } = null!;

    public string Duration { get; set; } = null!;
}
