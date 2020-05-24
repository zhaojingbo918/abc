using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioX.FilterControls.Models
{
    /// <summary>
    /// 高级筛选器
    /// </summary>
    public class AdvanceFilter : BaseFilter
    {
        private FilterItem _filterItem1;

        public FilterItem FilterItem1
        {
            get { return _filterItem1; }
            set
            {
                _filterItem1 = value;
                this.OnPropertyChanged(nameof(FilterItem1));
            }
        }


        private string _logicalOperator

;
        /// <summary>
        /// 逻辑运算符 and|or
        /// </summary>
        public string LogicalOperator
        {
            get { return _logicalOperator; }
            set
            {
                _logicalOperator = value;
                this.OnPropertyChanged(nameof(LogicalOperator));
            }
        }



        private FilterItem _filterItem2;

        public FilterItem FilterItem2
        {
            get { return _filterItem2; }
            set
            {
                _filterItem2 = value;
                this.OnPropertyChanged(nameof(FilterItem2));
            }
        }

    }
}
