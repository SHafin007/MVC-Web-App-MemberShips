﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Memberdhips_1.Extensions
{
    public static class ReflectionExtensions
    {
        public static string GetPropertyValue<T>(this T item,string propertyName)
        {
            return item.GetType().GetProperty(propertyName).GetValue(item, null).ToString();
        }
    }
}