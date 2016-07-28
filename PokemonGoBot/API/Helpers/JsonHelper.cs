﻿#region

using Newtonsoft.Json.Linq;

#endregion

namespace PokemonGoBot.API.Helpers
{
    public class JsonHelper
    {
        public static string GetValue(string json, string key)
        {
            var jObject = JObject.Parse(json);
            return jObject[key].ToString();
        }
    }
}