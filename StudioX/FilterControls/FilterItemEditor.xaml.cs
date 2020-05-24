using StudioX.FilterControls.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StudioX.FilterControls
{
    /// <summary>
    /// FilterEditor.xaml 的交互逻辑
    /// </summary>
    public partial class FilterItemEditor : Window
    {
        //    private BaseFilter _baseFilter = new AdvanceFilter() { FilterItem1 = new FilterItem() { LeftValue = "值" }, FilterItem2 = new FilterItem() { LeftValue = "值" } };

        private FilterCondition _filterCondition = new FilterCondition() { Mode = ComonStrings.ModeBasic };

        public FilterItemEditor()
        {
            InitializeComponent();
            this.DataContext = _filterCondition;
            this.InitFilter();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            base.Close();
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private async void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        /// <summary>
        /// 添加筛选条件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            var condition = new FilterItem() { LeftValue = "值", CompairOperator = CompairOperators.Equal };
            (_filterCondition.Filter as BasicFilter).Filters.Add(condition);
        }

        /// <summary>
        /// and or
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RbtnLogicalOperator_Click(object sender, RoutedEventArgs e)
        {
            (_filterCondition.Filter as AdvanceFilter).LogicalOperator = (sender as RadioButton).Tag.ToString();
        }

        /// <summary>
        /// 模式改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RbtnMode_Click(object sender, RoutedEventArgs e)
        {
            _filterCondition.Mode = (sender as RadioButton).Tag.ToString();
            this.InitFilter();
        }


        private void InitFilter()
        {
            if (_filterCondition.Mode == ComonStrings.ModeBasic)
            {
                if (_filterCondition.Filter is BasicFilter == false)
                {
                    _filterCondition.Filter = new BasicFilter() { };
                }
            }
            else
            {
                if (_filterCondition.Filter is AdvanceFilter == false)
                {
                    _filterCondition.Filter = new AdvanceFilter()
                    {
                        FilterItem1 = new FilterItem() { LeftValue = "值" },
                        FilterItem2 = new FilterItem() { LeftValue = "值" }
                    };
                }
            }
        }
    }
}
