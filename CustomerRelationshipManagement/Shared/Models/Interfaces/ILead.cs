 
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations; 

namespace CustomerRelationshipManagement.Shared
{
    public interface ILead
    {
        [Key]
        public int LeadId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; }

        public string Organization { get; set; }

        public LeadStatus LeadStatus { get; set; }

        public string EmailAddress { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string Phone { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string MobilePhone { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string Fax { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string WebSite { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Industry { get; set; }

        public int NumberOfEmployees { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Address1 { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string City { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string State { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public int PostalCode { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string Country { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public Geo Geo { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Description { get; set; }

        [Column(TypeName = "nvarchar(50)")]
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

        public SalesTypeNature SalesTypeNature { get; set; }
          
        public Opportunity Opportunity { get; set; }
         
        public Project Project { get; set; }


        public string BusinessType { get; set; }
        public string Offering { get; set; }
        public string ServiceLines { get; set; }



    }
}
