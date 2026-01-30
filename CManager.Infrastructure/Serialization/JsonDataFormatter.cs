using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace CManager.Infrastructure.Serialization
{
    public static class JsonDataFormatter
    {
        private static readonly JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true,
        };
        public static string Serialize<T>(T data) => JsonSerializer.Serialize(data, options);

        public static T? Deserialize<T>(string json) => JsonSerializer.Deserialize<T>(json, options) ?? default;
    }
}
