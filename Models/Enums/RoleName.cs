using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TDEIA.Models.Enums
{
    public enum RoleName
    {
        [Description("管理者")]
        Admin = 0,

        [Description("註冊會員")]
        Member = 1,
    }
}