using System;
using System.Collections.Generic;

namespace login_page.Models;

public partial class OperationsMedicine
{
    public int OperationId { get; set; }

    public string MedicineCode { get; set; } = null!;

    public short? Quantity { get; set; }

    public virtual Medicine MedicineCodeNavigation { get; set; } = null!;

    public virtual OperationsHistory Operation { get; set; } = null!;
}
