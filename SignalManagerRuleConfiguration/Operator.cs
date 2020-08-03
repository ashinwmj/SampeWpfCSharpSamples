using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalManagerRuleConfiguration
{
    public enum Operator
    {
        [Description("=")]
        Equal = 1,

        [Description("<>")]
        NotEqual = 2,

        [Description("<")]
        LessThan = 3,

        [Description("<=")]
        LessThanOrEqual = 4,

        [Description(">")]
        GreaterThan = 5,

        [Description(">=")]
        GreaterThanOrEqual = 6,

        [Description("IN")]
        In = 7,

        [Description("NOT IN")]
        NotIn = 8,

        [Description("Contains")]
        Contains = 9,

        [Description("Does Not Contain")]
        DoesNotContain = 10,

        [Description("Begin With")]
        BeginsWith = 11,

        [Description("Does Not Begin With")]
        DoesNotBeginWith = 12,

        [Description("Ends With")]
        EndsWith = 13,

        [Description("Does Not End With")]
        DoesNotEndWith = 14,

        [Description("IsNULLorEmpty")]
        IsNULL = 17,

        [Description("IsNotNULLorEmpty")]
        IsNotNULL = 18
    }
}
