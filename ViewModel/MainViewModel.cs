using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using MaterialDesignThemes.Wpf;
using MvvmlightWpfApp.Common;
using MvvmlightWpfApp.Controls;
using MvvmlightWpfApp.Messengers;
using MvvmlightWpfApp.Services.Impl;
using MvvmlightWpfApp.Views.Issue;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace MvvmlightWpfApp.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public Window MainViewWindowIntPtr { get; set; }

        #region  ICommand

        private RelayCommand<RoutedEventArgs> loadedCommand;
        public RelayCommand<RoutedEventArgs> LoadedCommand
        {
            get
            {
                if (loadedCommand == null)
                    loadedCommand = new RelayCommand<RoutedEventArgs>(e => ExcuteLoadedCommand(e));
                return loadedCommand;
            }
            set { loadedCommand = value; }
        }

        #endregion

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
            }
            else
            {              
               
            }
        }

        #region  Command

        private void ExcuteLoadedCommand(RoutedEventArgs e)
        {
            MainViewWindowIntPtr = SimpleIoc.Default.GetInstance<IWindowService>().GetWindowIntPtr(NotificationsToken.MainViewWindowIntPtr);

            var item0 = new ItemMenu("³öÉúÖ¤", new CertificateUsageListView(), PackIconKind.ViewDashboard);

            var menuSchedule = new List<SubItem>();
            menuSchedule.Add(new SubItem("Services", new CertificateUsageListView()));
            menuSchedule.Add(new SubItem("Meetings", new CertificateUsageListView()));
            var item1 = new ItemMenu("Appointments", menuSchedule, PackIconKind.Schedule);

            var menuReports = new List<SubItem>();
            menuReports.Add(new SubItem("Customers", new CertificateUsageListView()));
            menuReports.Add(new SubItem("Providers", new CertificateUsageListView()));
            menuReports.Add(new SubItem("Products", new CertificateUsageListView()));
            menuReports.Add(new SubItem("Stock", new CertificateUsageListView()));
            menuReports.Add(new SubItem("Sales", new CertificateUsageListView()));
            var item2 = new ItemMenu("Reports", menuReports, PackIconKind.FileReport);

            var menuExpenses = new List<SubItem>();
            menuExpenses.Add(new SubItem("Fixed", new CertificateUsageListView()));
            menuExpenses.Add(new SubItem("Variable", new CertificateUsageListView()));
            var item3 = new ItemMenu("Expenses", menuExpenses, PackIconKind.ShoppingBasket);

            var menuFinancial = new List<SubItem>();
            menuFinancial.Add(new SubItem("Cash flow", new CertificateUsageListView()));
            var item4 = new ItemMenu("Financial", menuFinancial, PackIconKind.ScaleBalance);

            var menuRegister = new List<SubItem>();
            menuRegister.Add(new SubItem("Customer", new CertificateUsageListView()));
            menuRegister.Add(new SubItem("Providers", new CertificateUsageListView()));
            menuRegister.Add(new SubItem("Employees", new CertificateUsageListView()));
            menuRegister.Add(new SubItem("Products", new CertificateUsageListView()));
            var item5 = new ItemMenu("Register", menuRegister, PackIconKind.Register);

            var menu = (MainViewWindowIntPtr as FrameworkElement).FindName("Menu") as StackPanel;

            menu.Children.Add(new MenuItemControl(item0));
            menu.Children.Add(new MenuItemControl(item1));
            menu.Children.Add(new MenuItemControl(item2));
            menu.Children.Add(new MenuItemControl(item3));
            menu.Children.Add(new MenuItemControl(item4));
            menu.Children.Add(new MenuItemControl(item5));
        }

        #endregion
    }
}