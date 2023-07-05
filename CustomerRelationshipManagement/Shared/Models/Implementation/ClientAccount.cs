using CustomerRelationshipManagement.Shared.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRelationshipManagement.Shared.Models.Implementation
{

    // Principal (parent)
    public class ClientAccount : IAccount
    {
        public int Id { get; set; }
        public GeneralDeatils GeneralDeatils { get; set; } = null!;
        public TemplateConfiguration Configuration { get; set; } = null!; // Reference navigation to dependent
        public EngagementModel EngagementModel { get; set; } = null!; // Reference navigation to dependent
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedBy { get; set; }

        public List<Lead> Leads { get; set; } = null!; // Collection navigation containing dependents

    }
}
