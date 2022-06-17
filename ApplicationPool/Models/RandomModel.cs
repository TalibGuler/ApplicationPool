using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApplicationPool.Models
{
    public class RandomModel
    {
        [JsonPropertyName("author")]
        public string Author { get; set; }
        
        [JsonPropertyName("content")]
        public string Text { get; set; }
    }
}
