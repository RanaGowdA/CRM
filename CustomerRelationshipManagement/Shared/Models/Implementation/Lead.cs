

using System.Text.Json.Serialization;

namespace CustomerRelationshipManagement.Shared
{
    public class Lead : ILead
    { 
        public int LeadId { get; set; }
        public LeadStatus LeadStatus { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public LeadSource LeadSource { get; set; }
        public SalesType SalesType { get; set; }
        public int ForecastedValue { get; set; }
        public Currency ForecastedValueCurrency { get; set; }
        public int CreatedById { get; set; }
        public bool IsOpportunity { get; set; }
        public SalesTypeNature SalesTypeNature { get; set; }
        public Opportunity Opportunity { get; set; }
        public Project Project { get; set; }
        public string BusinessType { get; set; }
        public string Offering { get; set; }
        public string ServiceLines { get; set; }


        public Lead()
        {

        }
    }
}
