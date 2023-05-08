using System;
using System.Collections.Generic;

namespace WinFormsCarOwners2.Models;

public partial class Owner
{
    public int OwnerId { get; set; }

    public string OwnerLastname { get; set; } = null!;

    public string OwnerFirstname { get; set; } = null!;

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
}
