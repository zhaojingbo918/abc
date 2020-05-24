using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace StudioX
{
    public static class TextBlockHelper
    {
        private static void SourceResourceKeyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TextBlock element = d as TextBlock;
            bool flag = element != null;
            if (flag)
            {
                bool flag2 = e.NewValue != null && !string.IsNullOrEmpty(e.NewValue.ToString());
                if (flag2)
                {
                    bool flag3 = element.Tag != null;
                    if (flag3)
                    {
                        string key = string.Format("{0}{1}", element.Tag, e.NewValue);
                        element.SetResourceReference(TextBlock.TextProperty, key);
                    }
                    else
                    {
                        element.SetResourceReference(TextBlock.TextProperty, e.NewValue);
                    }
                }
                else
                {
                    element.Text = "";
                }
            }
        }


        public static void SetTextResourceKey(TextBlock element, object value)
        {
            element.SetValue(TextBlockHelper.TextResourceKeyProperty, value);
        }


        public static object GetTextResourceKey(TextBlock element)
        {
            return element.GetValue(TextBlockHelper.TextResourceKeyProperty);
        }


        public static readonly DependencyProperty TextResourceKeyProperty = DependencyProperty.RegisterAttached("TextResourceKey", typeof(object), typeof(TextBlockHelper), new PropertyMetadata(string.Empty, new PropertyChangedCallback(TextBlockHelper.SourceResourceKeyChanged)));
    }

}
