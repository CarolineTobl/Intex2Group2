using System;
using System.Collections.Generic;

namespace Intex2Group2.Data.Scaffolded;

public partial class AspNetUserToken
{
    public string UserId { get; set; } = null!;

    public string LoginProvider { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Value { get; set; }
}
