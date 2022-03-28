using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public enum OrderStatuses
    {
        Draft = 1,
        InProgress,
        Payed,
        Completed,
        Failed
    }
}
