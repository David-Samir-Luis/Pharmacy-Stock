using System;
using System.Collections.Generic;

namespace login_page.Models;

public partial class OperationsMedicine
{
    public int OperationId { get; set; }

    public int MedicineId { get; set; }

    public short? Quantity { get; set; }

    public virtual Medicine Medicine { get; set; } = null!;

    public virtual OperationsHistory Operation { get; set; } = null!;
}
