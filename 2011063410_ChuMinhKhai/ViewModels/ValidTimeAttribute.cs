﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace _2011063410_ChuMinhKhai.ViewModels
{
    internal class ValidTime : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value), "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None, out dateTime);
            return isValid;

        }
    }
}