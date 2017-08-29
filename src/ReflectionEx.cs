using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Zeeko.UtilsPack
{
    public static class ReflectionEx
    {
        public static IEnumerable<MemberInfo> GetFieldsAndProperties(this Type type) =>
            type.GetMembers(BindingFlags.Instance | BindingFlags.Public)
                .Where(mem => mem.MemberType == MemberTypes.Field || mem.MemberType == MemberTypes.Property);
    }
}
