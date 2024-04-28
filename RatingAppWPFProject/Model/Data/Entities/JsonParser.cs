using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RatingAppWPFProject.Model.Data.Entities
{
    public static class JsonParser<T>
    {
        public static string Serialized(T data)
        {

            var jsonData = JsonSerializer.Serialize(data);

            return jsonData;
        }

        public static T Deserialized(string jsonData)
        {
            return JsonSerializer.Deserialize<T>(jsonData)!;
        }
    }
}
