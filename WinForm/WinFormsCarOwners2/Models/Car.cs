using System;
using System.Collections.Generic;

namespace WinFormsCarOwners2.Models;

public partial class Car
{
    public int CarId { get; set; }

    public string CarName { get; set; } = null!;

    public string CarRegistration { get; set; } = null!;

    public int? CarOwnerId { get; set; }

    public int? BrandId { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual Owner? CarOwner { get; set; }
}
