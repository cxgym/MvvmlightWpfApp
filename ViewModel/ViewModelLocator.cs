/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:MvvmlightWpfApp"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using MvvmlightWpfApp.Behaviors;
using MvvmlightWpfApp.Services;
using MvvmlightWpfApp.Services.Impl;
using MvvmlightWpfApp.ViewModel.Issue;
using MvvmlightWpfApp.ViewModel.Statistics;

namespace MvvmlightWpfApp.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            //SimpleIoc简易的服务注入框架
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<NavpanelControlModel>();
            SimpleIoc.Default.Register<CertificateUsageListViewModel>();
            SimpleIoc.Default.Register<NeonatusInfoListViewModel>();
            SimpleIoc.Default.Register<AnnualReportViewModel>();
            SimpleIoc.Default.Register<BottompanelControlModel>();

            #region  注册/入Behaviors Service

            SimpleIoc.Default.Register<IWindowService, WindowService>();
            SimpleIoc.Default.Register<IDispatcherHelper, DispatcherHelper>();
            SimpleIoc.Default.Register<IFycszmService, FycszmService>();
            SimpleIoc.Default.Register<ICurrentWindowService, CurrentWindowService>();

            #endregion
        }

        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();
        public LoginViewModel Login => ServiceLocator.Current.GetInstance<LoginViewModel>();
        public NavpanelControlModel NavpanelControl => ServiceLocator.Current.GetInstance<NavpanelControlModel>();
        public CertificateUsageListViewModel CertificateUsageList => ServiceLocator.Current.GetInstance<CertificateUsageListViewModel>();
        public NeonatusInfoListViewModel NeonatusInfoList => ServiceLocator.Current.GetInstance<NeonatusInfoListViewModel>();
        public AnnualReportViewModel AnnualReport => ServiceLocator.Current.GetInstance<AnnualReportViewModel>();
        public BottompanelControlModel BottompanelControl => ServiceLocator.Current.GetInstance<BottompanelControlModel>();

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
            ServiceLocator.Current.GetInstance<MainViewModel>().Cleanup();
            ServiceLocator.Current.GetInstance<LoginViewModel>().Cleanup();
            ServiceLocator.Current.GetInstance<NavpanelControlModel>().Cleanup();
            ServiceLocator.Current.GetInstance<CertificateUsageListViewModel>().Cleanup();
            ServiceLocator.Current.GetInstance<NeonatusInfoListViewModel>().Cleanup();
            ServiceLocator.Current.GetInstance<AnnualReportViewModel>().Cleanup();
            ServiceLocator.Current.GetInstance<BottompanelControlModel>().Cleanup();
        }
    }
}