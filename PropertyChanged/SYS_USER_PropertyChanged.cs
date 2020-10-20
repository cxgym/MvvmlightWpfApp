using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace MvvmlightWpfApp.Entity.Fysite
{
    /// <summary>
    /// 由于EF生成的实体类中的属性访问器set没有通知事件，所以这是一个PropertyChanged辅助类。
    /// ObservableObject不要忘记了，或者继承ViewModelBase
    /// RaisePropertyChanged即是发送消息，是mvvmlight messenger的一种默认实现形式
    /// </summary>
    public partial class SYS_USER : ViewModelBase
    {
        private string _LOGIN_NAME_PropertyChanged;
        public string LOGIN_NAME_PropertyChanged
        {
            get { return _LOGIN_NAME_PropertyChanged; }          
            set { String oldValue = _LOGIN_NAME_PropertyChanged; _LOGIN_NAME_PropertyChanged = value; RaisePropertyChanged(() => LOGIN_NAME_PropertyChanged, oldValue, value,true); PropertyChanged += PropertyChanged_LOGIN_NAME; }        
        }

        private string _PASSWORD_PropertyChanged;
        public string PASSWORD_PropertyChanged
        {
            get { return _PASSWORD_PropertyChanged; }
            set { String oldValue = _PASSWORD_PropertyChanged; _PASSWORD_PropertyChanged = value; RaisePropertyChanged(() => PASSWORD_PropertyChanged, oldValue, value, true); PropertyChanged += PropertyChanged_PASSWORD; }
        }

        private void PropertyChanged_LOGIN_NAME(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            LOGIN_NAME = LOGIN_NAME_PropertyChanged;
        }

        private void PropertyChanged_PASSWORD(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            PASSWORD = PASSWORD_PropertyChanged;
        }

        //public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        //protected void RaisePropertyChanged(string propertyName)
        //{
        //    System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
        //    if ((propertyChanged != null))
        //    {
        //        propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        //    }
        //}
    }
}
