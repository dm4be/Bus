using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bus
{

    public class Config
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public int RoutesCount { get; set; }
        public double SimulationTimeScale { get; set; }
        public int FlowCapacity { get; set; }
        public int BoxOfficesCount { get;  set; }
        public int TimeIntervalInSeconds { get;  set; }

        public static string SerializeToJson(Config config)
        {
            return JsonConvert.SerializeObject(config, Newtonsoft.Json.Formatting.Indented);
        }

        public static Config DeserializeFromJson(string json)
        {
            Console.WriteLine("Try to parse: " + json);
            Config ret = JsonConvert.DeserializeObject<Config>(json);
            Console.WriteLine(ret.FlowCapacity);
            Console.WriteLine(ret.BoxOfficesCount);
            Console.WriteLine(ret.TimeIntervalInSeconds);
            return ret;
        }
    }
}
