using CustomerRelationshipManagement.Shared.Models.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRelationshipManagement.Shared.Models.Interfaces
{
    // Dependent (child)
    public class EngagementModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Organization { get; set; }

        public int ClientAccountId { get; set; } // Required foreign key property
        public ClientAccount ClientAccount { get; set; } // Required reference navigation to principal [one-to-one with shadow foreign key]


        //[One-to-one without navigation to principal and with shadow foreign key]


        public EngagementModel()
        {
            Name = string.Empty;
            Organization = string.Empty;
        }
    }
}
