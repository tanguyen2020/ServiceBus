using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureServiceBus.Common
{
    public static class Helper
    {
        public static T ConvertToObject<T>(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch
            {
                return default(T);
            }
        }
    }
}
