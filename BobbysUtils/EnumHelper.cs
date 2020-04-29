using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace BobbysUtils
{
    public static class EnumHelper
    {
        public static T EnumSetAll<T>() where T : struct, Enum
        {
            string str = string.Join(", ", Enum.GetNames(typeof(T)));

            if (Enum.TryParse<T>(str, out var e))
            {
                return e;
            }

            return default;
        }

        public static IEnumerable<T> GetEnumValues<T>()
        {
            if (!typeof(T).IsEnum)
            {
                throw new Exception("GetEnumValues is a generic method that accept only enum types!");
            }

            return Enum.GetValues(typeof(T))
                .Cast<T>();
        }

        public static string GetEnumFieldDisplayName(Enum enumValue)
        {
            var fi = enumValue?.GetType().GetField(enumValue.ToString());

            if (fi != null)
            {
                var attributes = (DisplayAttribute)fi.GetCustomAttribute(typeof(DisplayAttribute));
                if (attributes != null)
                {
                    if (attributes.ResourceType != null)
                    {
                        var rsrcType = attributes.ResourceType;
                        var memberName = rsrcType.GetProperty(attributes.Name).GetValue(rsrcType).ToString();

                        return memberName;
                    }
                    else
                    {
                        return attributes.Name;
                    }
                }
            }

            return string.Empty;
        }

        public static IEnumerable<T> GetEnumValuesFromFlags<T>(T flags)
        {
            if (!typeof(T).IsEnum)
            {
                throw new Exception("GetEnumValuesFromFlags is a generic method that accept only enum types!");
            }

            Enum mask = flags as Enum;

            return EnumHelper.GetEnumValues<T>()
                .Cast<Enum>()
                .Where(m => mask.HasFlag(m))
                .Cast<T>();
            ;
        }

        public static IEnumerable<string> GetDisplayNamesFromFlags<T>(T flags)
        {
            IEnumerable<Enum> enums = GetEnumValuesFromFlags(flags).Cast<Enum>();
            return enums.Select(GetEnumFieldDisplayName).Where(x => !string.IsNullOrEmpty(x));
        }
    }
}
