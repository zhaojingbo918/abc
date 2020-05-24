using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioX.FilterControls.Models
{
    /// <summary>
    /// 筛选项
    /// </summary>
    public class FilterItem : PropertyChangeBase
    {
        private string _leftValue;

        public string LeftValue
        {
            get { return _leftValue; }
            set
            {
                _leftValue = value;
                this.OnPropertyChanged(nameof(LeftValue));
            }
        }

        private string _rightValue;

        public string RightValue
        {
            get { return _rightValue; }
            set
            {
                _rightValue = value;
                this.OnPropertyChanged(nameof(RightValue));
            }
        }

        private CompairOperators _compairOperator;

        /// <summary>
        /// 比较运算符
        /// </summary>
        public CompairOperators CompairOperator
        {
            get { return _compairOperator; }
            set
            {
                _compairOperator = value;
                this.OnPropertyChanged(nameof(CompairOperator));
            }
        }

    }
}
