using System;
using System.Collections.Generic;

namespace Intex2Group2.Data.Scaffolded;

public partial class AspNetRoleClaim
{
    public int Id { get; set; }

    public string RoleId { get; set; } = null!;

    public string? ClaimType { get; set; }

    public string? ClaimValue { get; set; }
}
