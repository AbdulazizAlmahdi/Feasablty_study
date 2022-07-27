using Newtonsoft.Json;
using System.IO;

namespace Feasablty_study.Services
{
    public static class JsonFileConvertAndSave
    {
         private static readonly JsonSerializerSettings _options
                = new() { NullValueHandling = NullValueHandling.Ignore };

            public static void SimpleWrite(object obj, string fileName)
            {
                var jsonString = JsonConvert.SerializeObject(obj, _options);
                File.WriteAllText(fileName, jsonString);
            }
       
    }
}
