using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioX.FilterControls.Models
{
    [Serializable]
    public enum CompairOperators
    {
        None, //无
        LessThan,//<
        GreaterThan,//>
        LessThanOrEqual,
        GreaterThanOrEqual,
        Equal,
        NotEqual,
        IsNull,//为空
        NotNull,//不为空
        StartWith,//开头为
        EndWith,//结尾为
        Contains,//包含
    }
}