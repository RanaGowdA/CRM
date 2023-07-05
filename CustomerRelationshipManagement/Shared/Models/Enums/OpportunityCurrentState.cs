using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerRelationshipManagement.Shared
{
    public enum OpportunityCurrentState
    {
        None = 0,
        Qualified,
        Discussion,
        InvitedForProposal,
        ProposalSubmitted,
        Won,
        Lost,
        Suspended,
        Abandonded,
        DemoInstalled
    }
}
