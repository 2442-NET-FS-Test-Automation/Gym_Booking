using System;
using System.ComponentModel;
using System.Reflection;

namespace Cinema.Data.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            DescriptionAttribute? attribute = value.GetType()
                .GetField(value.ToString())?
                .GetCustomAttribute<DescriptionAttribute>();
            
            return attribute?.Description ?? value.ToString();
        }
    }
}