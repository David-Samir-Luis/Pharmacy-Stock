using System;
using System.Collections.Generic;

namespace login_page.Models;

public partial class Medicine
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int Quantity { get; set; }

    public DateOnly ExpiryDate { get; set; }

    public int? MinimumQuantity { get; set; }

    public string? Barcode { get; set; }

    public virtual ICollection<OperationsMedicine> OperationsMedicines { get; set; } = new List<OperationsMedicine>();
}
