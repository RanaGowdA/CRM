using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerRelationshipManagement.Shared
{
    public enum LeadStatus
    {
        None = 0,
        Open_Contacted,
        Open_NotContacted,
        Closed_Disqualified,
        Closed_Qualified
    }
}
