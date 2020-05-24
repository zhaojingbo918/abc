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
        private BaseFilter _baseFilter = new BasicFilter();
        public FilterItemEditor()
        {
            InitializeComponent();
            this.DataContext = _baseFilter;
            //    this.listboxFilter.ItemsSource = _conditions;
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
            (_baseFilter as BasicFilter).Filters.Add(condition);
        }


    }
}
