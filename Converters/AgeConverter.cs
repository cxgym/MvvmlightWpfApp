﻿using MvvmlightWpfApp.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace MvvmlightWpfApp.Converters
{
	public class AgeConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return AgeHelper.CalAgebyBirthday((DateTime)value);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotSupportedException("MethodToValueConverter can only be used for one way conversion.");
		}
	}
}
