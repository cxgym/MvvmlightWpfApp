using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace MvvmlightWpfApp.Behaviors
{
    /// <summary>
    /// 双击Copy指定内容的行为
    /// </summary>
    public class MouseDoubleClickCopyTextBehavior : Behavior<FrameworkElement>
    {
        /// <summary>
        /// 需要复制的内容
        /// </summary>
        public string CopyText
        {
            get { return (string)GetValue(CopyTextProperty); }
            set { SetValue(CopyTextProperty, value); }
        }

        public static readonly DependencyProperty CopyTextProperty = DependencyProperty.Register("CopyText", typeof(string), typeof(MouseDoubleClickCopyTextBehavior), new PropertyMetadata(null));

        /// <summary>
        /// 行为附加
        /// </summary>
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.PreviewMouseLeftButtonDown += AssociatedObject_PreviewMouseLeftButtonDown;
        }

        /// <summary>
        /// 行为脱离
        /// </summary>
        protected override void OnDetaching()
        {
            base.OnDetaching();
            AssociatedObject.PreviewMouseLeftButtonDown -= AssociatedObject_PreviewMouseLeftButtonDown;
        }

        /// <summary>
        /// 行为执行方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AssociatedObject_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount >= 2)
                Clipboard.SetDataObject(CopyText);
        }
    }
}