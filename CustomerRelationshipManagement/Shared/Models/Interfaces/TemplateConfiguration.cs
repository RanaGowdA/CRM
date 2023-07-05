using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRelationshipManagement.Shared.Models.Interfaces
{
    public class TemplateConfiguration
    {
        public int Id { get; set; }
        public string Segment { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Name { get; set; }

        public TemplateConfiguration()
        {
            Segment = string.Empty;
            City = string.Empty;
            Region = string.Empty;
            Name = string.Empty;
        }
    }
}
