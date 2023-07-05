

using System.Text.Json.Serialization;

namespace CustomerRelationshipManagement.Shared
{
    public class Lead : ILead
    {

        public int LeadId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Organization { get; set; }
        public LeadStatus LeadStatus { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string Fax { get; set; }
        public string WebSite { get; set; }
        public string Industry { get; set; }
        public int NumberOfEmployees { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
        public Geo Geo { get; set; }
        public string Description { get; set; }
        public string TagList { get; set; }
        public VisibiltyType Visiblity { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public LeadSource LeadSource { get; set; }
        public SalesType SalesType { get; set; }
        public int ForecastedValue { get; set; }
        public Currency ForecastedValueCurrency { get; set; }
        public int CreatedById { get; set; }
        public bool IsOpportunity { get; set; }

        // IsLeadCreatedFromOpportunity
        public bool IsLCFO { get; set; } 
        // IsLeadCreatedFromLead
        public bool IsLCFL { get; set; } 
        // IsLeadCreatedFromProject
        public bool IsLCFP { get; set; }
        public bool IsProject { get; set; }
        public SalesTypeNature SalesTypeNature { get; set; } 
        public Opportunity? Opportunity { get; set; } 
        public Project? Project { get; set; }
        public string BusinessType { get; set; }
        public string Offering { get; set; }
        public string ServiceLines { get; set; }


        public Lead()
        {
            Name = string.Empty;
            LastName = string.Empty;
            Title = string.Empty;
            Organization = string.Empty;
            LeadStatus = LeadStatus.Open_NotContacted;
            EmailAddress = string.Empty;
            Phone = string.Empty;
            MobilePhone = string.Empty;
            Fax = string.Empty;
            WebSite = string.Empty;
            Industry = string.Empty;
            NumberOfEmployees = 0;
            Address1 = string.Empty;
            City = string.Empty;
            State = string.Empty;
            PostalCode = 0;
            Country = string.Empty;
            Geo = Geo.None;
            Description = string.Empty;
            TagList = string.Empty;
            Visiblity = 0;
            BusinessType = string.Empty;
            Offering = string.Empty;
            ServiceLines = string.Empty;
            Project = new Project();
            Opportunity = new Opportunity();

        }
    }
}
