using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Common.Helpers
{
    public static class General
    {
        /// <summary>
        /// Enum value değerine karşılık Display  döndüren metod
        /// </summary>
        /// <typeparam name="TAttribute"></typeparam>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static TAttribute GetAttribute<TAttribute>(this Enum enumValue)
           where TAttribute : Attribute
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<TAttribute>();
        }
    }
}
