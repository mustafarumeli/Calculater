using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Calculater.Models
{
    public class EquationResult : RabbitMesseagable
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public ResultType ResultType { get; set; }
        public double Root1 { get; set; }
        public double Root2 { get; set; }
        public string GetResult()
        {
            throw new System.NotImplementedException();
        }
    }
}