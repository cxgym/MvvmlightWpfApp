using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MvvmlightWpfApp.AttachedDIProperties
{
    /// <summary>
    ///     Grid控件的附加属性ShowBorder，像width和height等属性一样，附加属性是设置控件的样式
    ///     Style样式可以实现简单的样式功能，像ShowBorder这样复杂的样式需要后台代码的参与是Style所不能完成的
    /// </summary>
    public static class GridBorderAttachedProperty
    {
        public static bool GetShowBorder(DependencyObject obj)
        {
            return (bool)obj.GetValue(ShowBorderProperty);
        }

        public static void SetShowBorder(DependencyObject obj, bool value)
        {
            obj.SetValue(ShowBorderProperty, value);
        }

        public static readonly DependencyProperty ShowBorderProperty =
            DependencyProperty.RegisterAttached("ShowBorder", typeof(bool), typeof(GridBorderAttachedProperty), new PropertyMetadata(OnShowBorderChanged));


        private static void OnShowBorderChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var grid = d as Grid;

            if ((bool)e.OldValue)
            {
                grid.Initialized -= (s, arg) => { };
            }
            if ((bool)e.NewValue)
            {
                grid.Initialized += (s, arg) =>
                {
                    var controls = grid.Children;
                    var count = controls.Count;

                    for (var i = 0; i < count; i++)
                    {
                        var item = controls[i] as FrameworkElement;

                        #region 单元格边框Thickness详细设计

                        var rowCount = grid.RowDefinitions.Count;
                        var columnCount = grid.ColumnDefinitions.Count;
                        var row = Grid.GetRow(item);
                        var column = Grid.GetColumn(item);
                        var rowspan = Grid.GetRowSpan(item);
                        var columnspan = Grid.GetColumnSpan(item);
                        var thicknessValue = 2;
                        var thickness = new Thickness(thicknessValue);
                        var thicknessColor = Colors.DarkGray;
                        var background = new SolidColorBrush(Colors.White);                       

                        #endregion

                        var border = new Border()
                        {
                            BorderBrush = new SolidColorBrush(thicknessColor),
                            BorderThickness = thickness,
                            Background = background
                        };

                        Grid.SetRow(border, row);
                        Grid.SetColumn(border, column);
                        Grid.SetRowSpan(border, rowspan);
                        Grid.SetColumnSpan(border, columnspan);

                        grid.Children.RemoveAt(i);
                        border.Child = item;
                        grid.Children.Insert(i, border);
                    }
                };
            }
        }
    }
}
