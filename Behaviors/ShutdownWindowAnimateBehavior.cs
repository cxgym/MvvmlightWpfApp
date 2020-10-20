using GalaSoft.MvvmLight.Ioc;
using MvvmlightWpfApp.Messengers;
using MvvmlightWpfApp.Services.Impl;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace MvvmlightWpfApp.Behaviors
{
    public class ShutdownWindowAnimateBehavior : Behavior<FrameworkElement>
    {
        public ICurrentWindowService CurrentWindowService => SimpleIoc.Default.GetInstance<ICurrentWindowService>();

        private Window loginViewWindowIntPtr { get; set; }

        #region  单例模式

        //定义一个保存实例的静态变量
        private static ShutdownWindowAnimateBehavior instance;
        //定义一个保证线程同步安全标识
        private static readonly object synchronized = new object();
        //创建单例实例
        public static ShutdownWindowAnimateBehavior GetInstance(ShutdownWindowAnimateBehavior e = null)
        {
            lock (synchronized)
            {
                return instance ?? (instance = e);
            }
        }

        public ShutdownWindowAnimateBehavior()
        {
            GetInstance(this);
        }

        #endregion

        public string ShutdownMode
        {
            get { return (string)GetValue(ShutdownModeProperty); }
            set { SetValue(ShutdownModeProperty, value); }
        }

        public static readonly DependencyProperty ShutdownModeProperty = DependencyProperty.Register("ShutdownMode", typeof(string), typeof(ShutdownWindowAnimateBehavior), new PropertyMetadata(null));

        /// <summary>
        /// 行为附加
        /// </summary>
        protected override void OnAttached()
        {
            base.OnAttached();
        }

        /// <summary>
        /// 行为脱离
        /// </summary>
        protected override void OnDetaching()
        {
            base.OnDetaching();

        }

        //窗体关闭动画效果
        public void Animate()
        {
            switch (ShutdownMode)
            {
                case "SpinZoom":
                    Debug.WriteLine("窗体旋转缩放效果");
                    loginViewWindowIntPtr = SimpleIoc.Default.GetInstance<IWindowService>().GetWindowIntPtr(NotificationsToken.LoginViewWindowIntPtr);
                    var ShutdownAnimateSpinZoomStoryboard = (loginViewWindowIntPtr as FrameworkElement).Resources["ShutdownAnimateSpinZoomStoryboard"] as Storyboard;
                    ShutdownAnimateSpinZoomStoryboard.Completed += ShutdownAnimateSpinZoomStoryboardCompleted;
                    ShutdownAnimateSpinZoomStoryboard?.Begin();
                    break;
                case "Fadeout":
                    Debug.WriteLine("窗体淡入淡出效果");
                    break;
                default:
                    break;
            }
        }

        private void ShutdownAnimateSpinZoomStoryboardCompleted(object sender, EventArgs e)
        {
            CurrentWindowService.Exit(loginViewWindowIntPtr);
        }
    }
}