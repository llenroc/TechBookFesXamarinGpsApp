﻿using System;
using System.Globalization;
using Xamarin.Forms;

namespace GpsAppXamarinForms.ValueConverters
{
    class StartStopTitleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var isRunning = (bool)value;
            return isRunning ? "Stop" : "Start";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
