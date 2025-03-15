using System;
using System.Collections.Generic;

namespace login_page.Models;

public partial class DrugDateStock
{
    public int MedicineId { get; set; }

    public DateOnly ExpireDate { get; set; }

    public int Quantity { get; set; }

    public virtual Medicine Medicine { get; set; } = null!;
}
