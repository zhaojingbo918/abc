using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioX.FilterControls.Models
{
    /// <summary>
    /// 基本筛选器
    /// </summary>
    [Serializable]
    public class BasicFilter : BaseFilter
    {
        private ObservableCollection<FilterItem> _filters = new ObservableCollection<FilterItem>();

        /// <summary>
        /// 筛选项
        /// </summary>
        public ObservableCollection<FilterItem> Filters
        {
            get { return _filters; }
            set
            {
                _filters = value;
                this.OnPropertyChanged(nameof(Filters));
            }
        }

    }
}
