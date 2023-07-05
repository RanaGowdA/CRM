using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRelationshipManagement.Shared.Models.Interfaces
{
    public class EngagementModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Organization { get; set; }

        public EngagementModel()
        {
            Name = string.Empty;
            Organization = string.Empty;
        }
    }
}
