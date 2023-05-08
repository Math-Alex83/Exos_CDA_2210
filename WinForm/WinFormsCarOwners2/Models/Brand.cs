using System;
using System.Collections.Generic;

namespace WinFormsCarOwners2.Models;

public partial class Brand
{
    public int BrandId { get; set; }

    public string BrandName { get; set; } = null!;

    public string? BrandSlogan { get; set; }

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
}
