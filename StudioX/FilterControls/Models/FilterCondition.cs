using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioX.FilterControls.Models
{
    /// <summary>
    /// 过滤条件
    /// </summary>
    public class FilterCondition : PropertyChangeBase
    {
        public const string ModeBasic = "basic";
        public const string ModeAdvance = "advance";

        private string _mode = FilterCondition.ModeBasic;

        /// <summary>
        /// 模式，basic|advance
        /// </summary>
        public string Mode
        {
            get { return _mode; }
            set
            {
                _mode = value;
                this.OnPropertyChanged(nameof(Mode));
            }
        }

        private BaseFilter _filter;
        /// <summary>
        /// 筛选器
        /// </summary>
        public BaseFilter Filter
        {
            get { return _filter; }
            set
            {
                _filter = value;
                this.OnPropertyChanged(nameof(Filter));
            }
        }

        //public override string ToString()
        //{
        //    return "[Notes] Date!LastWeekMonday";
        //}
    }
}
