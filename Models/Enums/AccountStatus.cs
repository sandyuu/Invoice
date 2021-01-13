using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Models.Enums
{
    public enum AccountStatus
    {
        [Description("停用")]
        Disable = 0,

        [Description("啟用")]
        Activity = 1,
    }
}