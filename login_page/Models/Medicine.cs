using System;
using System.Collections.Generic;

namespace login_page.Models;

public partial class Medicine
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int Quantity { get; set; }

    public int? MinimumQuantity { get; set; }

    public string? Barcode { get; set; }

    public int? Price { get; set; }

    public int Id { get; set; }

    public virtual ICollection<DrugDateStock> DrugDateStocks { get; set; } = new List<DrugDateStock>();

    public virtual ICollection<OperationsMedicine> OperationsMedicines { get; set; } = new List<OperationsMedicine>();
}
