using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Year3ConsoleApp.Week5
{

    //reference : https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/how-to?pivots=dotnet-6-0
    public class Json
    {
        public static void SerializeExample()
        {
            var sampleModel = new SampleModel()
            {
                TaskName = "Json Serialize",
                CreatedAt = DateTime.UtcNow,
                DueDate = DateTime.UtcNow.AddDays(7),
                IsDone = true
            };

            string filename = "serialized.json";
            string jsonString = JsonSerializer.Serialize(sampleModel);
            File.WriteAllText(filename, jsonString);

            Console.WriteLine(jsonString);
        }
        
        public static void DeserializeExample()
        {
            var sampleModel = @"{
                                  ""Id"": ""b4016e5b-2632-428e-b0db-ae3a98438b84"",
                                  ""TaskName"": ""Json Serialize"",
                                  ""IsDone"": true,
                                  ""DueDate"": ""2022-12-03T16:03:25.423663Z"",
                                  ""CreatedAt"": ""2022-11-26T16:03:25.4236112Z""
                                }";

            SampleModel? jsonString = JsonSerializer.Deserialize<SampleModel>(sampleModel);
            Console.WriteLine(jsonString?.TaskName);
        }
    }

    public class SampleModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string TaskName { get; set; }
        public bool IsDone { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
