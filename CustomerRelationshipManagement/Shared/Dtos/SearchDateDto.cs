using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CustomerRelationshipManagement.Shared.Dto
{
    public class SearchDateDto
    {

        [JsonPropertyName("Date")]
        public int Date { get; set; }

        [JsonPropertyName("Month")]
        public int Month { get; set; }

        [JsonPropertyName("Year")]
        public int Year { get; set; }
    }
}
