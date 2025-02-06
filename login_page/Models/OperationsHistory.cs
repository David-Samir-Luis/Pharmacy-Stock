using System;
using System.Collections.Generic;

namespace login_page.Models;

public partial class OperationsHistory
{
    public int OperationId { get; set; }

    public string OperationType { get; set; } = null!;

    public DateTime? OperationTime { get; set; }

    public virtual ICollection<OperationsMedicine> OperationsMedicines { get; set; } = new List<OperationsMedicine>();
}
