﻿using System;
using System.Globalization;

namespace StaticResourceProblem.Coverters
{
	public class DummyConverter:IValueConverter
	{


        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}

