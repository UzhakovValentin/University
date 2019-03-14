using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Test
{
    public static class Serializer
    {
        public static string ToJson<T>(this T instance)
        {
            return JsonConvert.SerializeObject(instance);
        }

        public static T JsonParseAs<T>(this string source)
        {
            return (T)JsonConvert.DeserializeObject(source, typeof(T));
        }
    }
}
