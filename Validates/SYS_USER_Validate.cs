using GalaSoft.MvvmLight;
using MvvmlightWpfApp.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MvvmlightWpfApp.Entity.Fysite
{
    public partial class SYS_USER : IDataErrorInfo
    {        
        public string Error => throw new NotImplementedException();

        public string this[string columnName]
        {
            get
            {
                //Regex digitalReg = new Regex(@"^[-]?[1-9]{6}\d*$|^[0]{1}$");
                if (columnName == nameof(this.LOGIN_NAME_PropertyChanged) && String.IsNullOrEmpty(this.LOGIN_NAME_PropertyChanged))
                {
                    return "用户名不能为空";
                }
                if (columnName == nameof(this.PASSWORD_PropertyChanged))
                {
                    if (String.IsNullOrEmpty(this.PASSWORD_PropertyChanged))
                    {
                        return "密码不能为空";
                    }
                    //if (!String.IsNullOrEmpty(this.PASSWORD))
                    //{
                    //    if (!digitalReg.IsMatch(this.PASSWORD))
                    //    {
                    //        return "密码必须为6位的数值";
                    //    }
                    //}
                }               
                return null;
            }
        }
    }
}
